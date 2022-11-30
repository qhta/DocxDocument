namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the BarSerExtension Class.
/// </summary>
public interface IBarSerExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2010.Drawing.Charts.IInvertSolidFillFormat? InvertSolidFillFormat { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.IFilteredSeriesTitle? FilteredSeriesTitle { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.IFilteredCategoryTitle? FilteredCategoryTitle { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.IDataLabelsRange? DataLabelsRange { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.ICategoryFilterExceptions? CategoryFilterExceptions { get ; set; }
  
}
