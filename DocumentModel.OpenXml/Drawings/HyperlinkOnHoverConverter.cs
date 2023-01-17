namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the HyperlinkOnHover Class.
/// </summary>
public static class HyperlinkOnHoverConverter
{
  private static DocumentModel.Drawings.EmbeddedWavAudioFileType? GetHyperlinkSound(DocumentFormat.OpenXml.Drawing.HyperlinkOnHover openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkSound>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.EmbeddedWavAudioFileTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHyperlinkSound(DocumentFormat.OpenXml.Drawing.HyperlinkOnHover openXmlElement, DocumentModel.Drawings.EmbeddedWavAudioFileType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkSound>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.EmbeddedWavAudioFileTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.HyperlinkSound>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.HyperlinkExtensionList? GetHyperlinkExtensionList(DocumentFormat.OpenXml.Drawing.HyperlinkOnHover openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.HyperlinkExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHyperlinkExtensionList(DocumentFormat.OpenXml.Drawing.HyperlinkOnHover openXmlElement, DocumentModel.Drawings.HyperlinkExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.HyperlinkExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.HyperlinkExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.HyperlinkOnHover? CreateModelElement(DocumentFormat.OpenXml.Drawing.HyperlinkOnHover? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.HyperlinkOnHover();
      value.HyperlinkSound = GetHyperlinkSound(openXmlElement);
      value.HyperlinkExtensionList = GetHyperlinkExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.HyperlinkOnHover? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.HyperlinkOnHover, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetHyperlinkSound(openXmlElement, value?.HyperlinkSound);
      SetHyperlinkExtensionList(openXmlElement, value?.HyperlinkExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
