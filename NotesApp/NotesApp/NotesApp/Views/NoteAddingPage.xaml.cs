using NotesApp.Models;
using System;

using Xamarin.Forms;

namespace NotesApp.Views
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public partial class NoteAddingPage : ContentPage
    {
        public string ItemId
        {
            set { LoadNote(value); }
        }
        public NoteAddingPage()
        {
            InitializeComponent();
            BindingContext = new Note();
        }
        async void LoadNote(string value)
        {
            try
            {
                int id = Convert.ToInt32(value);
                Note note = await App.NotesDB.GetNoteAsync(id);
                BindingContext = note;
            }
            catch
            {
            }
        }
        async void BtnOnSaveClicked(object sender, EventArgs e)
        {
            Note note = (Note)BindingContext;
            note.Date = DateTime.UtcNow;
            if (!string.IsNullOrWhiteSpace(note.Text))
                await App.NotesDB.SaveNoteAsync(note);
            await Shell.Current.GoToAsync("..");
        }
        async void BtnOnDeleteClicked(object sender, EventArgs e)
        {
            Note note = (Note)BindingContext;
            await App.NotesDB.DeleteNoteAsync(note);
            await Shell.Current.GoToAsync("..");
        }
    }
}