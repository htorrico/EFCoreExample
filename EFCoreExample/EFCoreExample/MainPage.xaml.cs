using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EFCoreExample
{
    public partial class MainPage : ContentPage
    {
        AppDbContext context = new AppDbContext("example.db");
        public MainPage()
        {
            InitializeComponent();
            //Creo la base de datos
            context.Database.EnsureCreated();
         

        }       
        private void btnSave_Clicked(object sender, EventArgs e)
        {
            InsertarPersona(txtName.Text, txtLastName.Text);
        }

        private void InsertarPersona(string firstName, string lastName)
        {

            int PersonId = context.People.Count() + 1;

            //Insertar Personas
            context.People.Add(new Person
            {
                PersonID= PersonId,
                FirstName=firstName,
                LastName=lastName,
            });
            context.SaveChanges();
            DisplayAlert("Alert", "Save", "OK");
            
        }

        private List<Person> ListarPersonas()
        {
            return context.People.ToList();
        }

        private void btnShow_Clicked(object sender, EventArgs e)
        {
            lstViewPeople.ItemsSource = ListarPersonas();
        }
    }
}
