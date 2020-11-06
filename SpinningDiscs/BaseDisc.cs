using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public Dictionary<int,string> Content { get; set; }
        public string DiscType { get; set; }
        public  int SpinRate { get; set; }

        public BaseDisc(string name, int capacity, Dictionary<int,string> content, int spinRate)
        {
            Name = name;
            Capacity = capacity;
            Content = content;
            DiscType = "";
            SpinRate = 0;

        }

        public void UpdateName(string newName)
        {
            Name = newName;
        }

        public void UpdateCapacity(int newCapacity)
        {
            Capacity = newCapacity;

        }

        public void UpdateContent(Dictionary<int,string> newContent)
        {
            Content = newContent;
        }

        //public void UpdateContentType(string newDiscType)
        //{
        //    DiscType = newDiscType;
        //}

    }


}
