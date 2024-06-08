using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DocxEd;
using DocxEd.ViewModels;

namespace DocxEditor;


/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
  private DocxEd.Editor Editor = new DocxEd.Editor();
  public MainWindow()
  {
    InitializeComponent();
  }

  private void FileOpen_Executed(object sender, ExecutedRoutedEventArgs e)
  {
    var dialog = new Microsoft.Win32.OpenFileDialog();
    //dialog.FileName = "Document"; // Default file name
    dialog.DefaultExt = ".docx"; // Default file extension
    dialog.Filter = "Word documents (.docx)|*.docx"; // Filter files by extension

    bool? result = dialog.ShowDialog();
    if (result == true)
    {
      string filename = dialog.FileName;
      var document = Editor.OpenFile(filename);
      var documentVM = new DocumentViewModel(document);
      this.DataContext = documentVM;
      BindingOperations.SetBinding(this, TitleProperty, new Binding("Caption"));
    }
  }
}