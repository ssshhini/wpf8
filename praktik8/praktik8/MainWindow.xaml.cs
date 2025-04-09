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

namespace Wpf_Math_practice8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TaskComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TaskPanel.Children.Clear();

            switch (TaskComboBox.SelectedIndex)
            {
                case 0:
                    AddTask1Controls();
                    break;
                case 1:
                    AddTask2Controls();
                    break;
                case 2:
                    AddTask3Controls();
                    break;
                case 3:
                    AddTask4Controls();
                    break;
                case 4:
                    AddTask5Controls();
                    break;
                case 5:
                    AddTask6Controls();
                    break;
                case 6:
                    AddTask7Controls();
                    break;
                case 7:
                    AddTask8Controls();
                    break;
                case 8:
                    AddTask9Controls();
                    break;
                case 9:
                    AddTask10Controls();
                    break;
                case 10:
                    AddTask11Controls();
                    break;
                case 11:
                    AddTask12Controls();
                    break;
                case 12:
                    AddTask13Controls();
                    break;
                case 13:
                    AddTask14Controls();
                    break;
                case 14:
                    AddTask15Controls();
                    break;
                case 15:
                    AddTask16Controls();
                    break;
                case 16:
                    AddTask17Controls();
                    break;
                case 17:
                    AddTask18Controls();
                    break;
                case 18:
                    AddTask19Controls();
                    break;
                case 19:
                    AddTask20Controls();
                    break;
                case 20:
                    AddTask21Controls();
                    break;
                case 21:
                    AddTask22Controls();
                    break;
                case 22:
                    AddTask23Controls();
                    break;
                case 23:
                    AddTask24Controls();
                    break;
                case 24:
                    AddTask25Controls();
                    break;
                case 25:
                    AddTask26Controls();
                    break;
                case 26:
                    AddTask27Controls();
                    break;
                case 27:
                    AddTask28Controls();
                    break;
                case 28:
                    AddTask29Controls();
                    break;
                case 29:
                    AddTask30Controls();
                    break;
                default:
                    break;
            }
        }

        private void AddTask1Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите координаты точки (x, y):" });
            var xTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var yTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(xTextBox);
            TaskPanel.Children.Add(yTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Проверить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double x = double.Parse(xTextBox.Text);
                double y = double.Parse(yTextBox.Text);

                if (y <= 2 - Math.Pow(x, 2) && y >= 0)
                {
                    resultLabel.Content = "Точка лежит в области.";
                }
                else
                {
                    resultLabel.Content = "Точка не лежит в области.";
                }
            };
            TaskPanel.Children.Add(button);
        }

        private void AddTask2Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите три числа:" });
            var aTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var bTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var cTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(aTextBox);
            TaskPanel.Children.Add(bTextBox);
            TaskPanel.Children.Add(cTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Найти среднее", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double a = double.Parse(aTextBox.Text);
                double b = double.Parse(bTextBox.Text);
                double c = double.Parse(cTextBox.Text);

                double average = (a + b + c) / 3;
                resultLabel.Content = $"Среднее значение: {average}";
            };
            TaskPanel.Children.Add(button);
        }

        private void AddTask3Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите координаты точки (x, y):" });
            var xTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var yTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(xTextBox);
            TaskPanel.Children.Add(yTextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите радиус окружности (R):" });
            var rTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(rTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Проверить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double x = double.Parse(xTextBox.Text);
                double y = double.Parse(yTextBox.Text);
                double R = double.Parse(rTextBox.Text);

                double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

                if (distance <= R)
                {
                    resultLabel.Content = "Точка лежит внутри окружности.";
                }
                else
                {
                    resultLabel.Content = "Точка лежит вне окружности.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask4Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите стороны треугольника (a, b, c):" });
            var aTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var bTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var cTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(aTextBox);
            TaskPanel.Children.Add(bTextBox);
            TaskPanel.Children.Add(cTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Проверить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double a = double.Parse(aTextBox.Text);
                double b = double.Parse(bTextBox.Text);
                double c = double.Parse(cTextBox.Text);

                if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) ||
                    Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2) ||
                    Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2))
                {
                    resultLabel.Content = "Треугольник является прямоугольным.";
                }
                else
                {
                    resultLabel.Content = "Треугольник не является прямоугольным.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask5Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите номер месяца (1-12):" });
            var monthTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(monthTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Определить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                int month = int.Parse(monthTextBox.Text);

                if (month >= 3 && month <= 5)
                {
                    resultLabel.Content = "Весна.";
                }
                else if (month >= 6 && month <= 8)
                {
                    resultLabel.Content = "Лето.";
                }
                else if (month >= 9 && month <= 11)
                {
                    resultLabel.Content = "Осень.";
                }
                else if (month == 12 || month == 1 || month == 2)
                {
                    resultLabel.Content = "Зима.";
                }
                else
                {
                    resultLabel.Content = "Некорректный номер месяца.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask6Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите три числа (A, B, C):" });
            var aTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var bTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var cTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(aTextBox);
            TaskPanel.Children.Add(bTextBox);
            TaskPanel.Children.Add(cTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Обработать", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double a = double.Parse(aTextBox.Text);
                double b = double.Parse(bTextBox.Text);
                double c = double.Parse(cTextBox.Text);

                if (a + b + c > 0)
                {
                    a *= 2;
                    b *= 2;
                    c *= 2;
                }
                else
                {
                    a = 0;
                    b = 0;
                    c = 0;
                }

                resultLabel.Content = $"Результаты: A={a}, B={b}, C={c}";
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask7Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите координаты точки A (x0, y0):" });
            var x0TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var y0TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(x0TextBox);
            TaskPanel.Children.Add(y0TextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите координаты точки B (x1, y1):" });
            var x1TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var y1TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(x1TextBox);
            TaskPanel.Children.Add(y1TextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Определить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double x0 = double.Parse(x0TextBox.Text);
                double y0 = double.Parse(y0TextBox.Text);
                double x1 = double.Parse(x1TextBox.Text);
                double y1 = double.Parse(y1TextBox.Text);

                double distanceA = Math.Sqrt(Math.Pow(x0, 2) + Math.Pow(y0, 2));
                double distanceB = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));

                if (distanceA < distanceB)
                {
                    resultLabel.Content = "Точка A наименее удалена от начала координат.";
                }
                else if (distanceA > distanceB)
                {
                    resultLabel.Content = "Точка B наименее удалена от начала координат.";
                }
                else
                {
                    resultLabel.Content = "Точки A и B находятся на одинаковом расстоянии от начала координат.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask8Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите стороны треугольника (a, b, c):" });
            var aTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var bTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var cTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(aTextBox);
            TaskPanel.Children.Add(bTextBox);
            TaskPanel.Children.Add(cTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Проверить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double a = double.Parse(aTextBox.Text);
                double b = double.Parse(bTextBox.Text);
                double c = double.Parse(cTextBox.Text);

                if (a == b || a == c || b == c)
                {
                    resultLabel.Content = "Треугольник является равнобедренным.";
                }
                else
                {
                    resultLabel.Content = "Треугольник не является равнобедренным.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask9Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите стоимость минуты у оператора 1 (коп):" });
            var cost1TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(cost1TextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите скидку у оператора 1 (%):" });
            var discount1TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(discount1TextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите стоимость минуты у оператора 2 (коп):" });
            var cost2TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(cost2TextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите скидку у оператора 2 (%):" });
            var discount2TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(discount2TextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите стоимость минуты у оператора 3 (коп):" });
            var cost3TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(cost3TextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите скидку у оператора 3 (%):" });
            var discount3TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(discount3TextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите количество минут в будние дни:" });
            var weekdaysTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(weekdaysTextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите количество минут в выходные дни:" });
            var weekendsTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(weekendsTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Рассчитать", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double cost1 = double.Parse(cost1TextBox.Text);
                double discount1 = double.Parse(discount1TextBox.Text);
                double cost2 = double.Parse(cost2TextBox.Text);
                double discount2 = double.Parse(discount2TextBox.Text);
                double cost3 = double.Parse(cost3TextBox.Text);
                double discount3 = double.Parse(discount3TextBox.Text);
                double weekdays = double.Parse(weekdaysTextBox.Text);
                double weekends = double.Parse(weekendsTextBox.Text);

                double total1 = (weekdays * cost1) + (weekends * cost1 * (1 - discount1 / 100));
                double total2 = (weekdays * cost2) + (weekends * cost2 * (1 - discount2 / 100));
                double total3 = (weekdays * cost3) + (weekends * cost3 * (1 - discount3 / 100));

                resultLabel.Content = $"Стоимость у оператора 1: {total1} коп.\nСтоимость у оператора 2: {total2} коп.\nСтоимость у оператора 3: {total3} коп.";
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask10Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите номер темы (1-3):" });
            var themeTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(themeTextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите вариант (a, b, c):" });
            var variantTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(variantTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Выбрать", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                int theme = int.Parse(themeTextBox.Text);
                string variant = variantTextBox.Text.ToLower();

                if (theme < 1 || theme > 3 || (variant != "a" && variant != "b" && variant != "c"))
                {
                    resultLabel.Content = "Некорректный ввод.";
                    return;
                }

                string[] themes = { "Новогодние", "С Днем Рождения", "С Днем Защитника Отечества" };
                resultLabel.Content = $"{themes[theme - 1]}, вариант {variant}.";
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask11Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите два числа (a, b):" });
            var aTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var bTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(aTextBox);
            TaskPanel.Children.Add(bTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Обработать", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double a = double.Parse(aTextBox.Text);
                double b = double.Parse(bTextBox.Text);

                if ((a < 0 && b > 0) || (a > 0 && b < 0))
                {
                    a = -a;
                    b = -b;
                }
                else
                {
                    a = 0;
                    b = 0;
                }

                resultLabel.Content = $"Результаты: a={a}, b={b}";
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask12Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите три числа (a, b, c):" });
            var aTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var bTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var cTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(aTextBox);
            TaskPanel.Children.Add(bTextBox);
            TaskPanel.Children.Add(cTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Найти наименьшее", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double a = double.Parse(aTextBox.Text);
                double b = double.Parse(bTextBox.Text);
                double c = double.Parse(cTextBox.Text);

                double min = Math.Min(a, Math.Min(b, c));
                resultLabel.Content = $"Наименьшее число: {min}";
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask13Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите три числа (x, y, z):" });
            var xTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var yTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var zTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(xTextBox);
            TaskPanel.Children.Add(yTextBox);
            TaskPanel.Children.Add(zTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Проверить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double x = double.Parse(xTextBox.Text);
                double y = double.Parse(yTextBox.Text);
                double z = double.Parse(zTextBox.Text);

                double average = (x + y + z) / 3;
                string result = "";

                if (Math.Abs(x) > average) result += $"x={x} ";
                if (Math.Abs(y) > average) result += $"y={y} ";
                if (Math.Abs(z) > average) result += $"z={z} ";

                resultLabel.Content = $"Числа по модулю больше среднего: {result}";
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask14Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите координаты точки (x, y):" });
            var xTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var yTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(xTextBox);
            TaskPanel.Children.Add(yTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Проверить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double x = double.Parse(xTextBox.Text);
                double y = double.Parse(yTextBox.Text);

                if (y == Math.Pow(x, 2))
                {
                    resultLabel.Content = "Точка лежит на кривой.";
                }
                else
                {
                    resultLabel.Content = "Точка не лежит на кривой.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask15Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите координаты точки (x, y):" });
            var xTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var yTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(xTextBox);
            TaskPanel.Children.Add(yTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Проверить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double x = double.Parse(xTextBox.Text);
                double y = double.Parse(yTextBox.Text);

                if (x > 0 && y < 0)
                {
                    resultLabel.Content = "Точка лежит в четвертой четверти.";
                }
                else
                {
                    resultLabel.Content = "Точка не лежит в четвертой четверти.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask16Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите стороны треугольника (a, b, c):" });
            var aTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var bTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var cTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(aTextBox);
            TaskPanel.Children.Add(bTextBox);
            TaskPanel.Children.Add(cTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Сравнить площади", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double a = double.Parse(aTextBox.Text);
                double b = double.Parse(bTextBox.Text);
                double c = double.Parse(cTextBox.Text);

                double minSide = Math.Min(a, Math.Min(b, c));
                double triangleArea = CalculateTriangleArea(a, b, c);
                double squareArea = Math.Pow(minSide, 2);

                if (triangleArea > squareArea)
                {
                    resultLabel.Content = "Площадь треугольника больше площади квадрата.";
                }
                else if (triangleArea < squareArea)
                {
                    resultLabel.Content = "Площадь квадрата больше площади треугольника.";
                }
                else
                {
                    resultLabel.Content = "Площади равны.";
                }
            };
            TaskPanel.Children.Add(button);
        }

        private double CalculateTriangleArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        private void AddTask17Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите координаты точки A1 (x1, y1):" });
            var x1TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var y1TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(x1TextBox);
            TaskPanel.Children.Add(y1TextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите координаты точки A2 (x2, y2):" });
            var x2TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var y2TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(x2TextBox);
            TaskPanel.Children.Add(y2TextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите координаты точки A3 (x3, y3):" });
            var x3TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var y3TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(x3TextBox);
            TaskPanel.Children.Add(y3TextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Проверить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double x1 = double.Parse(x1TextBox.Text);
                double y1 = double.Parse(y1TextBox.Text);
                double x2 = double.Parse(x2TextBox.Text);
                double y2 = double.Parse(y2TextBox.Text);
                double x3 = double.Parse(x3TextBox.Text);
                double y3 = double.Parse(y3TextBox.Text);

                bool a1InFirstQuadrant = x1 > 0 && y1 > 0;
                bool a2InFirstQuadrant = x2 > 0 && y2 > 0;
                bool a3InFirstQuadrant = x3 > 0 && y3 > 0;

                resultLabel.Content = $"Точка A1 в первой четверти: {a1InFirstQuadrant}\nТочка A2 в первой четверти: {a2InFirstQuadrant}\nТочка A3 в первой четверти: {a3InFirstQuadrant}";
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask18Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите координаты точки (x, y):" });
            var xTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var yTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(xTextBox);
            TaskPanel.Children.Add(yTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Проверить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double x = double.Parse(xTextBox.Text);
                double y = double.Parse(yTextBox.Text);

                if (y == Math.Pow(x, 2))
                {
                    resultLabel.Content = "Точка лежит на кривой.";
                }
                else
                {
                    resultLabel.Content = "Точка не лежит на кривой.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask19Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите широту (φ):" });
            var latitudeTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(latitudeTextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите долготу (λ):" });
            var longitudeTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(longitudeTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Определить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double latitude = double.Parse(latitudeTextBox.Text);
                double longitude = double.Parse(longitudeTextBox.Text);

                string hemisphereLatitude = latitude >= 0 ? "северное" : "южное";
                string hemisphereLongitude = longitude >= 0 ? "восточное" : "западное";

                resultLabel.Content = $"Точка находится в {hemisphereLatitude} полушарии и {hemisphereLongitude} полушарии.";
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask20Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите стороны треугольника (a, b, c):" });
            var aTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var bTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var cTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(aTextBox);
            TaskPanel.Children.Add(bTextBox);
            TaskPanel.Children.Add(cTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Определить вид", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double a = double.Parse(aTextBox.Text);
                double b = double.Parse(bTextBox.Text);
                double c = double.Parse(cTextBox.Text);

                if (a == b && b == c)
                {
                    resultLabel.Content = "Треугольник равносторонний.";
                }
                else if (a == b || a == c || b == c)
                {
                    resultLabel.Content = "Треугольник равнобедренный.";
                }
                else if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) ||
                         Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2) ||
                         Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2))
                {
                    resultLabel.Content = "Треугольник прямоугольный.";
                }
                else
                {
                    resultLabel.Content = "Треугольник простой.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask21Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите два числа (A, B):" });
            var aTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var bTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(aTextBox);
            TaskPanel.Children.Add(bTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Обработать", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double a = double.Parse(aTextBox.Text);
                double b = double.Parse(bTextBox.Text);

                if ((a < 0 && b > 0) || (a > 0 && b < 0))
                {
                    a = -a;
                    b = -b;
                }
                else
                {
                    a = 0;
                    b = 0;
                }

                resultLabel.Content = $"Результаты: A={a}, B={b}";
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask22Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите три числа (a, b, c):" });
            var aTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var bTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var cTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(aTextBox);
            TaskPanel.Children.Add(bTextBox);
            TaskPanel.Children.Add(cTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Найти наименьшее", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double a = double.Parse(aTextBox.Text);
                double b = double.Parse(bTextBox.Text);
                double c = double.Parse(cTextBox.Text);

                double min = Math.Min(a, Math.Min(b, c));
                resultLabel.Content = $"Наименьшее число: {min}";
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask23Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите три числа (a, e, c):" });
            var aTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var eTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var cTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(aTextBox);
            TaskPanel.Children.Add(eTextBox);
            TaskPanel.Children.Add(cTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Сравнить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                int a = int.Parse(aTextBox.Text);
                int b = int.Parse(eTextBox.Text);
                int c = int.Parse(cTextBox.Text);
                int binaryNumber = Convert.ToInt32("1101011", 2);

                string result = "";
                if (a > binaryNumber) result += $"a={a} ";
                if (b > binaryNumber) result += $"e={b} ";
                if (c > binaryNumber) result += $"c={c} ";

                resultLabel.Content = $"Числа больше двоичного числа 1101011: {result}";
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask24Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите три числа в восьмеричной системе (a, e, c):" });
            var aTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var eTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var cTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(aTextBox);
            TaskPanel.Children.Add(eTextBox);
            TaskPanel.Children.Add(cTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Найти наибольшее", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                int a = Convert.ToInt32(aTextBox.Text, 8);
                int b = Convert.ToInt32(eTextBox.Text, 8);
                int c = Convert.ToInt32(cTextBox.Text, 8);

                int max = Math.Max(a, Math.Max(b, c));
                resultLabel.Content = $"Наибольшее число: {max}";
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask25Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите три числа в шестнадцатеричной системе (a, e, c):" });
            var aTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var eTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var cTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(aTextBox);
            TaskPanel.Children.Add(eTextBox);
            TaskPanel.Children.Add(cTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Найти наименьшее", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                int a = Convert.ToInt32(aTextBox.Text, 16);
                int b = Convert.ToInt32(eTextBox.Text, 16);
                int c = Convert.ToInt32(cTextBox.Text, 16);

                int min = Math.Min(a, Math.Min(b, c));
                resultLabel.Content = $"Наименьшее число: {min}";
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask26Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите два числа (a, b):" });
            var aTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var bTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(aTextBox);
            TaskPanel.Children.Add(bTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Вычислить сумму цифр", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                int a = int.Parse(aTextBox.Text);
                int b = int.Parse(bTextBox.Text);

                int sumA = SumOfDigits(a);
                int sumB = SumOfDigits(b);

                resultLabel.Content = $"Сумма цифр числа a: {sumA}\nСумма цифр числа b: {sumB}";
            };
            TaskPanel.Children.Add(button);
        }

        private int SumOfDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        private void AddTask27Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите два числа (a, b):" });
            var aTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var bTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(aTextBox);
            TaskPanel.Children.Add(bTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Вычислить произведение цифр", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                int a = int.Parse(aTextBox.Text);
                int b = int.Parse(bTextBox.Text);

                int productA = ProductOfDigits(a);
                int productB = ProductOfDigits(b);

                resultLabel.Content = $"Произведение цифр числа a: {productA}\nПроизведение цифр числа b: {productB}";
            };
            TaskPanel.Children.Add(button);
        }

        private int ProductOfDigits(int number)
        {
            int product = 1;
            while (number != 0)
            {
                product *= number % 10;
                number /= 10;
            }
            return product;
        }
        private void AddTask28Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите три сопротивления (R1, R2, R3):" });
            var r1TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var r2TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var r3TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(r1TextBox);
            TaskPanel.Children.Add(r2TextBox);
            TaskPanel.Children.Add(r3TextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Вычислить сопротивление", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double r1 = double.Parse(r1TextBox.Text);
                double r2 = double.Parse(r2TextBox.Text);
                double r3 = double.Parse(r3TextBox.Text);

                double seriesResistance = r1 + r2 + r3;
                double parallelResistance = 1 / (1 / r1 + 1 / r2 + 1 / r3);

                resultLabel.Content = $"Сопротивление при последовательном подключении: {seriesResistance}\nСопротивление при параллельном подключении: {parallelResistance}";
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask29Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите сопротивление реостата (Ом):" });
            var rTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(rTextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите ток (А):" });
            var iTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(iTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Проверить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double r = double.Parse(rTextBox.Text);
                double i = double.Parse(iTextBox.Text);

                double requiredResistance = (45 - 30) / i;

                if (r == requiredResistance)
                {
                    resultLabel.Content = "Реостат подходит.";
                }
                else
                {
                    resultLabel.Content = "Реостат не подходит.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask30Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите сопротивления R1, R2, R3:" });
            var r1TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var r2TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var r3TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(r1TextBox);
            TaskPanel.Children.Add(r2TextBox);
            TaskPanel.Children.Add(r3TextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Проверить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double r1 = double.Parse(r1TextBox.Text);
                double r2 = double.Parse(r2TextBox.Text);
                double r3 = double.Parse(r3TextBox.Text);

                if (r1 == 6 || r2 == 6 || r3 == 6)
                {
                    resultLabel.Content = "Можно получить с помощью резисторов 6 кОм.";
                }
                else
                {
                    resultLabel.Content = "Нельзя получить с помощью резисторов 6 кОм.";
                }
            };
            TaskPanel.Children.Add(button);
        }
    }
}