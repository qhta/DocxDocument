namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Structured Document Tag End Character Properties.
/// </summary>
public static class SdtEndCharPropertiesConverter
{
  private static DocumentModel.Wordprocessing.RunProperties? GetRunProperties(DocumentFormat.OpenXml.Wordprocessing.SdtEndCharProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRunProperties(DocumentFormat.OpenXml.Wordprocessing.SdtEndCharProperties openXmlElement, DocumentModel.Wordprocessing.RunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.RunPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.SdtEndCharProperties? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.SdtEndCharProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SdtEndCharProperties();
      value.RunProperties = GetRunProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SdtEndCharProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.SdtEndCharProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRunProperties(openXmlElement, value?.RunProperties);
      return openXmlElement;
    }
    return default;
  }
}
