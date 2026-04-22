namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class NumberLiteral
{
  public bool ShouldSerializeFormatCode() => !String.IsNullOrEmpty(FormatCode);
  public bool ShouldSerializePointCount() => PointCount is not null;
  public bool ShouldSerializeNumericPoints() => NumericPoints is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
