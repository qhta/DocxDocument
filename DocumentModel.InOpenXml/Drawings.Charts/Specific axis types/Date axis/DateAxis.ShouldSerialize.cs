namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class DateAxis
{
  public bool ShouldSerializeAutoLabeled() => AutoLabeled is not null;
  public bool ShouldSerializeLabelOffset() => LabelOffset is not null;
  public bool ShouldSerializeBaseTimeUnit() => BaseTimeUnit is not null;
  public bool ShouldSerializeMajorUnit() => MajorUnit is not null;
  public bool ShouldSerializeMajorTimeUnit() => MajorTimeUnit is not null;
  public bool ShouldSerializeMinorUnit() => MinorUnit is not null;
  public bool ShouldSerializeMinorTimeUnit() => MinorTimeUnit is not null;
  public bool ShouldSerializeDateAxExtensionList() => DateAxExtensionList is not null;
}
