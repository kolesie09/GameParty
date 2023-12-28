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
    /// Logika interakcji dla klasy Jaka_To_Melodia.xaml
    /// </summary>
    public partial class Jaka_To_Melodia : Page
    {
        public Jaka_To_Melodia()
        {
            InitializeComponent();
        }

        public string ChooseMusicType { get; set; }


        private void click_1(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            ChooseMusic(button.Content as string);
        }

        private void click_2(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            ChooseMusic(button.Content as string);
        }

        private void click_3(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            ChooseMusic(button.Content as string);
        }

        private void click_4(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            ChooseMusic(button.Content as string);
        }

        void ChooseMusic(string NameButton)
        {
            if(NameButton == "Zagraniczne" | NameButton == "Dziecięce" | NameButton == "Disco Polo" | NameButton == "POP" | NameButton == "HIP HOP i RAP" | NameButton == "KLASYKA")
            {
                ChooseMusicType = NameButton;
                HowManyAnswers(3);
                btn1.Content = "EASY";
                btn2.Content = "MEDIUM";
                btn3.Content = "HIGH";
            }
            
            if(NameButton == "Polskie")
            {
                HowManyAnswers(3);
                btn1.Content = "Dziecięce";
                btn2.Content = "Normalne";
                btn3.Content = "Youtubersi";
            }

            if(NameButton == "Normalne")
            {
                HowManyAnswers(4);
                btn1.Content = "Disco Polo";
                btn2.Content = "POP";
                btn3.Content = "HIP HOP i RAP";
                btn4.Content = "KLASYKA";
            }

            if (NameButton == "EASY")
            {
                info.Text = "Wybrano " + ChooseMusicType + " poziom " + NameButton;
            }
            if (NameButton == "MEDIUM")
            {
                info.Text = "Wybrano " + ChooseMusicType + " poziom " + NameButton;
            }
            if (NameButton == "HARD")
            {
                info.Text = "Wybrano " + ChooseMusicType + " poziom " + NameButton;
            }

        }

        void HowManyAnswers(int HowMany)
        {
            btn1.Visibility = Visibility.Visible;
            btn2.Visibility = Visibility.Visible;
            btn3.Visibility = Visibility.Hidden;
            btn4.Visibility = Visibility.Hidden;
            if (HowMany == 2)
            {
                btn1.Margin = new Thickness(-200, 0, 0, 0);
                btn2.Margin = new Thickness(200,0,0,0);
            }
            else if(HowMany == 3)
            {
                btn1.Margin = new Thickness(-400, 0, 0, 0);
                btn2.Margin = new Thickness(0, 0, 0, 0);
                btn3.Visibility = Visibility.Visible;
                btn3.Margin = new Thickness(400, 0, 0, 0);
                
            }
            else
            {
                btn1.Margin = new Thickness(-600, 0, 0, 0);
                btn2.Margin = new Thickness(-200, 0, 0, 0);
                btn3.Visibility = Visibility.Visible;
                btn3.Margin = new Thickness(200, 0, 0, 0);
                btn4.Visibility = Visibility.Visible;
                btn4.Margin = new Thickness(600, 0, 0, 0);
            }
        }
    }
}
