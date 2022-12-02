namespace DocumentModel.Drawing;

/// <summary>
/// Defines the BubbleSerExtension Class.
/// </summary>
public interface IBubbleSerExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IInvertSolidFillFormat? InvertSolidFillFormat { get ; set; }
  
  public IFilteredCategoryTitle? FilteredCategoryTitle { get ; set; }
  
  public IDataLabelsRange? DataLabelsRange { get ; set; }
  
  public ICategoryFilterExceptions? CategoryFilterExceptions { get ; set; }
  
}
