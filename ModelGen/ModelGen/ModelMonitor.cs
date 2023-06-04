namespace ModelGen;

public class ProcessInfo
{
  public TimeSpan TotalTime { get; set; }
}

public abstract class ModelMonitor
{
  public abstract void WriteLine();
  public abstract void WriteLine(string line);
  public abstract void WriteSameLine(string line);
  public abstract void ShowNamespaceSummary(NTS originTargetSelector = NTS.Any);
  public abstract void ShowNamespacesDetails(DisplayOptions options);
  public abstract void ShowNamespaceDetails(string nspace, DisplayOptions options);
  public abstract void ShowTypes(string nspace, string name);
  public abstract void ShowTypeInfo(TypeInfo typeInfo, DisplayOptions options);
  public abstract void ShowGenericParamsConstraints(TypeInfo typeInfo, DisplayOptions options);
  public abstract void ShowImplementedInterfaces(TypeInfo typeInfo, DisplayOptions options);
  public abstract void ShowElementsTypes(TypeInfo typeInfo, DisplayOptions options);
  public abstract void ShowOutgoingRelationships(TypeInfo typeInfo, DisplayOptions options);
  public abstract void ShowIncomingRelationships(TypeInfo typeInfo, DisplayOptions options);
  public abstract void ShowEnumValues(TypeInfo typeInfo, DisplayOptions options);
  public abstract void ShowProperties(TypeInfo typeInfo, DisplayOptions options);

  public abstract void ShowTypeRenames();
  public abstract void ShowTypeConversions();
  public abstract void ShowTypeConversion(TypeInfo type);

  public abstract void ShowProcessSummary(ProcessInfo info);


  #region Helper functions to format diplay
  protected string AllNone(int n, int cmp) => (n == 0) ? "none" : (n == cmp) ? "all" : n.ToString();
  protected string Multi(int n, string single, string? multi = null) => (n == 1) ? single : (multi ?? (single.EndsWith("s") ? (single + "es") : (single + "s")));
  protected string Accepted(bool? acceptance) => (acceptance == true) ? "+ " : (acceptance == false) ? "- " : "? ";
  #endregion

  protected bool IsTypeKind(TypeKind typeKind, TKS selector)
  {
    switch (typeKind)
    {
      case TypeKind.Type:
        return selector == TKS.Any;
      case TypeKind.Struct:
        return selector.HasFlag(TKS.Struct);
      case TypeKind.Class:
        return selector.HasFlag(TKS.Class);
      case TypeKind.Enum:
        return selector.HasFlag(TKS.Enum);
      case TypeKind.Interface:
        return selector.HasFlag(TKS.Interface);
    }
    return false;
  }

  protected string[] constaints = new string[]
  {
    "covariant",
    "contravariant",
    "class",
    "struct",
    "new()"
  };

}
