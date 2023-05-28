namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the HyperlinkOnClick Class.
/// </summary>
public static class HyperlinkOnClickConverter
{
  private static DMD.EmbeddedWavAudioFileType? GetHyperlinkSound(DXD.HyperlinkOnClick openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.HyperlinkSound>();
    if (element != null)
      return DMXD.EmbeddedWavAudioFileTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHyperlinkSound(DXD.HyperlinkOnClick openXmlElement, DMD.EmbeddedWavAudioFileType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.EmbeddedWavAudioFileTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.HyperlinkSound>(), value, diffs, objName, propName);
  }
  
  private static void SetHyperlinkSound(DXD.HyperlinkOnClick openXmlElement, DMD.EmbeddedWavAudioFileType? value)
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
  
  private static DMD.HyperlinkExtensionList? GetHyperlinkExtensionList(DXD.HyperlinkOnClick openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.HyperlinkExtensionList>();
    if (element != null)
      return DMXD.HyperlinkExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHyperlinkExtensionList(DXD.HyperlinkOnClick openXmlElement, DMD.HyperlinkExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.HyperlinkExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.HyperlinkExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetHyperlinkExtensionList(DXD.HyperlinkOnClick openXmlElement, DMD.HyperlinkExtensionList? value)
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
  
  public static DMD.HyperlinkOnClick? CreateModelElement(DXD.HyperlinkOnClick? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.HyperlinkOnClick();
      value.HyperlinkSound = GetHyperlinkSound(openXmlElement);
      value.HyperlinkExtensionList = GetHyperlinkExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.HyperlinkOnClick? openXmlElement, DMD.HyperlinkOnClick? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpHyperlinkSound(openXmlElement, value.HyperlinkSound, diffs, objName, propName))
        ok = false;
      if (!CmpHyperlinkExtensionList(openXmlElement, value.HyperlinkExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.HyperlinkOnClick value)
    where OpenXmlElementType: DXD.HyperlinkOnClick, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.HyperlinkOnClick openXmlElement, DMD.HyperlinkOnClick value)
  {
    SetHyperlinkSound(openXmlElement, value?.HyperlinkSound);
    SetHyperlinkExtensionList(openXmlElement, value?.HyperlinkExtensionList);
  }
}
