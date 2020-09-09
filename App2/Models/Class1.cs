using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.Models
{
    public class Class1
    {
        private string email;
        private string title;
        private string content;

        public Class1(string email, string title, string content)
        {
            Email = email;
            Title = title;
            Content = content;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public string Title
        {
            get => title;
            set => title = value;
        }
        public string Content
        {
            get => content;
            set => content = value;
        }
        public string ToString()
        {
            return Email + "--" + Title + "--" + Content.ToString() + "\n";
        }
    }
}
