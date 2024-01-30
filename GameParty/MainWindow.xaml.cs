using System;
using System.Collections.Generic;
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

namespace GameParty
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Deklaracja pola do przechowywania aktualnie otwartej strony
        private Jaka_To_Melodia currentJaka_To_MelodiaPage;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (currentJaka_To_MelodiaPage == null || !IsPageOpen(currentJaka_To_MelodiaPage))
            {
                // Jeśli nie, utwórz nową instancję strony Jaka_To_Melodia
                currentJaka_To_MelodiaPage = new Jaka_To_Melodia();

                // Ustaw zawartość w głównej kontrolce (np. Frame)
                Main.Content = currentJaka_To_MelodiaPage;
            }



        }

        // Metoda sprawdzająca, czy dana strona jest otwarta
        private bool IsPageOpen(Page page)
        {
            // Przeszukaj wszystkie kontrolki Frame w oknie głównym
            foreach (var frame in FindVisualChildren<Frame>(Application.Current.MainWindow))
            {
                // Sprawdź, czy strona jest zawarta w danym kontrolerze Frame
                if (frame.Content == page)
                {
                    return true;
                }
            }
            return false;
        }

        // Metoda pomocnicza do znajdowania kontrolki Frame w oknie głównym
        private IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }

        private void Main_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
