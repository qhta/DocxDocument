namespace ModelGen;
public class SummaryInfo
{
  public bool ProcessCancelled { get; set; }
  public TimeSpan Time { get; set; }
  public Dictionary<TypeInfoKind, object>? Summary {get; set; }
}