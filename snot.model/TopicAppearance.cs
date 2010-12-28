using System;
using System.Collections.Generic;
using System.Text;

namespace snot.model
{
    public class TopicAppearance
    {
        private Topic _Topic;

        public Topic Topic
        {
            get { return _Topic; }
            set { _Topic = value; }
        }
        
        private List<Idea> _Ideas = new List<Idea>();

        public List<Idea> Ideas
        {
            get { return _Ideas; }
            set { _Ideas = value; }
        }

        public TopicAppearance(Topic topic)
        {
            _Topic = topic;
        }

        private List<TopicAppearance> _SubTopics = new List<TopicAppearance>();

        public List<TopicAppearance> SubTopics
        {
            get { return _SubTopics; }
            set { _SubTopics = value; }
        }

        private int _Order;

        public int Order
        {
            get { return _Order; }
            set { _Order = value; }
        }
        private int _Level;

        public int Level
        {
            get { return _Level; }
            set { _Level = value; }
        }
    }
}
