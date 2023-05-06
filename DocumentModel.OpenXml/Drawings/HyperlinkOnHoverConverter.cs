namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the HyperlinkOnHover Class.
/// </summary>
public static class HyperlinkOnHoverConverter
{
  private static DMD.EmbeddedWavAudioFileType? GetHyperlinkSound(DXD.HyperlinkOnHover openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.HyperlinkSound>();
    if (element != null)
      return DMXD.EmbeddedWavAudioFileTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHyperlinkSound(DXD.HyperlinkOnHover openXmlElement, DMD.EmbeddedWavAudioFileType? value, DiffList? diffs, string? objName)
  {
    return DMXD.EmbeddedWavAudioFileTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.HyperlinkSound>(), value, diffs, objName);
  }
  
  private static void SetHyperlinkSound(DXD.HyperlinkOnHover openXmlElement, DMD.EmbeddedWavAudioFileType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.HyperlinkSound>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.EmbeddedWavAudioFileTypeConverter.CreateOpenXmlElement<DXD.HyperlinkSound>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.HyperlinkExtensionList? GetHyperlinkExtensionList(DXD.HyperlinkOnHover openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.HyperlinkExtensionList>();
    if (element != null)
      return DMXD.HyperlinkExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHyperlinkExtensionList(DXD.HyperlinkOnHover openXmlElement, DMD.HyperlinkExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXD.HyperlinkExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.HyperlinkExtensionList>(), value, diffs, objName);
  }
  
  private static void SetHyperlinkExtensionList(DXD.HyperlinkOnHover openXmlElement, DMD.HyperlinkExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.HyperlinkExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.HyperlinkExtensionListConverter.CreateOpenXmlElement<DXD.HyperlinkExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.HyperlinkOnHover? CreateModelElement(DXD.HyperlinkOnHover? openXmlElement)
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
  
  public static bool CompareModelElement(DXD.HyperlinkOnHover? openXmlElement, DMD.HyperlinkOnHover? value, DiffList? diffs, string? objName)
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
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.HyperlinkOnHover value)
    where OpenXmlElementType: DXD.HyperlinkOnHover, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.HyperlinkOnHover openXmlElement, DMD.HyperlinkOnHover value)
  {
    SetHyperlinkSound(openXmlElement, value?.HyperlinkSound);
    SetHyperlinkExtensionList(openXmlElement, value?.HyperlinkExtensionList);
  }
}
