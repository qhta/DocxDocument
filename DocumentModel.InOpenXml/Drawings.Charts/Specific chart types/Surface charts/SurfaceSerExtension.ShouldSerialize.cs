namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class SurfaceSerExtension
{
  public bool ShouldSerializeFilteredSeriesTitle() => FilteredSeriesTitle is not null;
  public bool ShouldSerializeFilteredCategoryTitle() => FilteredCategoryTitle is not null;
  public bool ShouldSerializeCategoryFilterExceptions() => CategoryFilterExceptions is not null;
}
