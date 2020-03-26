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

namespace Search_Exercise1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] intArray = new int[10];
        double[] doubleArray = new double[10];
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickIntBtn_Click(object sender, RoutedEventArgs e)
        {
            intNumbetTxt.Text = "";
            arrayLbl.Content = "";
            int i = 0;
            for (i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] == 0 && intNumbetTxt.Text == "")
                {
                    intArray[i] = random.Next(100);
                    intNumbetTxt.Text = intArray[i].ToString();
                }
            }

            if (intArray[9] != 0)
            {
                messageLbl.Content = "All array positions were fulfilled " + i;
            }
            else
            {
                messageLbl.Content = "Number " + intNumbetTxt.Text + " added to the list.";
            }
            for (i = 0; i < intArray.Length; i++)
            {
                arrayLbl.Content += intArray[i] + " ";
            }


        }

        private void ClickDoubleBtn_Click(object sender, RoutedEventArgs e)
        {
            arrayDoubleLbl.Content = "";
            doubleNumbetTxt.Text = "";
            int i = 0;
            for (i = 0; i < doubleArray.Length; i++)
            {
                if (doubleArray[i] == 0 && doubleNumbetTxt.Text == "")
                {
                    doubleArray[i] = Math.Round(random.NextDouble(),2);
                    doubleNumbetTxt.Text = doubleArray[i].ToString();
                }

            }
            if (doubleArray[9] != 0)
            {
                messageLbl.Content = "All array positions were fulfilled " + i;
            }
            else
            {
                messageLbl.Content = "Number " + doubleNumbetTxt.Text + " added to the list.";
            }

            for (i = 0; i < doubleArray.Length; i++)
            {
                arrayDoubleLbl.Content += doubleArray[i] + " ";
            }
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            Search(searchTxt.Text);
        }
        private void Search<T>(T number) where T : IComparable<T>
        {
            string arrayNumber;
            int i = 0, j=0;
            bool intFound = false, doubleFound=false;

            for (i = 0; i < intArray.Length; i++)
            {
               arrayNumber = intArray[i].ToString();
               if(arrayNumber.CompareTo(number) == 0)
               { 
                   searchMessagelbl.Content = "The number " + number + " was found in position " + i + " INT ARRAY" ;
                   i = 15;
                   intFound = true;
               }
            }
            if (i != 15)
            {
                for (j = 0; j < doubleArray.Length; j++)
                {
                    arrayNumber = doubleArray[j].ToString();
                    if (arrayNumber.CompareTo(number) == 0)
                    {
                        searchMessagelbl.Content = "The number " + number + " was found in position " + j + " DOUBLE ARRAY";
                        j = 15;
                        doubleFound = true;
                    }
                }
            }

            if (!intFound && !doubleFound)
            {
                searchMessagelbl.Content = "Number not found";
            }

        }
    }
}
