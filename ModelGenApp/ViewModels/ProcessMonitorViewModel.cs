namespace ModelGenApp.ViewModels;

[ObservableObject]
public partial class ProcessMonitorViewModel: ModelMonitor
{
  [ObservableProperty]
  public ObservableCollection<string> lines = new ObservableCollection<string>();

  [ObservableProperty]
  private int indentLevel;

  [ObservableProperty]
  private int indentSize = 2;

  public override void WriteLine()
  {
    Lines.Add(string.Empty);
  }

  public override void WriteLine(string line)
  {
    Lines.Add(line);
  }

  public override void WriteSameLine(string line)
  {
    Lines[Lines.Count-1] = line;
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
