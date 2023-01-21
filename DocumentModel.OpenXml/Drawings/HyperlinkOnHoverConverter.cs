namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the HyperlinkOnHover Class.
/// </summary>
public static class HyperlinkOnHoverConverter
{
  private static DMDraws.EmbeddedWavAudioFileType? GetHyperlinkSound(DXDraw.HyperlinkOnHover openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.HyperlinkSound>();
    if (itemElement != null)
      return DMXDraws.EmbeddedWavAudioFileTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHyperlinkSound(DXDraw.HyperlinkOnHover openXmlElement, DMDraws.EmbeddedWavAudioFileType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.HyperlinkSound>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.EmbeddedWavAudioFileTypeConverter.CreateOpenXmlElement<DXDraw.HyperlinkSound>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.HyperlinkExtensionList? GetHyperlinkExtensionList(DXDraw.HyperlinkOnHover openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.HyperlinkExtensionList>();
    if (itemElement != null)
      return DMXDraws.HyperlinkExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHyperlinkExtensionList(DXDraw.HyperlinkOnHover openXmlElement, DMDraws.HyperlinkExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.HyperlinkExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.HyperlinkExtensionListConverter.CreateOpenXmlElement<DXDraw.HyperlinkExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.HyperlinkOnHover? CreateModelElement(DXDraw.HyperlinkOnHover? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.HyperlinkOnHover();
      value.HyperlinkSound = GetHyperlinkSound(openXmlElement);
      value.HyperlinkExtensionList = GetHyperlinkExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.HyperlinkOnHover? value)
    where OpenXmlElementType: DXDraw.HyperlinkOnHover, new()
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
