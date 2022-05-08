using MaterialDesignThemes.Wpf;
using System.Windows;
using System.Windows.Input;

namespace WPF_Login_MaterialUI
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// 
    /// SQL username
    /// pmedicasql
    /// pmedicasqlusername123!@#
    /// 
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }

        public bool IsDarkTheme { get; set; }
        private readonly PaletteHelper paletteHelper = new PaletteHelper();

        private void exitApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void toggleTheme(object sender, RoutedEventArgs e)
        {
            ITheme theme = paletteHelper.GetTheme();

            if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                IsDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);
            }
            else
            {
                IsDarkTheme = true;
                theme.SetBaseTheme(Theme.Dark);
            }
            paletteHelper.SetTheme(theme);
        }
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void btnWizyty_Click(object sender, RoutedEventArgs e)
        {
            frameMain.Content = new Appointments();
        }

        private void btnPacjncji_Click(object sender, RoutedEventArgs e)
        {
            frameMain.Content = new Patients();
        }

        private void btnLekarze_Click(object sender, RoutedEventArgs e)
        {
            frameMain.Content = new Doctors();
        }
    }



}
