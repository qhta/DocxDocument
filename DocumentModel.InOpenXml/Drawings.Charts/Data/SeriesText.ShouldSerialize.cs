namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class SeriesText
{
  public bool ShouldSerializeStringReference() => StringReference is not null;
  public bool ShouldSerializeNumericValue() => !String.IsNullOrEmpty(NumericValue);
}
