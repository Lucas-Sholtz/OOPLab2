using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace OOPLab2
{
    class LINQ : IStrategy
    {
        public List<Track> result = null;
        XDocument document = new XDocument();
        public List<Track> Process(Track track, string path)
        {
            document = XDocument.Load(@path);
            result = new List<Track>();

            List<XElement> matches = (from val in document.Descendants("track")
                                      where            
                                      (
                                      (track.Artist == val.Parent.Parent.Attribute("ARTIST").Value || track.Artist == null) &&                   
                                      (track.Album == val.Parent.Attribute("ALBUM").Value || track.Album == null) &&
                                      (track.Year == val.Parent.Attribute("YEAR").Value || track.Year == null) &&
                                      (track.Genre == val.Parent.Attribute("GENRE").Value || track.Genre == null) &&
                                      (track.Name == val.Attribute("NAME").Value || track.Name == null) &&
                                      (track.Duration == val.Attribute("DURATION").Value || track.Duration == null) &&
                                      (track.Likes == val.Attribute("LIKES").Value || track.Likes == null) &&
                                      (track.Plays == val.Attribute("PLAYS").Value || track.Plays == null)
                                      )
                                      select val).ToList();
            foreach (var m in matches)
            {
                Track newTrack = new Track();
                newTrack.Artist = m.Parent.Parent.Attribute("ARTIST").Value;
                newTrack.Album = m.Parent.Attribute("ALBUM").Value;
                newTrack.Year = m.Parent.Attribute("YEAR").Value;
                newTrack.Genre = m.Parent.Attribute("GENRE").Value;
                newTrack.Name = m.Attribute("NAME").Value;
                newTrack.Duration = m.Attribute("DURATION").Value;
                newTrack.Likes = m.Attribute("LIKES").Value;
                newTrack.Plays = m.Attribute("PLAYS").Value;
                result.Add(newTrack);
            }
            return result;
        }
    }
}
