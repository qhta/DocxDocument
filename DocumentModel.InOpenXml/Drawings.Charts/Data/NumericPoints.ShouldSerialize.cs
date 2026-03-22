namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class NumericPoints
{
  public bool ShouldSerializeIndex() => Index is not null;
  public bool ShouldSerializeFormatCode() => !String.IsNullOrEmpty(FormatCode);
  public bool ShouldSerializeNumericValue() => !String.IsNullOrEmpty(NumericValue);
}
