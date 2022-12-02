namespace DocumentModel.Drawing;

/// <summary>
/// Defines the BarSerExtension Class.
/// </summary>
public interface IBarSerExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IInvertSolidFillFormat? InvertSolidFillFormat { get ; set; }
  
  public IFilteredSeriesTitle? FilteredSeriesTitle { get ; set; }
  
  public IFilteredCategoryTitle? FilteredCategoryTitle { get ; set; }
  
  public IDataLabelsRange? DataLabelsRange { get ; set; }
  
  public ICategoryFilterExceptions? CategoryFilterExceptions { get ; set; }
  
}
