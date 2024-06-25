using Xamarin.Forms;
using System;
using System.Linq;
using System.Collections.Generic;

namespace UserFormApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnSubmitClicked(object sender, EventArgs e)
        {
            var userData = new UserData
            {
                Name = NameEntry.Text,
                Birthdate = BirthdatePicker.Date,
                Occupation = OccupationEntry.Text,
                Contact = ContactEntry.Text,
                Nationality = NationalityPicker.SelectedItem?.ToString(),
                EnglishLevel = ((RadioButton)GroupEnglishLevel.Children.FirstOrDefault(c => (c as RadioButton).IsChecked))?.Content.ToString(),
                ProgrammingLanguages = ProgrammingLanguagesPicker.SelectedItems.Cast<string>().ToList(),
                Aptitudes = AptitudesEntry.Text,
                Skills = new List<string>
                {
                    TeamworkCheckbox.IsChecked ? "Trabajo en equipo" : null,
                    CommunicationCheckbox.IsChecked ? "Comunicación" : null,
                    LeadershipCheckbox.IsChecked ? "Liderazgo" : null,
                    ProblemSolvingCheckbox.IsChecked ? "Resolución de problemas" : null
                }.Where(s => s != null).ToList(),
                Profile = ProfileEditor.Text
            };

            var displayPage = new DisplayPage(userData);
            await Navigation.PushAsync(displayPage);
        }
    }
}
