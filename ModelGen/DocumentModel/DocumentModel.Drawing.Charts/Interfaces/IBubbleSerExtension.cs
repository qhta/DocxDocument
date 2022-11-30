namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the BubbleSerExtension Class.
/// </summary>
public interface IBubbleSerExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2010.Drawing.Charts.IInvertSolidFillFormat? InvertSolidFillFormat { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.IFilteredCategoryTitle? FilteredCategoryTitle { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.IDataLabelsRange? DataLabelsRange { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.ICategoryFilterExceptions? CategoryFilterExceptions { get ; set; }
  
}
