namespace DocumentModel.Drawing;

/// <summary>
/// Defines the BubbleSerExtension Class.
/// </summary>
public interface IBubbleSerExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.IInvertSolidFillFormat? InvertSolidFillFormat { get ; set; }
  
  public DocumentModel.Drawing.IFilteredCategoryTitle? FilteredCategoryTitle { get ; set; }
  
  public DocumentModel.Drawing.IDataLabelsRange? DataLabelsRange { get ; set; }
  
  public DocumentModel.Drawing.ICategoryFilterExceptions? CategoryFilterExceptions { get ; set; }
  
}
