namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the ScatterSerExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.ICategoryFilterExceptions))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IFilteredCategoryTitle))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IFilteredSeriesTitle))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IDataLabelsRange))]
public class ScatterSerExtension: IScatterSerExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}
