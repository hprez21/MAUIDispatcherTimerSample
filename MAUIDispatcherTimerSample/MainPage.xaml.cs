namespace MAUIDispatcherTimerSample;

public partial class MainPage : ContentPage
{
     IDispatcherTimer timer;

     public MainPage()
     {
          InitializeComponent();
     }

     private void Button_Clicked(object sender, EventArgs e)
     {
          timer = Dispatcher.CreateTimer();
          timer.Interval = TimeSpan.FromMilliseconds(1000);
          timer.Tick += (s, e) =>
          {
               Container.SetColumn(MyEllipse, 1);
               Container.SetRow(MyEllipse, 1);
          };
          timer.Start();
     }
}

