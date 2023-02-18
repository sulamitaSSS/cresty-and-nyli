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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace КрестикиНолики
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Button> Buttons = new List<Button>();
        public string Player;
        public string Robot;
        public MainWindow()
        {
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (Button1.Content == null)
            {
                Button1.IsEnabled = false;
                Button1.Content = Player;
                Win();
                Robot_Click();
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (Button2.Content == null)
            {
                Button2.IsEnabled = false;
                Button2.Content = Player;
            }
            Win();
            Robot_Click();
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (Button3.Content == null)
            {
                Button3.IsEnabled = false;
                Button3.Content = Player;
            }
            Win();
            Robot_Click();
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (Button4.Content == null)
            {
                Button4.IsEnabled = false;
                Button4.Content = Player;
            }
            Win();
            Robot_Click();
        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (Button5.Content == null)
            {
                Button5.IsEnabled = false;
                Button5.Content = Player;
            }
            Win();
            Robot_Click();
        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (Button6.Content == null)
            {
                Button6.IsEnabled = false;
                Button6.Content = Player;
            }
            Win();
            Robot_Click();
        }
        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (Button7.Content == null)
            {
                Button7.IsEnabled = false;
                Button7.Content = Player;
            }
            Win();
            Robot_Click();
        }
        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (Button8.Content == null)
            {
                Button8.IsEnabled = false;
                Button8.Content = Player;
            }
            Win();
            Robot_Click();
        }
        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if (Button9.Content == null)
            {
                Button9.IsEnabled = false;
                Button9.Content = Player;
            }
            Win();
            Robot_Click();
        }
        private void ButtonStart_Click_1(object sender, RoutedEventArgs e)
        {
            ButtonStart.Content = "Давай сразимся воин";
            Buttons.Add(Button1);
            Buttons.Add(Button2);
            Buttons.Add(Button3);
            Buttons.Add(Button4);
            Buttons.Add(Button5);
            Buttons.Add(Button6);
            Buttons.Add(Button7);
            Buttons.Add(Button8);
            Buttons.Add(Button9);
            foreach (var button in Buttons)
            {
                button.Content = null;
                button.IsEnabled = true;
            }
            Button0.IsEnabled = true;
            ButtonX.IsEnabled = true;
            ButtonStart.IsEnabled = false;
        }
        private void ButtonX_Click(object sender, RoutedEventArgs e)
        {
            ButtonX.IsEnabled = false;
            Button0.IsEnabled = false;
            Player = "X";
            Robot = "O";
        }
        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            Button0.IsEnabled = false;
            ButtonX.IsEnabled = false;
            Button0.Content = "0";
            Player = "O";
            Robot = "X";
        }
        private void Robot_Click()
        {
            Random random = new Random();
            int step = random.Next(1, 9);
            bool xod = true;
            while (xod)
            {
                switch (step)
                {
                    case 1:
                        if (Button1.Content == null)
                        {
                            Button1.Content = Robot;
                            Button1.IsEnabled = false;
                            Win();
                            xod = false;
                        }
                        else
                        {
                            Robot_Click();
                            Win();
                            xod = false;
                        }
                        break;
                    case 2:
                        if (Button2.Content == null)
                        {
                            Button2.Content = Robot;
                            Button2.IsEnabled = false;
                            Win();
                            xod = false;
                        }
                        else
                        {
                            Robot_Click();
                            Win();
                            xod = false;
                        }
                        break;
                    case 3:
                        if (Button3.Content == null)
                        {
                            Button3.Content = Robot;
                            Button3.IsEnabled = false;
                            Win();
                            xod = false;
                        }
                        else
                        {
                            Robot_Click();
                            Win();
                            xod = false;
                        }
                        break;
                    case 4:
                        if (Button4.Content == null)
                        {
                            Button4.Content = Robot;
                            Button4.IsEnabled = false;
                            Win();
                            xod = false;
                        }
                        else
                        {
                            Robot_Click();
                            Win();
                            xod = false;
                        }
                        break;
                    case 5:
                        if (Button5.Content == null)
                        {
                            Button5.Content = Robot;
                            Button5.IsEnabled = false;
                            Win();
                            xod = false;
                        }
                        else
                        {
                            Robot_Click();
                            Win();
                            xod = false;
                        }
                        break;
                    case 6:
                        if (Button6.Content == null)
                        {
                            Button6.Content = Robot;
                            Button6.IsEnabled = false;
                            Win();
                            xod = false;
                        }
                        else
                        {
                            Robot_Click();
                            Win();
                            xod = false;
                        }
                        break;
                    case 7:
                        if (Button7.Content == null)
                        {
                            Button7.Content = Robot;
                            Button7.IsEnabled = false;
                            Win();
                            xod = false;
                        }
                        else
                        {
                            Robot_Click();
                            Win();
                            xod = false;
                        }
                        break;
                    case 8:
                        if (Button8.Content == null)
                        {
                            Button8.Content = Robot;
                            Button8.IsEnabled = false;
                            Win();
                            xod = false;
                        }
                        else
                        {
                            Robot_Click();
                            Win();
                            xod = false;
                        }
                        break;
                    case 9:
                        if (Button9.Content == null)
                        {
                            Button9.Content = Robot;
                            Button9.IsEnabled = false;
                            Win();
                            xod = false;
                        }
                        else
                        {
                            Robot_Click();
                            Win();
                            xod = false;
                        }
                        break;
                }
            }
        }
        private void Win()
        {
            if (Button1.Content != null && Button2.Content != null && Button3.Content != null && Button4.Content != null && Button5.Content != null && Button7.Content != null && Button8.Content != null && Button9.Content != null)
            {
                if (Button1.Content != null)
                {
                    win.Content = "Я хороший воин, но и ты не промах. Начнем заново!!";
                    foreach (var button in Buttons)
                    {
                        button.IsEnabled = false;
                    }
                    ButtonStart.IsEnabled = true;
                }
            }
            else {
               if (Button1.Content == Button2.Content && Button2.Content == Button3.Content)
                {
                    if (Button1.Content != null)
                    {
                        if (Button1.Content == "O")
                        {
                            win.Content = "Winner: O";
                            foreach (var button in Buttons)
                            {
                                button.Content = null;
                                button.IsEnabled = false;
                            }
                            ButtonStart.IsEnabled = true;
                        }
                        else if (Button1.Content == "X")
                        {
                            win.Content = "Winner: X";
                            foreach (var button in Buttons)
                            {
                                button.Content = null;
                                button.IsEnabled = false;
                            }
                            ButtonStart.IsEnabled = true;
                        }
                    }
                }
                else if (Button4.Content == Button5.Content && Button6.Content == Button4.Content)
                {
                    if (Button4.Content != null)
                    {
                        if (Button4.Content == "O")
                        {
                            win.Content = "Winner: O";
                            foreach (var button in Buttons)
                            {
                                button.Content = null;
                                button.IsEnabled = false;
                            }
                            ButtonStart.IsEnabled = true;
                        }
                        else if (Button4.Content == "X")
                        {
                            win.Content = "Winner: X";
                            foreach (var button in Buttons)
                            {
                                button.Content = null;
                                button.IsEnabled = false;
                            }
                            ButtonStart.IsEnabled = true;
                        }
                    }
                }
                else if (Button7.Content == Button8.Content && Button8.Content == Button9.Content)
                {
                    if (Button7.Content != null)
                    {
                        if (Button7.Content == "O")
                        {
                            win.Content = "Winner: O";
                            foreach (var button in Buttons)
                            {
                                button.Content = null;
                                button.IsEnabled = false;
                            }
                            ButtonStart.IsEnabled = true;
                        }
                        else if (Button7.Content == "X")
                        {
                            win.Content = "Winner: X";
                            foreach (var button in Buttons)
                            {
                                button.Content = null;
                                button.IsEnabled = false;
                            }
                            ButtonStart.IsEnabled = true;
                        }
                    }
                }
                else if (Button1.Content == Button5.Content && Button5.Content == Button9.Content)
                {
                    if (Button1.Content != null)
                    {
                        if (Button1.Content == "O")
                        {
                            win.Content = "Winner: O";
                            foreach (var button in Buttons)
                            {
                                button.Content = null;
                                button.IsEnabled = false;
                            }
                            ButtonStart.IsEnabled = true;
                        }
                        else if (Button1.Content == "X")
                        {
                            win.Content = "Winner: X";
                            foreach (var button in Buttons)
                            {
                                button.Content = null;
                                button.IsEnabled = false;
                            }
                            ButtonStart.IsEnabled = true;
                        }
                    }
                }
                else if (Button3.Content == Button5.Content && Button5.Content == Button7.Content)
                {
                    if (Button3.Content != null)
                    {
                        if (Button3.Content == "O")
                        {
                            win.Content = "Winner: O";
                            foreach (var button in Buttons)
                            {
                                button.Content = null;
                                button.IsEnabled = false;
                            }
                            ButtonStart.IsEnabled = true;
                        }
                        else if (Button3.Content == "X")
                        {
                            win.Content = "Winner: X";
                            foreach (var button in Buttons)
                            {
                                button.Content = null;
                                button.IsEnabled = false;
                            }
                            ButtonStart.IsEnabled = true;
                        }
                    }
                }
                else if (Button1.Content == Button4.Content && Button4.Content == Button6.Content)
                {
                    if (Button1.Content != null)
                    {
                        if (Button1.Content == "O")
                        {
                            win.Content = "Winner: O";
                            foreach (var button in Buttons)
                            {
                                button.Content = null;
                                button.IsEnabled = false;
                            }
                            ButtonStart.IsEnabled = true;
                        }
                        else if (Button1.Content == "X")
                        {
                            win.Content = "Winner: X";
                            foreach (var button in Buttons)
                            {
                                button.Content = null;
                                button.IsEnabled = false;
                            }
                            ButtonStart.IsEnabled = true;
                        }
                    }
                }
                else if (Button2.Content == Button5.Content && Button5.Content == Button8.Content)
                {
                    if (Button2.Content != null)
                    {
                        if (Button2.Content == "O")
                        {
                            win.Content = "Winner: O";
                            foreach (var button in Buttons)
                            {
                                button.Content = null;
                                button.IsEnabled = false;
                            }
                            ButtonStart.IsEnabled = true;
                        }
                        else if (Button2.Content == "X")
                        {
                            win.Content = "Winner: X";
                            foreach (var button in Buttons)
                            {
                                button.Content = null;
                                button.IsEnabled = false;
                            }
                            ButtonStart.IsEnabled = true;
                        }
                    }
                }
                else if (Button3.Content == Button6.Content && Button6.Content == Button9.Content)
                {
                    if (Button3.Content != null)
                    {
                        if (Button3.Content == "O")
                        {
                            win.Content = "Winner: O";
                            foreach (var button in Buttons)
                            {
                                button.Content = null;
                                button.IsEnabled = false;
                            }
                            ButtonStart.IsEnabled = true;
                        }
                        else if (Button3.Content == "X")
                        {
                            win.Content = "Winner: X";
                            foreach (var button in Buttons)
                            {
                                button.Content = null;
                                button.IsEnabled = false;
                            }
                            ButtonStart.IsEnabled = true;
                        }
                    }
                }
            }
        }
    }
}

