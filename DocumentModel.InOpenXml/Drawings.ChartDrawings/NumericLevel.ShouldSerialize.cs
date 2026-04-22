namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class NumericLevel
{
  public bool ShouldSerializePtCount() => PtCount is not null;
  public bool ShouldSerializeFormatCode() => !String.IsNullOrEmpty(FormatCode);
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
}
