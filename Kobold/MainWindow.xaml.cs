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

namespace Kobold
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string UserInput;
        string CurrentNext;
        public MainWindow()
        {
            InitializeComponent();
            HelloKOBold();
        }

        public void HelloKOBold()
        {
            xTextAdventureOutput.Text = "Greetings, my name is Kind Operating Bot. You may also Call me KOBold. This of course has to do with my dungeon RPG style text game. Please Use these Key words to begin. Start: to start an adventure, Kill: to end this program, Josh: for the funky magic that I can create.";
        }

        private void xSubmit_Click(object sender, RoutedEventArgs e)
        {
            UserInput = xTextAdventureUserImput.Text.ToLower();
            NewCallAll();
        }

        public void NewCallAll()
        {
            if (UserInput == "start")
            {
                MakingAPTA();
            }
        }

        public void MakingAPTA()
        {
            xTextAdventureOutput.Text = "Alright So Im going to generate you a new text adventure with 2 events in that adventure. For now it may be a little buggy";
            CurrentNext = "This is the next thing to write";
        }

        private void xNext_Click(object sender, RoutedEventArgs e)
        {
            xTextAdventureOutput.Text = CurrentNext;
        }
    }
}
