namespace ModelGenApp.Views;
/// <summary>
/// Interaction logic for ModelConfigView.xaml
/// </summary>
public partial class ModelConfigView : Window
{
  public ModelConfigView()
  {
    InitializeComponent();
    ModelConfigViewModel modelView = new ModelConfigViewModel();
    var assembly = Assembly.Load("DocumentFormat.OpenXml");
    modelView.GetData(ModelConfig.Instance, assembly);
    DataContext = modelView;
  }
}
