namespace ModelGenRun;

public class ModelDisplay : ModelMonitor
{
  private TraceWriter Writer { get; set; }
  private int LineLength = 0;

  public ModelDisplay()
  {
    Writer = new TraceWriter();
  }

  public override void WriteLine(string str)
  {
    Writer.WriteLine(str);
    LineLength = str.Length;
  }
  public override void WriteLine()
  {
    Writer.WriteLine();
    LineLength = 0;
  }

  public override void WriteSameLine(string str)
  {
    int maxLength = Console.WindowWidth - 1;
    if (str.Length > maxLength)
      str = str.Substring(maxLength);
    var l = str?.Length ?? 0;
    int n = (l < LineLength) ? LineLength - l : 0;
    Console.Write($"\r{str}");
    if (n > 0)
      Console.Write(new String(' ', n));
    LineLength = l;
  }

  public override void Indent()
  {
    Writer.Indent();
  }
  public override void Unindent()
  {
    Writer.Unindent();
  }

  public override DocumentationWriter GetDocumentationWriter(DisplayOptions options)
  {
    return new DocumentationWriter(Writer, Writer.IndentLevel * Writer.IndentSize, options.LineWidthLimit);
  }
}

