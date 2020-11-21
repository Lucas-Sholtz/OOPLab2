using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace OOPLab2
{
    public partial class MainForm : Form
    {
        public List<Track> tracks;
        public string path;
        public Track template;
        public WriterHTML writer;
        public MainForm()
        {
            path = "ArtistsDataBase.xml";
            tracks = new List<Track>();
            template = new Track();
            writer = new WriterHTML();
            InitializeComponent();
            Start();
        }

        #region MyMethods
        public void Start()
        {
            XmlDocument document = new XmlDocument();
            document.Load(path);
            XmlNodeList list_1 = document.SelectNodes("//artist");

            SortedSet<string> artistSet = new SortedSet<string>();
            SortedSet<string> albumSet = new SortedSet<string>();
            SortedSet<int> yearSet = new SortedSet<int>();
            SortedSet<string> genreSet = new SortedSet<string>();
            SortedSet<int> durationSet = new SortedSet<int>();
            SortedSet<int> likesSet = new SortedSet<int>();
            SortedSet<int> playsSet = new SortedSet<int>();

            foreach (XmlNode node_1 in list_1)
            {
                XmlNodeList list_2 = node_1.ChildNodes;
                foreach (XmlNode node_2 in list_2)
                {
                    XmlNodeList list_3 = node_2.ChildNodes;
                    foreach (XmlNode elem in list_3)
                    {
                        artistSet.Add(elem.ParentNode.ParentNode.Attributes.GetNamedItem("ARTIST").Value);
                        albumSet.Add(elem.ParentNode.Attributes.GetNamedItem("ALBUM").Value);
                        yearSet.Add(int.Parse(elem.ParentNode.Attributes.GetNamedItem("YEAR").Value));
                        genreSet.Add(elem.ParentNode.Attributes.GetNamedItem("GENRE").Value);
                        durationSet.Add(int.Parse(elem.Attributes.GetNamedItem("DURATION").Value));
                        likesSet.Add(int.Parse(elem.Attributes.GetNamedItem("LIKES").Value));
                        playsSet.Add(int.Parse(elem.Attributes.GetNamedItem("PLAYS").Value));
                    }
                }
            }
            foreach (string artist in artistSet)
            {
                artistBox.Items.Add(artist);
            }
            foreach (string album in albumSet)
            {
                albumBox.Items.Add(album);
            }
            foreach (int year in yearSet)
            {
                yearBox.Items.Add(year);
            }
            foreach (string genre in genreSet)
            {
                genreBox.Items.Add(genre);
            }
            foreach (int duration in durationSet)
            {
                durationBox.Items.Add(duration);
            }
            foreach (int likes in likesSet)
            {
                likesBox.Items.Add(likes);
            }
            foreach (int plays in playsSet)
            {
                playsBox.Items.Add(plays);
            }
        }
        public void Search()
        {
            IStrategy current = null;

            if (radioButtonDom.Checked)
            {
                current = new DOM();
            }
            if (radioButtonSax.Checked)
            {
                current = new SAX();
            }
            if (radioButtonLinq.Checked)
            {
                current = new LINQ();
            }

            tracks = current.Process(template, path);

            outputRich.Clear();
            Print();
        }
        public void Print()
        {
            if (tracks.Count != 0)
            {
                outputRich.AppendText("====================\n");
            }
            foreach (Track t in tracks)
            {
                outputRich.AppendText("Artist: " + t.Artist + "\n");
                outputRich.AppendText("Album: " + t.Album + "\n");
                outputRich.AppendText("Year: " + t.Year + "\n");
                outputRich.AppendText("Genre: " + t.Genre + "\n");
                outputRich.AppendText("Name: " + t.Name + "\n");
                outputRich.AppendText("Duration: " + t.Duration + "\n");
                outputRich.AppendText("Likes: " + t.Likes + "\n");
                outputRich.AppendText("Plays: " + t.Plays + "\n");
                outputRich.AppendText("====================\n");
            }
        }
        public void ClearAndUncheck()
        {
            outputRich.Clear();
            artistBox.Text = null;
            artistBox.Enabled = false;
            albumBox.Text = null;
            albumBox.Enabled = false;
            yearBox.Text = null;
            yearBox.Enabled = false;
            genreBox.Text = null;
            genreBox.Enabled = false;
            durationBox.Text = null;
            durationBox.Enabled = false;
            likesBox.Text = null;
            likesBox.Enabled = false;
            playsBox.Text = null;
            playsBox.Enabled = false;
            artistCheckBox.Checked = false;
            albumCheckBox.Checked = false;
            yearCheckBox.Checked = false;
            genreCheckBox.Checked = false;
            durationCheckBox.Checked = false;
            likesCheckBox.Checked = false;
            playsCheckBox.Checked = false;
        }
        public void UpdateTemplate()
        {
            if (artistCheckBox.Checked)
            {
                template.Artist = artistBox.Text;
            }
            else
            {
                template.Artist = null;
            }
            if (albumCheckBox.Checked)
            {
                template.Album = albumBox.Text;
            }
            else
            {
                template.Album = null;
            }
            if (yearCheckBox.Checked)
            {
                template.Year = yearBox.Text;
            }
            else
            {
                template.Year = null;
            }
            if (genreCheckBox.Checked)
            {
                template.Genre = genreBox.Text;
            }
            else
            {
                template.Genre = null;
            }
            if (durationCheckBox.Checked)
            {
                template.Duration = durationBox.Text;
            }
            else
            {
                template.Duration = null;
            }
            if (likesCheckBox.Checked)
            {
                template.Likes = likesBox.Text;
            }
            else
            {
                template.Likes = null;
            }
            if (playsCheckBox.Checked)
            {
                template.Plays = playsBox.Text;
            }
            else
            {
                template.Plays = null;
            }
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void toHTMLButton_Click(object sender, EventArgs e)
        {
            writer.WriteToXML(tracks);
            writer.TransformToHTML();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearAndUncheck();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            UpdateTemplate();
            Search();
        }

        private void artistCheckBox_Click(object sender, EventArgs e)
        {
            artistBox.Enabled = !artistBox.Enabled;
        }

        private void yearCheckBox_Click(object sender, EventArgs e)
        {
            yearBox.Enabled = !yearBox.Enabled;
        }

        private void genreCheckBox_Click(object sender, EventArgs e)
        {
            genreBox.Enabled = !genreBox.Enabled;
        }

        private void durationCheckBox_Click(object sender, EventArgs e)
        {
            durationBox.Enabled = !durationBox.Enabled;
        }

        private void likesCheckBox_Click(object sender, EventArgs e)
        {
            likesBox.Enabled = !likesBox.Enabled;
        }

        private void playsCheckBox_Click(object sender, EventArgs e)
        {
            playsBox.Enabled = !playsBox.Enabled;
        }

        private void albumCheckBox_Click(object sender, EventArgs e)
        {
            albumBox.Enabled = !albumBox.Enabled;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = MessageBox.Show("Ви хочeте вийти?", "Повідомлення", MessageBoxButtons.YesNo);
            if (exit == DialogResult.No)
            {
                e.Cancel = (exit == DialogResult.No);
            }
        }
    }
}
