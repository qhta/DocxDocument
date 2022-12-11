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
  
  public CategoryFilterExceptionsImpl(): base() {}
  
  public CategoryFilterExceptionsImpl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public CategoryFilterException? CategoryFilterException
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
