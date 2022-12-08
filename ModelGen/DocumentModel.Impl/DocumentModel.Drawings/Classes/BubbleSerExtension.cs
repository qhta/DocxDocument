namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BubbleSerExtension Class.
/// </summary>
public class BubbleSerExtensionImpl: ModelElementImpl, BubbleSerExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get;
    set;
  }
  
  public InvertSolidFillFormat? InvertSolidFillFormat
  {
    get;
    set;
  }
  
  public FilteredCategoryTitle? FilteredCategoryTitle
  {
    get;
    set;
  }
  
  public DataLabelsRange? DataLabelsRange
  {
    get;
    set;
  }
  
  public CategoryFilterExceptions? CategoryFilterExceptions
  {
    get;
    set;
  }
  
}
