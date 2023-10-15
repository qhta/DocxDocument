namespace ModelGen;

public record CompilationError
{
  public string? Filename { get; set; }
  public string? Code { get; set; }
  public string? Description { get; set; }
}
