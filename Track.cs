using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab2
{
    public class Track
    {
        private string _artist = null;
        private string _album = null;
        private string _year = null;
        private string _genre = null;
        private string _name = null;
        private string _duration = null;
        private string _likes = null;
        private string _plays = null;

        #region Properties
        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }
        public string Album
        {
            get { return _album; }
            set { _album = value; }
        }
        public string Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        public string Likes
        {
            get { return _likes; }
            set { _likes = value; }
        }
        public string Plays
        {
            get { return _plays; }
            set { _plays = value; }
        }
        #endregion
        public Track()
        {

        }

        public bool CompareWith(Track b)
        {
            return (this.Artist == b.Artist &&
                    this.Album == b.Album &&
                    this.Year == b.Year &&
                    this.Genre == b.Genre &&
                    this.Name == b.Name &&
                    this.Duration == b.Duration &&
                    this.Likes == b.Likes &&
                    this.Plays == b.Plays);
        }
    }
}
