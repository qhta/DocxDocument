namespace DocumentModel.Drawings.Charts;

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
  
  public DocumentModel.Drawings.Charts.CategoryFilterException? CategoryFilterException
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.CategoryFilterExceptionImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.CategoryFilterExceptionImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
