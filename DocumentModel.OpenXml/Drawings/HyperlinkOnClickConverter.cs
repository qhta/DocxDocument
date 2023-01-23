namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the HyperlinkOnClick Class.
/// </summary>
public static class HyperlinkOnClickConverter
{
  private static DMDraws.EmbeddedWavAudioFileType? GetHyperlinkSound(DXDraw.HyperlinkOnClick openXmlElement)
  {
    return DMXDraws.EmbeddedWavAudioFileTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.HyperlinkSound>());
  }
  
  private static bool CmpHyperlinkSound(DXDraw.HyperlinkOnClick openXmlElement, DMDraws.EmbeddedWavAudioFileType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.EmbeddedWavAudioFileTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.HyperlinkSound>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHyperlinkSound(DXDraw.HyperlinkOnClick openXmlElement, DMDraws.EmbeddedWavAudioFileType? value)
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
  
  private static DMDraws.HyperlinkExtensionList? GetHyperlinkExtensionList(DXDraw.HyperlinkOnClick openXmlElement)
  {
    return DMXDraws.HyperlinkExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.HyperlinkExtensionList>());
  }
  
  private static bool CmpHyperlinkExtensionList(DXDraw.HyperlinkOnClick openXmlElement, DMDraws.HyperlinkExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.HyperlinkExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.HyperlinkExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHyperlinkExtensionList(DXDraw.HyperlinkOnClick openXmlElement, DMDraws.HyperlinkExtensionList? value)
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
  
  public static DMDraws.HyperlinkOnClick? CreateModelElement(DXDraw.HyperlinkOnClick? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.HyperlinkOnClick();
      value.HyperlinkSound = GetHyperlinkSound(openXmlElement);
      value.HyperlinkExtensionList = GetHyperlinkExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.HyperlinkOnClick? openXmlElement, DMDraws.HyperlinkOnClick? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpHyperlinkSound(openXmlElement, value.HyperlinkSound, diffs, objName))
        ok = false;
      if (!CmpHyperlinkExtensionList(openXmlElement, value.HyperlinkExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.HyperlinkOnClick? value)
    where OpenXmlElementType: DXDraw.HyperlinkOnClick, new()
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
