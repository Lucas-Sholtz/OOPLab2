using System.Collections.Generic;
using System.Xml;
using System;

namespace OOPLab2
{
    class DOM : IStrategy
    {
        XmlDocument document = new XmlDocument();
        public List<Track> Process(Track track, string path)
        {
            document.Load(path);
            List<List<Track>> info = new List<List<Track>>();

            if (track.Artist != null)
            {
                info.Add(SearchByAttribute("artist", "ARTIST", track.Artist, 0));
            }
            if (track.Album != null)
            {
                info.Add(SearchByAttribute("album", "ALBUM", track.Album, 1));
            }
            if (track.Year != null)
            {
                info.Add(SearchByAttribute("album", "YEAR", track.Year, 1));
            }
            if (track.Genre != null)
            {
                info.Add(SearchByAttribute("album", "GENRE", track.Genre, 1));
            }
            if (track.Name != null)
            {
                info.Add(SearchByAttribute("track", "NAME", track.Name, 2));
            }
            if (track.Duration != null)
            {
                info.Add(SearchByAttribute("track", "DURATION", track.Duration, 2));
            }
            if (track.Likes != null)
            {
                info.Add(SearchByAttribute("track", "LIKES", track.Likes, 2));
            }
            if (track.Plays != null)
            {
                info.Add(SearchByAttribute("track", "PLAYS", track.Plays, 2));
            }
            return Filter(info, track);
        }
        private List<Track> SearchByAttribute(string nodeName, string attribute, string myTemplate, int level)
        {
            List<Track> result = new List<Track>();

            if (!string.IsNullOrEmpty(myTemplate))
            {
                XmlNodeList list_0 = document.SelectNodes("//" + nodeName + "[@" + attribute + "=\"" + myTemplate + "\"]");
                switch (level)
                {
                    case 2:
                        {
                            foreach (XmlNode node_0 in list_0)
                            {
                                result.Add(Info(node_0));
                            }
                        }
                        break;
                    case 1:
                        {
                            foreach (XmlNode node_0 in list_0)
                            {
                                XmlNodeList list_1 = node_0.ChildNodes;
                                foreach (XmlNode elem in list_1)
                                {
                                    result.Add(Info(elem));
                                }
                            }
                        }
                        break;
                    case 0:
                        {
                            foreach (XmlNode node_0 in list_0)
                            {
                                XmlNodeList list_1 = node_0.ChildNodes;
                                foreach (XmlNode node_1 in list_1)
                                {
                                    XmlNodeList list_2 = node_1.ChildNodes;
                                    foreach (XmlNode elem in list_2)
                                    {
                                        result.Add(Info(elem));
                                    }
                                }
                            }
                        }
                        break;
                    default:
                        {
                            throw new Exception("Incorrect node level\n");
                        }
                }
            }
            return result;
        }
        private Track Info(XmlNode node)
        {
            Track result = new Track();

                result.Artist = node.ParentNode.ParentNode.Attributes.GetNamedItem("ARTIST").Value;
                result.Album = node.ParentNode.Attributes.GetNamedItem("ALBUM").Value;
                result.Year = node.ParentNode.Attributes.GetNamedItem("YEAR").Value;
                result.Genre = node.ParentNode.Attributes.GetNamedItem("GENRE").Value;
                result.Name = node.Attributes.GetNamedItem("NAME").Value;
                result.Duration = node.Attributes.GetNamedItem("DURATION").Value;
                result.Likes = node.Attributes.GetNamedItem("LIKES").Value;
                result.Plays = node.Attributes.GetNamedItem("PLAYS").Value;

            return result;
        }
        private List<Track> Filter(List<List<Track>> list, Track template)
        {
            List<Track> result = new List<Track>();
            if (list.Count!=0)
            {
                Track[] first = list[0].ToArray();
                if (first != null)
                {
                    foreach (var elem in first) 
                    {
                        bool flag = false;
                        foreach (var l in list)
                        {
                            if (l.Count == 0)
                            {
                                return new List<Track>();
                            }
                            foreach (var t in l)
                            {
                                flag = false;
                                if (t.CompareWith(elem))
                                {
                                    flag = true;
                                    break;
                                }
                            }
                            if (!flag)
                            {
                                break;
                            }
                        }
                        if (flag)
                        {
                            result.Add(elem);
                        }
                    }
                }    
            }
            return result;
        }
    }
}
