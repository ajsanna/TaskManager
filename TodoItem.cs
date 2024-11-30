using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace TaskManager
{
    public class ToDoItem  // Changed from internal to public
    {
        [PrimaryKey, AutoIncrement] // setting up details of the database
        public int ID { get; set; } //setting and getters to view the data, no manipultation
        public string? Name { get; set; } //establishing name field
        public string? Description { get; set; }//establishing description field
        public string? DueDate { get; set; }//establishing description field
        public bool Done { get; set; }//establishing done option 
    }
}


