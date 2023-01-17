namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the CategoryFilterExceptions Class.
/// </summary>
public static class CategoryFilterExceptionsConverter
{
  private static DocumentModel.Drawings.Charts.CategoryFilterException? GetCategoryFilterException(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.CategoryFilterExceptionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCategoryFilterException(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions openXmlElement, DocumentModel.Drawings.Charts.CategoryFilterException? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.CategoryFilterExceptionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.CategoryFilterExceptions? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.CategoryFilterExceptions();
      value.CategoryFilterException = GetCategoryFilterException(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.CategoryFilterExceptions? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCategoryFilterException(openXmlElement, value?.CategoryFilterException);
      return openXmlElement;
    }
    return default;
  }
}
