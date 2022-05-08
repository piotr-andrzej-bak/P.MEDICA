using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Login_MaterialUI
{
    /// <summary>
    /// Interaction logic for Patients.xaml
    /// </summary>
    public partial class Patients : Page
    {
        DataClasses1DataContext dataContext;
        public Patients()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["WPF_Login_MaterialUI.Properties.Settings.pmedicaConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(connectionString);

            //Student Toni = dataContext.Students.First(st => st.Name.Equals("Toni"));

            //var tonisLectures = from sl in Toni.StudentLectures select sl.Lecture;

            //MainDataGrid.ItemsSource = tonisLectures;

            //Patient patients = dataContext.Patients.First(st => st.FirstName == "Piotr");
            //var allPatients = from patient in patients.FirstName select patient;

            var allPatients = from Patient patient in dataContext.Patient select patient;
            
            dataGridPatients.ItemsSource = allPatients;

        }
    }
}
