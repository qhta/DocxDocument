namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class CategoryAxisScaling
{
  public bool ShouldSerializeGapWidth() => !String.IsNullOrEmpty(GapWidth);
}
