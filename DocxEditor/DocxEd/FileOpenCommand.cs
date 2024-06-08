using System.Security.Principal;
using System.Windows.Input;

namespace DocxEd;

public class FileOpenCommand: ICommand

{
  public bool CanExecute(object? parameter)
  {
    return true;
  }

  public void Execute(object? parameter)
  {
    var dialog = new Microsoft.Win32.OpenFileDialog();
    dialog.FileName = "Document"; // Default file name
    dialog.DefaultExt = ".docx"; // Default file extension
    dialog.Filter = "Word documents (.docx)|*.docx"; // Filter files by extension

    bool? result = dialog.ShowDialog();
    if (result == true)
    {
      string filename = dialog.FileName;
    }
  }

  public event EventHandler? CanExecuteChanged;
}

