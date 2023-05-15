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

namespace TicTacToe__self_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int spieler = 1;
        private int ZügeX = 0;
        private int ZügeO = 0;
        public List<Button> allGameButtons;


#pragma warning disable CS8618 // Deaktiviere Warung
        public MainWindow()
        {
            InitializeComponent();


            
        }

        private void Play_Clicked(object sender, RoutedEventArgs e)
        {


            
            if (PlayButton.IsEnabled == true)
            {        
                allGameButtons = new List<Button>() { Game_Button, Game_Button_Copy, Game_Button_Copy1, Game_Button_Copy2, Game_Button_Copy3, Game_Button_Copy4, Game_Button_Copy5, Game_Button_Copy6, Game_Button_Copy7 };
               
                PlayButton.IsEnabled = false;
                PlayButton.Visibility = Visibility.Hidden;

                foreach (Button button in allGameButtons) {
                    button.Visibility = Visibility.Visible;
                    button.IsEnabled = true;
                }
                RestartButton.Visibility = Visibility.Visible;
                RestartButton.IsEnabled = true;

                ZugX.Visibility = Visibility.Visible;
                ZugX.IsEnabled = true;

                ZugO.Visibility = Visibility.Visible;
                ZugO.IsEnabled = true;

                PlayerText.Visibility = Visibility.Visible;
                PlayerText.IsEnabled = true;
                PlayerText.Text = "Spieler: O";
            }
        }

        private void GameButton_Clicked(object sender, RoutedEventArgs e)
        {
            Button GameButton = (Button)sender;
            if (GameButton.Content.ToString() == "")
            {
                if (spieler == 1)
                {
                    GameButton.Content = "O";
                    ZügeO += 1;
                    ZugOZahl.Text = ZügeO.ToString();
                    PlayerText.Text = "Spieler: X";
                    spieler = 2;
                }else
                {
                    GameButton.Content = "X";
                    ZügeX += 1;
                    ZugXZahl.Text = ZügeX.ToString();
                    PlayerText.Text = "Spieler: O";
                    spieler = 1;
                }
            }

            if (Game_Button.Content.ToString() == "X" && Game_Button_Copy.Content.ToString() == "X" && Game_Button_Copy1.Content.ToString() == "X")
            {
                WinText.Visibility = Visibility.Visible;
                RestartButton.Visibility = Visibility.Hidden;
                WinText.IsEnabled = true;
                WinText.Text = "X Wins!";
                PlayerText.Visibility = Visibility.Hidden;
                PlayerText.IsEnabled = false;
                RestartGameButton.Visibility = Visibility.Visible;
                RestartGameButton.IsEnabled = true;
                ZugO.Visibility = Visibility.Hidden;
                ZugOZahl.Visibility = Visibility.Hidden;
                ZugX.Visibility = Visibility.Hidden;
                ZugXZahl.Visibility = Visibility.Hidden;

                foreach (Button button in allGameButtons)
                {
                    button.Visibility = Visibility.Hidden;
                    button.IsEnabled = false;
                }
            }

        }

        private void Restart_Clicked(object sender, RoutedEventArgs e)
        {
            RestartGameButton.Visibility = Visibility.Hidden;
            RestartGameButton.IsEnabled = false;
            WinText.Visibility = Visibility.Hidden;
            WinText.IsEnabled = false;

            foreach (Button button in allGameButtons) {
                button.Content = "";    
            }
            ZügeO = 0;
            ZügeX = 0;
            ZugOZahl.Text = "";
            ZugXZahl.Text = "";
        }
    }
}
