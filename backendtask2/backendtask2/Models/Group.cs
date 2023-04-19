using Microsoft.AspNetCore.Mvc;

namespace backendtask2.Models
{
    public class Group 
    {
        private object IdPrivate;
        private object NumberPrivate;
        public Group() { }
        public Group(object IdPrivate, object NumberPrivate)
        {
            this.IdPrivate = IdPrivate;
            this.NumberPrivate = NumberPrivate;
        }
        public int Id { get; set; }
        public string Number { get; set; }
    }
}
