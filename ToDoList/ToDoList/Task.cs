using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
    class Task
    {
        private int _id;
        private bool _status;
        private string _item;

        public int Id { get { return _id; } }
        public string Item { get { return _item; } }
        public bool Status { get { return _status; } set { _status = value; } }

        public void StatusReport()
        {
            Console.WriteLine($"Id: {_id}; Status: {_status}; Item: {_item}");
        }

        public Task(int id, string item)
        {
            _id = id;
            _item = item;
            _status = false;
        }
    }
}
