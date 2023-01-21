namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the HyperlinkOnMouseOver Class.
/// </summary>
public static class HyperlinkOnMouseOverConverter
{
  private static DMDraws.EmbeddedWavAudioFileType? GetHyperlinkSound(DXDraw.HyperlinkOnMouseOver openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.HyperlinkSound>();
    if (itemElement != null)
      return DMXDraws.EmbeddedWavAudioFileTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHyperlinkSound(DXDraw.HyperlinkOnMouseOver openXmlElement, DMDraws.EmbeddedWavAudioFileType? value)
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
  
  private static DMDraws.HyperlinkExtensionList? GetHyperlinkExtensionList(DXDraw.HyperlinkOnMouseOver openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.HyperlinkExtensionList>();
    if (itemElement != null)
      return DMXDraws.HyperlinkExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHyperlinkExtensionList(DXDraw.HyperlinkOnMouseOver openXmlElement, DMDraws.HyperlinkExtensionList? value)
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
  
  public static DMDraws.HyperlinkOnMouseOver? CreateModelElement(DXDraw.HyperlinkOnMouseOver? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.HyperlinkOnMouseOver();
      value.HyperlinkSound = GetHyperlinkSound(openXmlElement);
      value.HyperlinkExtensionList = GetHyperlinkExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.HyperlinkOnMouseOver? value)
    where OpenXmlElementType: DXDraw.HyperlinkOnMouseOver, new()
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
