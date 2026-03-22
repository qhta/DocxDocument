namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class LineSerExtension
{
  public bool ShouldSerializeFilteredSeriesTitle() => FilteredSeriesTitle is not null;
  public bool ShouldSerializeFilteredCategoryTitle() => FilteredCategoryTitle is not null;
  public bool ShouldSerializeDataLabelsRange() => DataLabelsRange is not null;
  public bool ShouldSerializeCategoryFilterExceptions() => CategoryFilterExceptions is not null;
}
