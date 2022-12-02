namespace DocumentModel.Drawing;

/// <summary>
/// Defines the LineSerExtension Class.
/// </summary>
public interface ILineSerExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.IFilteredSeriesTitle? FilteredSeriesTitle { get ; set; }
  
  public DocumentModel.Drawing.IFilteredCategoryTitle? FilteredCategoryTitle { get ; set; }
  
  public DocumentModel.Drawing.IDataLabelsRange? DataLabelsRange { get ; set; }
  
  public DocumentModel.Drawing.ICategoryFilterExceptions? CategoryFilterExceptions { get ; set; }
  
}
