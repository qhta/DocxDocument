namespace ModelGenApp.Views;
/// <summary>
/// Interaction logic for TypeListWindow.xaml
/// </summary>
public partial class TypeListWindow : Window
{
  public TypeListWindow()
  {
    InitializeComponent();
    Activated += TypeListWindow_Activated;
  }

  private void TypeListWindow_Activated(object? sender, EventArgs e)
  {
    Debug.WriteLine("TypeListWindow_Activated");
  }
}
