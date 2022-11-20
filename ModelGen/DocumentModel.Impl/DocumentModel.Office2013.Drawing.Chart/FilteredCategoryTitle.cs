namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the FilteredCategoryTitle Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IAxisDataSourceType))]
public class FilteredCategoryTitle: IFilteredCategoryTitle
{
  /// <summary>
  /// AxisDataSourceType.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.IAxisDataSourceType? AxisDataSourceType
  {
    get;
    set;
  }
  
}
