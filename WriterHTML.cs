using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Xsl;
namespace OOPLab2
{
    public class WriterHTML
    {
        public string xsl = @"C:\\Users\\miste\\source\\repos\\OOPLab2\\HTMLOutput.xsl";
        public string output = @"C:\\Users\\miste\\source\\repos\\OOPLab2\\output.xml";
        public string html = @"C:\\Users\\miste\\source\\repos\\OOPLab2\\output.html";

        public void WriteToXML(List<Track> tracks)
        {
            ClearXML();
            foreach(var t in tracks)
            {
                AddToXML(t);
            }
            EndXML();
        }
        void AddToXML(Track track)
        {
            StreamWriter resultsFile = new StreamWriter(output, true);
            resultsFile.WriteLine("<Track");
            resultsFile.WriteLine("Artist = \"" + track.Artist + "\"");
            resultsFile.WriteLine("Album = \"" + track.Album + "\"");
            resultsFile.WriteLine("Year = \"" + track.Year + "\"");
            resultsFile.WriteLine("Genre = \"" + track.Genre + "\"");
            resultsFile.WriteLine("Name = \"" + track.Name + "\"");
            resultsFile.WriteLine("Duration = \"" + track.Duration + "\"");
            resultsFile.WriteLine("Likes = \"" + track.Likes + "\"");
            resultsFile.WriteLine("Plays = \"" + track.Plays + "\">");
            resultsFile.WriteLine("</Track>");
            resultsFile.Close();
        }

        void ClearXML()
        {
            StreamWriter resultsFile = new StreamWriter(output);
            resultsFile.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            resultsFile.WriteLine("<Tracks>");
            resultsFile.Close();
        }

        void EndXML()
        {
            StreamWriter resultsFile = new StreamWriter(output, true);
            resultsFile.WriteLine("</Tracks>");
            resultsFile.Close();
        }

        public void Transform()
        {
            XslCompiledTransform transform = new XslCompiledTransform();
            transform.Load(xsl);
            transform.Transform(output, html);
        }
    }
}
