using System;
using System.Collections;
using System.Collections.Generic;
namespace bai_tap_them_tong_hop
{
    public class Post : IPost
    {
        private static int _ID = 0;
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        private string _content;
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        private string _author;
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        private float _averagerate ;
        
        public float AverageRate
        {
            get { return _averagerate; }
            set { _averagerate = value; }
        }

        public Post()
        {
            _id = ++_ID;
        }
       
 
        public Post (int id, string title, string content, string author, float averagerate)
        {
            _id = id;
            _title = title;
            _content = content;
            _author = author;
            _averagerate = averagerate;
        }
        public string Display()
        {
            CalculatorRate();

           return $"id:{_id}\t title:{_title}\t content:{_content}\t author:{_author}\t averagerate:{_averagerate}";
        }  
        public List<int> _rateList = new List<int>();

        public double CalculatorRate()
        {
            float AverageRate = 0;
            //float _averagerate ;
            foreach (var item  in _rateList)
            {
                AverageRate += item;
            }
            return _averagerate = AverageRate/_rateList.Count;
        }

        
    }
}