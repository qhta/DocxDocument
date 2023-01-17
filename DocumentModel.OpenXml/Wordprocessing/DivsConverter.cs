namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Divs Class.
/// </summary>
public static class DivsConverter
{
  private static DocumentModel.Wordprocessing.Div? GetDiv(DocumentFormat.OpenXml.Wordprocessing.Divs openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Div>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DivConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDiv(DocumentFormat.OpenXml.Wordprocessing.Divs openXmlElement, DocumentModel.Wordprocessing.Div? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Div>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.DivConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Div>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.Divs? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Divs? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Divs();
      value.Div = GetDiv(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Divs? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Divs, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDiv(openXmlElement, value?.Div);
      return openXmlElement;
    }
    return default;
  }
}
