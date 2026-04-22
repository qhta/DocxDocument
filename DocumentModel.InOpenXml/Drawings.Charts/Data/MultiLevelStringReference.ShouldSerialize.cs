namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class MultiLevelStringReference
{
  public bool ShouldSerializeFormula() => !String.IsNullOrEmpty(Formula);
  public bool ShouldSerializeMultiLevelStringCache() => MultiLevelStringCache is not null;
  public bool ShouldSerializeMultiLvlStrRefExtensionList() => MultiLvlStrRefExtensionList is not null;
}
