namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class DisplayUnits
{
  public bool ShouldSerializeCustomDisplayUnit() => CustomDisplayUnit is not null;
  public bool ShouldSerializeBuiltInUnit() => BuiltInUnit is not null;
  public bool ShouldSerializeDisplayUnitsLabel() => DisplayUnitsLabel is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null && ExtensionList.Count > 0;
}
