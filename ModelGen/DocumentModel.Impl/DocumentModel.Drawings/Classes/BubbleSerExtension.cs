namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BubbleSerExtension Class.
/// </summary>
public class BubbleSerExtensionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension>, BubbleSerExtension
{
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
