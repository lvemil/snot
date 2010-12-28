using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snot.model
{
    public class Note
    {
        private string _Title = string.Empty;

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
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

        private List<TopicAppearance> _Topics = new List<TopicAppearance>();

        public List<TopicAppearance> Topics
        {
            get { return _Topics; }
            set { _Topics = value; }
        }

        private List<ValuedTag> _Tags = new List<ValuedTag>();

        public List<ValuedTag> Tags
        {
            get { return _Tags; }
            set { _Tags = value; }
        }

        public Note(string title, User author)
        {
            _Title = title;
            _Author = author;
        }
    }
}
