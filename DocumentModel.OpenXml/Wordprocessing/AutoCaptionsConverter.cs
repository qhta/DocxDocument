namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Automatic Captioning Settings.
/// </summary>
public static class AutoCaptionsConverter
{
  private static DMW.AutoCaption? GetAutoCaption(DXW.AutoCaptions openXmlElement)
  {
    return DMXW.AutoCaptionConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.AutoCaption>());
  }
  
  private static bool CmpAutoCaption(DXW.AutoCaptions openXmlElement, DMW.AutoCaption? value, DiffList? diffs, string? objName)
  {
    return DMXW.AutoCaptionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.AutoCaption>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAutoCaption(DXW.AutoCaptions openXmlElement, DMW.AutoCaption? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.AutoCaption>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.AutoCaptionConverter.CreateOpenXmlElement<DXW.AutoCaption>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.AutoCaptions? CreateModelElement(DXW.AutoCaptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.AutoCaptions();
      value.AutoCaption = GetAutoCaption(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.AutoCaptions? openXmlElement, DMW.AutoCaptions? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAutoCaption(openXmlElement, value.AutoCaption, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.AutoCaptions? value)
    where OpenXmlElementType: DXW.AutoCaptions, new()
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
