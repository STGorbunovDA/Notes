using System;
using Xamarin.Forms;
using NotesApp.Data;
using System.IO;

namespace NotesApp
{
    public partial class App : Application
    {
        static NotesDB notesDB;
        public static NotesDB NotesDB
        {
            get 
            { 
                if(notesDB == null)
                {
                    notesDB = new NotesDB(
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), 
                        "NotesDatabase.db3"));
                }
                return notesDB;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new ApplicationShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
