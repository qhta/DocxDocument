namespace ModelGen;

public record CompilationError
{
  public string? Filename { [DebuggerStepThrough] get; set; }
  public string? Code { [DebuggerStepThrough] get; set; }
  public string? Description { [DebuggerStepThrough] get; set; }
}
