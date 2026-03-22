namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class FilteredCategoryTitle
{
  public bool ShouldSerializeAxisDataSourceType() => AxisDataSourceType is not null;
}
