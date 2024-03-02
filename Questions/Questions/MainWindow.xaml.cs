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
using static System.Net.Mime.MediaTypeNames;

namespace Questions
{
    
    public partial class MainWindow : Window
    {
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int questNum = 0, i, score;

        public MainWindow()
        {
            InitializeComponent();
            StartGame();
            NextQuestion();
        }


        private void windowMoused(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DoubleAnimation animationOpacity = new DoubleAnimation();
                animationOpacity.Duration = TimeSpan.FromSeconds(30);
                animationOpacity.To = 100;
                QuestionsGrid.BeginAnimation(Grid.OpacityProperty, animationOpacity);
                DragMove();              
            }

        }


        private void btnClose2_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void chkAnswer(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;
            if (senderButton.Tag.ToString() == "1")
            {
                score++;
            }
            if (questNum < 0)
            {
                questNum = 0;
            }
            else
            {
                questNum++;
            }
            scoreText.Content = "Баллы: " + score + "/" + questionNumbers.Count;
            NextQuestion();
        }
        private void RestartGame()
        {
            endGrid.Visibility = Visibility.Visible;
            double solutionMark = 0;
            solutionMark = score / 2;
            mark.Content = Math.Round(solutionMark, 1);

            DoubleAnimation animationOpacity = new DoubleAnimation();
            animationOpacity.Duration = TimeSpan.FromSeconds(30);
            animationOpacity.To = 0;
            QuestionsGrid.BeginAnimation(Grid.OpacityProperty, animationOpacity);
            QuestionsGrid.Visibility = Visibility.Hidden;

            DoubleAnimation animationOpacity2 = new DoubleAnimation();
            animationOpacity2.Duration = TimeSpan.FromSeconds(30);
            animationOpacity2.To = 100;
            endGrid.BeginAnimation(Grid.OpacityProperty, animationOpacity2);
            gridStart.Visibility = Visibility.Hidden;

            scoreText.Content = "Баллы: 0/10";
        }
        private void EndMoused(object sender, MouseEventArgs e)
        {
            score = 0;
            questNum = -1;
            i = 0;

            DoubleAnimation animationOpacity3 = new DoubleAnimation();
            animationOpacity3.Duration = TimeSpan.FromSeconds(30);
            animationOpacity3.From = 100;
            animationOpacity3.To = 0;
            endGrid.BeginAnimation(Grid.OpacityProperty, animationOpacity3);

            DoubleAnimation animationOpacity4 = new DoubleAnimation();
            animationOpacity4.Duration = TimeSpan.FromSeconds(30);
            animationOpacity4.From = 0;
            animationOpacity4.To = 100;
            QuestionsGrid.BeginAnimation(Grid.OpacityProperty, animationOpacity4);
            QuestionsGrid.Visibility = Visibility.Visible;

            StartGame();                     
        }

        private void NextQuestion()
        {
            if (questNum < questionNumbers.Count)
            {
                i = questionNumbers[questNum];
            }
            else
            {
                RestartGame();
            }
            foreach (var x in QuestionsGrid.Children.OfType<Button>())
            {
                x.Tag = "0";
            }
            switch (i)
            {
                case 1:
                    ans1.Content = "Видеокарта"; 
                    ans2.Content = "Процессор";
                    ans3.Content = "Вентилятор";
                    ans4.Content = "Конденсатор памяти";
                    ans1.Tag = "1";  
                    questionImage.Source = new BitmapImage(new Uri("pack://application:,,,/img/1.jpg")); 
                    break;
                case 2:
                    ans1.Content = "Дочерняя плата";
                    ans2.Content = "Материнская плата";
                    ans3.Content = "Микросхема";
                    ans4.Content = "Каркасная плата";
                    ans2.Tag = "1";
                    questionImage.Source = new BitmapImage(new Uri("pack://application:,,,/img/2.jpg"));
                    break;
                case 3:
                    ans1.Content = "Жесткий диск";
                    ans2.Content = "Мягкий диск";
                    ans3.Content = "Диск памяти";
                    ans4.Content = "Записывающее устройство";
                    ans1.Tag = "1";
                    questionImage.Source = new BitmapImage(new Uri("pack://application:,,,/img/3.jpg"));
                    break;
                case 4:
                    ans1.Content = "Энергобокс";
                    ans2.Content = "Блок установки";
                    ans3.Content = "Блок энергозапасов";
                    ans4.Content = "Блок питания";
                    ans4.Tag = "1";
                    questionImage.Source = new BitmapImage(new Uri("pack://application:,,,/img/4.jpg"));
                    break;
                case 5:
                    ans1.Content = "ОЗУ";
                    ans2.Content = "ПЗУ";
                    ans3.Content = "Память";
                    ans4.Content = "Жесткая память";
                    ans1.Tag = "1";
                    questionImage.Source = new BitmapImage(new Uri("pack://application:,,,/img/5.jpg"));
                    break;
                case 6:
                    ans1.Content = "Электросхема";
                    ans2.Content = "Блок памяти";
                    ans3.Content = "Процессор";
                    ans4.Content = "ПЗУ";
                    ans3.Tag = "1";
                    questionImage.Source = new BitmapImage(new Uri("pack://application:,,,/img/6.jpg"));
                    break;
                case 7:
                    ans1.Content = "Звуковая карта";
                    ans2.Content = "Видеокарта";
                    ans3.Content = "Сетевая карта";
                    ans4.Content = "ОЗУ";
                    ans1.Tag = "1";
                    questionImage.Source = new BitmapImage(new Uri("pack://application:,,,/img/7.jpg"));
                    break;
                case 8:
                    ans1.Content = "Видеокарта";
                    ans2.Content = "Сетевая карта";
                    ans3.Content = "Звуковая карта";
                    ans4.Content = "ПЗУ";
                    ans2.Tag = "1";
                    questionImage.Source = new BitmapImage(new Uri("pack://application:,,,/img/8.jpg"));
                    break;
                case 9:
                    ans1.Content = "Твердотельный накопитель";
                    ans2.Content = "Жесткий диск";
                    ans3.Content = "Оперативная память";
                    ans4.Content = "Процессор";
                    ans1.Tag = "1";
                    questionImage.Source = new BitmapImage(new Uri("pack://application:,,,/img/9.jpg"));
                    break;
                case 10:
                    ans1.Content = "Твердотельный накопитель";
                    ans2.Content = "Твердотельный накопитель M.3";
                    ans3.Content = "Жесткий накопитель";
                    ans4.Content = "Твердотельный накопитель M.2";
                    ans4.Tag = "1";
                    questionImage.Source = new BitmapImage(new Uri("pack://application:,,,/img/10.jpg"));
                    break;
            }
        }
        private void StartGame()
        {
            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();
            questionNumbers = randomList;
        }
        
        
    }
}

