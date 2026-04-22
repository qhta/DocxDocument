namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class SeriesLayoutProperties
{
  public bool ShouldSerializeParentLabelLayout() => ParentLabelLayout is not null;
  public bool ShouldSerializeRegionLabelLayout() => RegionLabelLayout is not null;
  public bool ShouldSerializeSeriesElementVisibilities() => SeriesElementVisibilities is not null;
  public bool ShouldSerializeAggregation() => Aggregation is not null;
  public bool ShouldSerializeBinning() => Binning is not null;
  public bool ShouldSerializeGeography() => Geography is not null;
  public bool ShouldSerializeStatistics() => Statistics is not null;
  public bool ShouldSerializeSubtotals() => Subtotals is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
