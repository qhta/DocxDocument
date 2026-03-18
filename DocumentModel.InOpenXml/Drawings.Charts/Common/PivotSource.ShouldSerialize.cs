namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class PivotSource
{
  public bool ShouldSerializePivotTableName() => !String.IsNullOrEmpty(PivotTableName);
  public bool ShouldSerializeFormatId() => FormatId is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null && ExtensionList.Count > 0;
}
