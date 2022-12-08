namespace DocumentModel.Drawings;

/// <summary>
/// Defines the CategoryFilterExceptions Class.
/// </summary>
public class CategoryFilterExceptionsImpl: ModelElementImpl, CategoryFilterExceptions
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<CategoryFilterException>? Items
  {
    get;
    set;
  }
  
}
