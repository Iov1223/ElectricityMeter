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

namespace ElectricityMeter
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ElectricityMeter.Rows = 14;
            ElectricityMeter.Columns = 4;
        }

        private void ElectricityMeter_Loaded(object sender, RoutedEventArgs e)
        {
            int num = 1;

            for (int i = 0; i < ElectricityMeter.Rows; i++)
            {
                for (int j = 0; j < ElectricityMeter.Columns; j++)
                {
                    if (j == 0 && i == 0)
                    {
                        TextBlock textBlockMonth = new TextBlock();
                        textBlockMonth.Text = "Месяц";
                        textBlockMonth.FontSize = 20;
                        textBlockMonth.FontWeight = FontWeights.Bold;
                        textBlockMonth.Padding = new Thickness(8);
                        textBlockMonth.TextAlignment = TextAlignment.Center;
                        ElectricityMeter.Children.Add(textBlockMonth);
                    }
                    else if (i == 0 && j == 1)
                    {
                        TextBlock textBlockNight = new TextBlock();
                        textBlockNight.FontSize = 20;
                        textBlockNight.FontWeight = FontWeights.Bold;
                        textBlockNight.Padding = new Thickness(8);
                        textBlockNight.Text = "Ночь";
                        textBlockNight.TextAlignment = TextAlignment.Center;
                        ElectricityMeter.Children.Add(textBlockNight);
                        
                    }
                    else if (i == 0 && j == 2)
                    {
                        TextBlock textBlockDay = new TextBlock();
                        textBlockDay.FontSize = 20;
                        textBlockDay.FontWeight = FontWeights.Bold;
                        textBlockDay.Padding = new Thickness(8);
                        textBlockDay.Text = "День";
                        textBlockDay.TextAlignment = TextAlignment.Center;
                        ElectricityMeter.Children.Add(textBlockDay);
                        
                    }
                    else if (i == 0 && j == 3)
                    {
                        TextBlock textBlockSum = new TextBlock();
                        textBlockSum.FontSize = 20;
                        textBlockSum.FontWeight = FontWeights.Bold;
                        textBlockSum.Padding = new Thickness(8);
                        textBlockSum.Text = "Сумма";
                        textBlockSum.TextAlignment = TextAlignment.Center;
                        ElectricityMeter.Children.Add(textBlockSum);
                        
                    }
                    else if (j == 0 && i != 0 && i != 13)
                    {
                        TextBlock textBlocNumMonth = new TextBlock();
                        textBlocNumMonth.FontSize = 20;
                        textBlocNumMonth.FontWeight = FontWeights.Bold;
                        textBlocNumMonth.Padding = new Thickness(8);
                        textBlocNumMonth.Text = num.ToString();
                        textBlocNumMonth.TextAlignment = TextAlignment.Center;
                        ElectricityMeter.Children.Add(textBlocNumMonth);
                        num++;
                    }
                    else if (j == 3 && i != 0)
                    {
                        TextBlock tb = new TextBlock();
                        ElectricityMeter.Children.Add(tb);
                    }
                    else if (i == 13 && j== 0)
                    {
                        TextBlock textBlockTotal = new TextBlock();
                        textBlockTotal.FontSize = 20;
                        textBlockTotal.FontWeight = FontWeights.Bold;
                        textBlockTotal.Padding = new Thickness(8);
                        textBlockTotal.Text = "";
                        textBlockTotal.TextAlignment = TextAlignment.Center;
                        ElectricityMeter.Children.Add(textBlockTotal);
                    }
                    else if (i == 13 && j == 1)
                    {
                        Button buttonSum = new Button();
                        buttonSum.Content = "Посчитать";
                        buttonSum.BorderBrush = Brushes.Black;
                        ElectricityMeter.Children.Add(buttonSum);
                    }
                    else 
                    {
                        TextBox textBoxInputData = new TextBox();
                        textBoxInputData.Padding = new Thickness(8);
                        textBoxInputData.TextAlignment = TextAlignment.Center;
                        textBoxInputData.FontSize = 20;
                        textBoxInputData.FontWeight = FontWeights.Bold;
                        textBoxInputData.BorderBrush = Brushes.Black;
                        ElectricityMeter.Children.Add(textBoxInputData);

                    }
                }
            }
        }
    }
}
