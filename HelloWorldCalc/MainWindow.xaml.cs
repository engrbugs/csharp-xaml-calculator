using System;
using System.Windows;
using System.Windows.Controls;

namespace HelloWorldCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    

    public partial class MainWindow : Window
    {
        private decimal _memory = 0;
        public decimal Memory
        {
            get => _memory;
            set
            {
                _memory = value;
            }
        }

        private Boolean isdotpressed = false;
        private static Boolean _iserror = false;
        public Boolean iserror
        {
            get => _iserror;
            set
            {
                if (value == true)
                {
                    _iserror = value;
                    //NotifyPropertyChanged("BorderVisible");

                    labelme.Content = "E";
                    //labelme.Visibility = Visibility.Visible;

                }

            }

        }
        

       
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            pressingbuttons(btn.Content.ToString());

        }

        private void pressingbuttons(string content)
        {
            switch (content)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    try
                    {
                        textscreen.Text = decimal.Parse(textscreen.Text.Trim() + content)
                        .ToString("#,###.##") + " ";
                    }
                    catch
                    {
                        iserror = true;
                        //MessageBox.Show(string.Format("_iserror value is {0} {1}", _iserror.ToString(), iserror.ToString()));

                    }
                    break;
                case ".":

                    if (!isdotpressed)
                    {
                        isdotpressed = true;
                        textscreen.Text = textscreen.Text.Trim() + "." + " ";
                    }
                    break;




            }
        }

        private void ButtonClick_memory(object sender, RoutedEventArgs e)
        {

        }



        private void Button_clearall(object sender, RoutedEventArgs e)
        {

        }

    }

}
