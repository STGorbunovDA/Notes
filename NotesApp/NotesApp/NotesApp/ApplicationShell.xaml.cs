using NotesApp.Views;
using Xamarin.Forms;

namespace NotesApp
{
    public partial class ApplicationShell : Shell
    {
        public ApplicationShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof (NoteAddingPage), typeof(NoteAddingPage));
        }
    }
}