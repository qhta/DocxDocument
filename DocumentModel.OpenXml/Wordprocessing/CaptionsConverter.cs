namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Caption Settings.
/// </summary>
public static class CaptionsConverter
{
  public static DocumentModel.Wordprocessing.Caption? GetCaption(DocumentFormat.OpenXml.Wordprocessing.Captions? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Caption>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.CaptionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCaption(DocumentFormat.OpenXml.Wordprocessing.Captions? openXmlElement, DocumentModel.Wordprocessing.Caption? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Caption>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.CaptionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Caption>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.AutoCaptions? GetAutoCaptions(DocumentFormat.OpenXml.Wordprocessing.Captions? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoCaptions>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.AutoCaptionsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAutoCaptions(DocumentFormat.OpenXml.Wordprocessing.Captions? openXmlElement, DocumentModel.Wordprocessing.AutoCaptions? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoCaptions>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.AutoCaptionsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.AutoCaptions>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Captions? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Captions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Captions();
      value.Caption = GetCaption(openXmlElement);
      value.AutoCaptions = GetAutoCaptions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Captions? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Captions, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
