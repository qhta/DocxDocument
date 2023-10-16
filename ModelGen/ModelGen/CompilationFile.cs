namespace ModelGen;

public record CompilationFile
{
  public CompilationFile(string name)
  {
    Filename = name;
  }

  public string Filename { get; set; }
}
