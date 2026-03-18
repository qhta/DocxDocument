namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class Layout
{
  public bool ShouldSerializeManualLayout() => ManualLayout is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null && ExtensionList.Count > 0;
}
