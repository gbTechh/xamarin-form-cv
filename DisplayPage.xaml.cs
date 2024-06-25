using Xamarin.Forms;

namespace UserFormApp
{
    public partial class DisplayPage : ContentPage
    {
        public DisplayPage(UserData userData)
        {
            InitializeComponent();

            NameLabel.Text = $"Nombre: {userData.Name}";
            BirthdateLabel.Text = $"Fecha de Nacimiento: {userData.Birthdate.ToShortDateString()}";
            OccupationLabel.Text = $"Ocupación: {userData.Occupation}";
            ContactLabel.Text = $"Contacto: {userData.Contact}";
            NationalityLabel.Text = $"Nacionalidad: {userData.Nationality}";
            EnglishLevelLabel.Text = $"Nivel de inglés: {userData.EnglishLevel}";
            ProgrammingLanguagesLabel.Text = $"Lenguajes de programación: {string.Join(", ", userData.ProgrammingLanguages)}";
            AptitudesLabel.Text = $"Aptitudes: {userData.Aptitudes}";
            SkillsLabel.Text = $"Habilidades: {string.Join(", ", userData.Skills)}";
            ProfileLabel.Text = $"Perfil: {userData.Profile}";
        }
    }
}
