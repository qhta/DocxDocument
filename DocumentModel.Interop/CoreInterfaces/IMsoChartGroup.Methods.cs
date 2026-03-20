
namespace DocumentModel.Interop.Core;

public partial interface IMsoChartGroup
{
  public object SeriesCollection(object Index);
  public object CategoryCollection(object Index);
  public object FullCategoryCollection(object Index);
}
