namespace ModelGenApp.ViewModels;

[ObservableObject]
public partial class ProcessMonitor : ModelMonitor
{
  [ObservableProperty]
  private ObservableCollection<string> lines = new ObservableCollection<string>();

  [ObservableProperty]
  private string? statusLine;

  [ObservableProperty]
  private int indentLevel;

  [ObservableProperty]
  private int indentSize = 2;

  public override void WriteLine()
  {
    Application.Current.Dispatcher.BeginInvoke(() => Lines.Add(string.Empty));
  }

  public override void WriteLine(string line)
  {
    Application.Current.Dispatcher.BeginInvoke(() => Lines.Add(line));
  }

  public override void WriteSameLine(string line)
  {
    Application.Current.Dispatcher.BeginInvoke(() => StatusLine=line);
  }

  public override void Indent()
  {
    IndentLevel++;
  }

  public override void Unindent()
  {
    if (IndentLevel > 0)
      IndentLevel--;
  }

  public override DocumentationWriter GetDocumentationWriter(DisplayOptions options)
  {
    throw new NotImplementedException();
  }
}
