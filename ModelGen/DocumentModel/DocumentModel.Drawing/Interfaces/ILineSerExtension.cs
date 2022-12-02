namespace DocumentModel.Drawing;

/// <summary>
/// Defines the LineSerExtension Class.
/// </summary>
public interface ILineSerExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IFilteredSeriesTitle? FilteredSeriesTitle { get ; set; }
  
  public IFilteredCategoryTitle? FilteredCategoryTitle { get ; set; }
  
  public IDataLabelsRange? DataLabelsRange { get ; set; }
  
  public ICategoryFilterExceptions? CategoryFilterExceptions { get ; set; }
  
}
