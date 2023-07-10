namespace ModelGenApp.Views;
/// <summary>
/// Interaction logic for PhaseProgressView.xaml
/// </summary>
public partial class PhaseProgressView : UserControl
{
  public PhaseProgressView()
  {
    InitializeComponent();
  }

  public static DependencyProperty PercentageProperty = DependencyProperty.Register
    ("Percentage", typeof(int), typeof(PhaseProgressView),
     new PropertyMetadata(0, PercentagePropertyChanged));

  public int Percentage
  {
    get => (int)GetValue(PercentageProperty); 
    set => SetValue(PercentageProperty, value);
  }

  private static void PercentagePropertyChanged(object sender, DependencyPropertyChangedEventArgs arg)
  {
    var instance = (PhaseProgressView)sender;
    var phaseProgressVM = instance.FindResource("PhaseProgressVM") as ViewModels.PhaseProgressViewModel;
    if (phaseProgressVM!=null && !double.IsNaN(instance.ActualHeight) && instance.ActualHeight!=0)
      DispatcherHelper.Invoke(()=>
       phaseProgressVM.InnerHeight = (int)((int)arg.NewValue*instance.ActualHeight/100)
      );
  }


}
