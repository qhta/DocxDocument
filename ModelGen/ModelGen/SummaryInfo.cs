namespace ModelGen;
public record SummaryInfo
{
  public bool ProcessCancelled { get; set; }
  public TimeSpan Time { get; set; }
  public Dictionary<TypeInfoKind, object>? Summary {get; set; }
}