namespace ModelGen;


public class ProgressInfo
{
  public string? PreStr { get; set; }
  public int? Done { get; set; }
  public int? Total { get; set; }
  public string? MidStr { get; set; }
  public Dictionary<string, object>? Summary {get; set; }
  public string? PostStr { get; set; }
}

public class SummaryInfo
{
  public TimeSpan Time { get; set; }
  public Dictionary<string, object>? Summary {get; set; }
}

public interface IModelMonitor
{
  //public void WriteLine();
  //public void WriteLine(string line);
  public void ShowProcessStart(string line);
  public void ShowPhaseStart(string phaseName);
  public void ShowPhaseProgress(string phaseName, ProgressInfo info);
  public void ShowPhaseEnd(string phaseName, SummaryInfo info);
  public void ShowNamespaceSummary(NTS originTargetSelector);
  public void ShowNamespacesDetails(DisplayOptions options);
  public void ShowNamespaceTypes(string nspace, DisplayOptions options);
  public void ShowTypeInfo(TypeInfo typeInfo, DisplayOptions options);
  public void ShowGenericParamsConstraints(TypeInfo typeInfo, DisplayOptions options);
  public void ShowImplementedInterfaces(TypeInfo typeInfo, DisplayOptions options);
  public void ShowElementsTypes(TypeInfo typeInfo, DisplayOptions options);
  public void ShowOutgoingRelationships(TypeInfo typeInfo, DisplayOptions options);
  public void ShowIncomingRelationships(TypeInfo typeInfo, DisplayOptions options);
  public void ShowEnumValues(TypeInfo typeInfo, DisplayOptions options);
  public void ShowProperties(TypeInfo typeInfo, DisplayOptions options);
  public void ShowDocumentation(ModelElement element, DisplayOptions options);
  public void ShowMetadata(ModelElement element, DisplayOptions options);


  public void ShowTypeRenames();
  public void ShowTypeConversions();
  public void ShowTypeConversion(TypeInfo type);

  public void ShowProcessSummary(SummaryInfo info);


}
