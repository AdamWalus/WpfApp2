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


namespace WpfApp2
{


    class Triangle
    {
        public double A { get; set; }
        public double B { get; set; } 
        public double C{ get; set; }

        public double CalculateArea()
        {
            double p2 = CalculatePerimeter() / 2;
            return Math.Sqrt(p2*(p2 - A) *(p2-B)*(p2-C));
        }
        public double CalculatePerimeter()
        {
            return A + B + C;
        }

    }


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Triangle triangle = new Triangle();



        public MainWindow()
        {
            InitializeComponent();
            DataContext = triangle;    
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Pole.Content = triangle.CalculateArea();
            Obwod.Content = triangle.CalculatePerimeter();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    double A = double.Parse(ATextBox.Text);
        //    double B = double.Parse(BTextBox.Text);
        //    double C = double.Parse(CTextBox.Text);
        //    double P = (A + B + C) / 2;
        //    double S = P * (P - A) * (P - B) * (P - C);


        //    Obwod.Content = $" {A+B+C}";
        //    Pole.Content = $"{Math.Sqrt(S)}";
        //    //Pole.Content = $"{(A*A*Math.Sqrt(3))/4}";
        //}
    }
}
