namespace ModelGen;
public class SummaryInfo
{
  public TimeSpan Time { get; set; }
  public Dictionary<TypeInfoKind, object>? Summary {get; set; }
}