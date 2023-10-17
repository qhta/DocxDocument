namespace ModelGen;
public record SummaryInfo
{
  public bool ProcessCancelled { get; set; }
  public TimeSpan Time { get; set; }
  public Dictionary<SummaryInfoKind, object>? Summary {get; set; }
}