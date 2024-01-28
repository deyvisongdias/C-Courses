using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção_9___Execicio_2.Entities
{
    internal class Post
    {
        public DateTime date { get; set; }
        public String title { get; set; }
        public String content { get; set; }
        public int likes { get; set; }
        public List<Comment> comment;

        public Post(DateTime date, string title, string content, int likes)
        {
            this.date = date;
            this.title = title;
            this.content = content;
            this.likes = likes;
            comment = new List<Comment>();
        }

        public Post()
        {
        }

        public void AddComment(String text)
        {
            comment.Add(new Comment() { text = text });
        }

        public void PrintComments()
        {
            foreach (Comment comment in comment)
            {
                Console.WriteLine(comment.text);
            }
        }

        public String toString()
        {
            return this.title+"\n"+this.likes+" Likes - "+
                this.date+"\n"+this.content;                   
        }
    }
}
