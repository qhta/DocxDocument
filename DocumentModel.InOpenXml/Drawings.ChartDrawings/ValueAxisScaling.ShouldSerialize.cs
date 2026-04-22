namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class ValueAxisScaling
{
  public bool ShouldSerializeMax() => !String.IsNullOrEmpty(Max);
  public bool ShouldSerializeMin() => !String.IsNullOrEmpty(Min);
  public bool ShouldSerializeMajorUnit() => !String.IsNullOrEmpty(MajorUnit);
  public bool ShouldSerializeMinorUnit() => !String.IsNullOrEmpty(MinorUnit);
}
