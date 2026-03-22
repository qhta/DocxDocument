namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class Scaling
{
  public bool ShouldSerializeLogBase() => LogBase is not null;
  public bool ShouldSerializeOrientation() => Orientation is not null;
  public bool ShouldSerializeMaxAxisValue() => MaxAxisValue is not null;
  public bool ShouldSerializeMinAxisValue() => MinAxisValue is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null && ExtensionList.Count > 0;
}
