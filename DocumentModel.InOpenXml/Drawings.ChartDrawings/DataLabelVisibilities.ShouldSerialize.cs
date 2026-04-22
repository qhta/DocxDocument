namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class DataLabelVisibilities
{
  public bool ShouldSerializeSeriesName() => SeriesName is not null;
  public bool ShouldSerializeCategoryName() => CategoryName is not null;
  public bool ShouldSerializeValue() => Value is not null;
}
