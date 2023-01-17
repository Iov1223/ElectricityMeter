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
        private string[] monthArr;
        private Label labelMonth;
        private Label labelNight;
        private Label labelDay;
        private Label labelSum;
        private Label labelMonthName;
        private Button buttonResult;
        private TextBlock textBlockTotal;
        private Button buttonSum;
        private TextBox textBoxInputData;
        public MainWindow()
        {
            InitializeComponent();
            ElectricityMeter.Rows = 14;
            ElectricityMeter.Columns = 4;
            monthArr = new string[]
            {
                "Январь", "Февраль", "Март",
                "Апрель", "Май", "Июнь",
                "Июль", "Август", "Сентябрь",
                "Октябрь", "Ноябрь", "Декабрь"
            };
        }

        private void ElectricityMeter_Loaded(object sender, RoutedEventArgs e)
        {
            int num = 0;

            for (int i = 0; i < ElectricityMeter.Rows; i++)
            {
                for (int j = 0; j < ElectricityMeter.Columns; j++)
                {
                    if (j == 0 && i == 0)
                    {
                        labelMonth = new Label();
                        labelMonth.Content = "Месяц";
                        labelMonth.FontSize = 17;
                        labelMonth.FontWeight = FontWeights.Bold;
                        labelMonth.Padding = new Thickness(8);
                        labelMonth.BorderBrush = Brushes.Black;
                        labelMonth.BorderThickness = new Thickness(0.5);
                        labelMonth.HorizontalContentAlignment = HorizontalAlignment.Center;
                        ElectricityMeter.Children.Add(labelMonth);
                    }
                    else if (i == 0 && j == 1)
                    {
                        labelNight = new Label();
                        labelNight.FontSize = 17;
                        labelNight.FontWeight = FontWeights.Bold;
                        labelNight.Padding = new Thickness(8);
                        labelNight.Content = "Ночь (Кол-во в кВт.ч)";
                        labelNight.BorderBrush = Brushes.Black;
                        labelNight.BorderThickness = new Thickness(0.5);
                        labelNight.HorizontalContentAlignment = HorizontalAlignment.Center;
                        ElectricityMeter.Children.Add(labelNight);
                        
                    }
                    else if (i == 0 && j == 2)
                    {
                        labelDay = new Label();
                        labelDay.FontSize = 17;
                        labelDay.FontWeight = FontWeights.Bold;
                        labelDay.Padding = new Thickness(8);
                        labelDay.Content = "День (Кол-во в кВт.ч)";
                        labelDay.BorderBrush = Brushes.Black;
                        labelDay.BorderThickness = new Thickness(0.5);
                        labelDay.HorizontalContentAlignment = HorizontalAlignment.Center;
                        ElectricityMeter.Children.Add(labelDay);
                        
                    }
                    else if (i == 0 && j == 3)
                    {
                        labelSum = new Label();
                        labelSum.FontSize = 17;
                        labelSum.FontWeight = FontWeights.Bold;
                        labelSum.Padding = new Thickness(8);
                        labelSum.Content = "Сумма в рублях";
                        labelSum.BorderBrush = Brushes.Black;
                        labelSum.BorderThickness = new Thickness(0.5);
                        labelSum.HorizontalContentAlignment = HorizontalAlignment.Center;
                        ElectricityMeter.Children.Add(labelSum);
                    }
                    else if (j == 0 && i != 0 && i != 13)
                    {
                        labelMonthName = new Label();
                        labelMonthName.FontSize = 17;
                        labelMonthName.FontWeight = FontWeights.Bold;
                        labelMonthName.Padding = new Thickness(8);
                        labelMonthName.Content = monthArr[num];
                        labelMonthName.BorderBrush = Brushes.Black;
                        labelMonthName.BorderThickness = new Thickness(0.5);
                        labelMonthName.HorizontalContentAlignment = HorizontalAlignment.Center;
                        ElectricityMeter.Children.Add(labelMonthName);
                        num++;
                    }
                    else if (j == 3 && i != 0)
                    {
                        buttonResult = new Button();
                        buttonResult.BorderBrush = Brushes.Black;
                        buttonResult.BorderThickness = new Thickness(0.5);
                        buttonResult.FontSize = 17;
                        buttonResult.FontWeight = FontWeights.Bold;
                        buttonResult.Padding = new Thickness(8);
                        buttonResult.Content = "Посчитать";
                        buttonResult.HorizontalContentAlignment = HorizontalAlignment.Center;
                        ElectricityMeter.Children.Add(buttonResult);
                    }
                    else if (i == 13 && j== 0)
                    {
                        textBlockTotal = new TextBlock();
                        textBlockTotal.Text = "";
                        ElectricityMeter.Children.Add(textBlockTotal);
                    }
                    else if (i == 13 && j == 1)
                    {
                        buttonSum = new Button();
                        buttonSum.FontSize = 17;
                        buttonSum.FontWeight = FontWeights.Bold;
                        buttonSum.Content = "Итого";
                        buttonSum.BorderBrush = Brushes.Black;
                        buttonSum.Background = Brushes.DodgerBlue;
                        buttonSum.Foreground = Brushes.White;  
                        ElectricityMeter.Children.Add(buttonSum);
                    }
                    else 
                    {
                        textBoxInputData = new TextBox();
                        textBoxInputData.Text = "2";
                        textBoxInputData.Padding = new Thickness(8);
                        textBoxInputData.TextAlignment = TextAlignment.Center;
                        textBoxInputData.FontSize = 17;
                        textBoxInputData.FontWeight = FontWeights.Bold;
                        textBoxInputData.BorderBrush = Brushes.Black;
                        ElectricityMeter.Children.Add(textBoxInputData);
                    }
                }
            }
        }
        private void buttonResult_Clic(object sender, RoutedEventArgs e)
        {
            if (textBoxInputData.Text != null)
            {
                buttonResult.Content = Convert.ToInt32(textBoxInputData.Text) + Convert.ToInt32(textBoxInputData.Text);
            }
            else
            {
                MessageBox.Show("Ничего нет");
            }
        }
    }
}
