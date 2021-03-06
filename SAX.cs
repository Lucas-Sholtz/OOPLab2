﻿using System;
using System.Collections.Generic;
using System.Xml;

namespace OOPLab2
{
    class SAX : IStrategy
    {
        public List<Track> Process(Track track, string path)
        {
            List<Track> tracks = new List<Track>();

            XmlReader reader = XmlReader.Create(path);
            List<Track> result = new List<Track>();

            string artist = null;
            string album = null;
            string year = null;
            string genre = null;

            while (reader.Read())
            {
                if (reader.Name == "artist")
                {

                    while (reader.MoveToNextAttribute())
                    {
                        if (reader.Name == "ARTIST")
                        {
                            artist = reader.Value;
                        }
                    }
                }
                if (reader.Name == "album")
                {
                    while (reader.MoveToNextAttribute())
                    {
                        if (reader.Name == "ALBUM")
                        {
                            album = reader.Value;
                        }
                        if (reader.Name == "YEAR")
                        {
                            year = reader.Value;
                        }
                        if (reader.Name == "GENRE")
                        {
                            genre = reader.Value;
                        }
                    }
                }
                if (reader.Name == "track")
                {
                    Track find = new Track();
                    find.Album = album;
                    find.Artist = artist;
                    find.Year = year;
                    find.Genre = genre;

                    if (reader.HasAttributes)
                    {
                        while (reader.MoveToNextAttribute())
                        {
                            if (reader.Name == "NAME")
                            {
                                find.Name = reader.Value;
                            }
                            if (reader.Name == "DURATION")
                            {
                                find.Duration = reader.Value;
                            }
                            if (reader.Name == "LIKES")
                            {
                                find.Likes = reader.Value;
                            }
                            if (reader.Name == "PLAYS")
                            {
                                find.Plays = reader.Value;
                            }
                        }
                    }
                    result.Add(find);
                }             
            }
            tracks = Filter(result, track);
            return tracks;
        } 
        private List<Track> Filter(List<Track> tracks, Track template)
        {
            List<Track> result = new List<Track>();
            if (tracks.Count != 0)
            {
                foreach (Track t in tracks)
                {
                    if (((t.Album != null && t.Album == template.Album) || template.Album == null) &&
                        ((t.Artist != null && t.Artist == template.Artist) || template.Artist == null) &&
                        ((t.Year != null && t.Year == template.Year) || template.Year == null) &&
                        ((t.Genre != null && t.Genre == template.Genre) || template.Genre == null) &&
                        ((t.Duration != null && t.Duration == template.Duration) || template.Duration == null) &&
                        ((t.Likes != null && t.Likes == template.Likes) || template.Likes == null) &&
                        ((t.Plays != null && t.Plays == template.Plays) || template.Plays == null))
                    {
                        result.Add(t);
                    }
                }
            }
            return result;
        }
    }
}
