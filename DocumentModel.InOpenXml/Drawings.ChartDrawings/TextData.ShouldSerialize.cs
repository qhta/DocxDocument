namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class TextData
{
  public bool ShouldSerializeFormula() => Formula is not null;
  public bool ShouldSerializeVXsdString() => !String.IsNullOrEmpty(VXsdString);
}
