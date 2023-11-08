namespace ModelGen;
public record SummaryInfo
{
  public bool ProcessCancelled { [DebuggerStepThrough] get; set; }
  public TimeSpan Time { [DebuggerStepThrough] get; set; }
  public bool ValidationOk { [DebuggerStepThrough] get; set; }
  public Dictionary<SummaryInfoKind, object> Summary {get; set; } = new Dictionary<SummaryInfoKind, object>();
}