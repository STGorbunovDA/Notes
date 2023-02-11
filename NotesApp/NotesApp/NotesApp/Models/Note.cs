using System;
using SQLite;

namespace NotesApp.Models
{
    public class Note
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
