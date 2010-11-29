using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snot.model
{
    public class Idea
    {
        private string _Text;

        public string Text
        {
            get { return _Text; }
            set { _Text = value; }
        }
        private DateTime _DateCreated;

        public DateTime DateCreated
        {
            get { return _DateCreated; }
            set { _DateCreated = value; }
        }
        private DateTime _DateModified;

        public DateTime DateModified
        {
            get { return _DateModified; }
            set { _DateModified = value; }
        }
        private User _Author;

        public User Author
        {
            get { return _Author; }
            set { _Author = value; }
        }

        private int _Order;

        private List<TaggedValue> _Tags;
        

        public Idea(string text)
        {
            _Text = text;
        }

        internal List<TaggedValue> Tags
        {
            get { return _Tags; }
            set { _Tags = value; }
        }
    }
}
