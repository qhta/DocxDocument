namespace ModelGen;
public record SummaryInfo
{
  public bool ProcessCancelled { get; set; }
  public TimeSpan Time { get; set; }
  public bool ValidationOk { get; set; }
  public Dictionary<SummaryInfoKind, object> Summary {get; set; } = new Dictionary<SummaryInfoKind, object>();
}