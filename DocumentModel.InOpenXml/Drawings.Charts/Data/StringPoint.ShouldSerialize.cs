namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class StringPoint
{
  public bool ShouldSerializeIndex() => Index is not null;
  public bool ShouldSerializeNumericValue() => !String.IsNullOrEmpty(NumericValue);
}
