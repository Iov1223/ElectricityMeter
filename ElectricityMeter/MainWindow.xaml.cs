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
        private List<Button> buttonList;
        private List<TextBox> textBoxList;
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
        private TextBlock textBlockEmpty;
        private BrushConverter bc;
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
            buttonList = new List<Button>();
            textBoxList = new List<TextBox>();
            bc = new BrushConverter();
        }

        private void ElectricityMeter_Loaded(object sender, RoutedEventArgs e)
        {
            int num = 0, count = 0;

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
                    else if (j == 3 && i != 0 && i != 13)
                    {
                        buttonResult = new Button();
                        buttonResult.BorderBrush = Brushes.Black;
                        buttonResult.BorderThickness = new Thickness(0.5);
                        buttonResult.FontSize = 17;
                        buttonResult.FontWeight = FontWeights.Bold;
                        buttonResult.Padding = new Thickness(8);
                        buttonResult.Content = "Посчитать";
                        buttonResult.Background = (Brush)bc.ConvertFrom("#FFFC73");
                        buttonResult.HorizontalContentAlignment = HorizontalAlignment.Center;
                        ElectricityMeter.Children.Add(buttonResult);
                        buttonList.Add(buttonResult);
                    }
                    else if (i == 13 && j == 0)
                    {
                        textBlockEmpty = new TextBlock();
                        textBlockEmpty.Text = "";
                        ElectricityMeter.Children.Add(textBlockEmpty);
                    }
                    else if (i == 13 && j == 3)
                    {
                        textBlockTotal = new TextBlock();
                        textBlockTotal.Text = "длывдл";
                        textBlockTotal.FontSize = 17;
                        textBlockTotal.FontWeight = FontWeights.Bold;
                        textBlockTotal.Padding = new Thickness(8);
                        textBlockTotal.Background = (Brush)bc.ConvertFrom("#A967D5");
                        textBlockTotal.Foreground = Brushes.White;
                        textBlockTotal.TextAlignment = TextAlignment.Center;
                        ElectricityMeter.Children.Add(textBlockTotal);
                    }
                    else if (i == 13 && j == 1)
                    {
                        buttonSum = new Button();
                        buttonSum.FontSize = 17;
                        buttonSum.FontWeight = FontWeights.Bold;
                        buttonSum.Content = "Итого";
                        buttonSum.BorderBrush = Brushes.Black;
                        buttonSum.Background = (Brush)bc.ConvertFrom("#6C8AD5");
                        buttonSum.Foreground = Brushes.White;
                        ElectricityMeter.Children.Add(buttonSum);
                    }
                    else
                    {
                        textBoxInputData = new TextBox();
                        textBoxInputData.Text = "0";
                        textBoxInputData.Padding = new Thickness(8);
                        textBoxInputData.TextAlignment = TextAlignment.Center;
                        textBoxInputData.FontSize = 17;
                        textBoxInputData.FontWeight = FontWeights.Bold;
                        textBoxInputData.BorderBrush = Brushes.Black;
                        ElectricityMeter.Children.Add(textBoxInputData);
                        textBoxList.Add(textBoxInputData);
                    }
                }
            }
        }
        private void buttonResult_Clic(object sender, RoutedEventArgs e)
        {
            int count = 0, count2 = 1;
            for (int i = 0; i < buttonList.Count; i++)
            {
                buttonList[i].Content = (Convert.ToInt32(textBoxList[count].Text) + Convert.ToInt32(textBoxList[count2].Text)) * 5.11;
                count += 2;
                count2 += 2;
            }

        }
        private void buttonSum_Clic(object sender, RoutedEventArgs e)
        {
            double sum = 0;
            for (int i = 0; i < buttonList.Count; i++)
            {
                if (buttonList[i].Content != "Посчитать")
                {
                    sum += Convert.ToDouble(buttonList[i].Content);
                }
            }
            textBlockTotal.Text = sum.ToString();
        }
        
        private void ElectricityMeter_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
                MessageBox.Show("Неверный ввод (толко целые числа)!");
            }
        }
    }
}
    

