namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the BubbleSerExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.Charts.IInvertSolidFillFormat))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.ICategoryFilterExceptions))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IFilteredCategoryTitle))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IDataLabelsRange))]
public class BubbleSerExtension: IBubbleSerExtension
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
