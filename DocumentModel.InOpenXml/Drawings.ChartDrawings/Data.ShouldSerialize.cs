namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class Data
{
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeNumericDimension() => NumericDimension is not null;
  public bool ShouldSerializeStringDimension() => StringDimension is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
