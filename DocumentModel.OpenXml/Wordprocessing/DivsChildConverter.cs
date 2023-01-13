namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Child div Elements Contained within Current div.
/// </summary>
public static class DivsChildConverter
{
  public static DocumentModel.Wordprocessing.Div? GetDiv(DocumentFormat.OpenXml.Wordprocessing.DivsChild? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Div>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DivConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDiv(DocumentFormat.OpenXml.Wordprocessing.DivsChild? openXmlElement, DocumentModel.Wordprocessing.Div? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Wordprocessing.DivsChild? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.DivsChild? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.DivsChild();
      value.Div = GetDiv(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.DivsChild? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.DivsChild, new()
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
