namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class ValueAxis
{
  public bool ShouldSerializeCrossBetween() => CrossBetween is not null;
  public bool ShouldSerializeMajorUnit() => MajorUnit is not null;
  public bool ShouldSerializeMinorUnit() => MinorUnit is not null;
  public bool ShouldSerializeDisplayUnits() => DisplayUnits is not null;
  public bool ShouldSerializeValAxExtensionList() => ValAxExtensionList is not null && ValAxExtensionList.Count > 0;
}
