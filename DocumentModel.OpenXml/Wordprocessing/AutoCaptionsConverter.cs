namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Automatic Captioning Settings.
/// </summary>
public static class AutoCaptionsConverter
{
  private static DocumentModel.Wordprocessing.AutoCaption? GetAutoCaption(DocumentFormat.OpenXml.Wordprocessing.AutoCaptions openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoCaption>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.AutoCaptionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAutoCaption(DocumentFormat.OpenXml.Wordprocessing.AutoCaptions openXmlElement, DocumentModel.Wordprocessing.AutoCaption? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoCaption>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.AutoCaptionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.AutoCaption>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.AutoCaptions? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.AutoCaptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.AutoCaptions();
      value.AutoCaption = GetAutoCaption(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.AutoCaptions? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.AutoCaptions, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAutoCaption(openXmlElement, value?.AutoCaption);
      return openXmlElement;
    }
    return default;
  }
}
