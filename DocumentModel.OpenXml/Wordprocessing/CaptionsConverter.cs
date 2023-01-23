namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Caption Settings.
/// </summary>
public static class CaptionsConverter
{
  private static DMW.Caption? GetCaption(DXW.Captions openXmlElement)
  {
    return DMXW.CaptionConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Caption>());
  }
  
  private static bool CmpCaption(DXW.Captions openXmlElement, DMW.Caption? value, DiffList? diffs, string? objName)
  {
    return DMXW.CaptionConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.Caption>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCaption(DXW.Captions openXmlElement, DMW.Caption? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Caption>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.CaptionConverter.CreateOpenXmlElement<DXW.Caption>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.AutoCaptions? GetAutoCaptions(DXW.Captions openXmlElement)
  {
    return DMXW.AutoCaptionsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.AutoCaptions>());
  }
  
  private static bool CmpAutoCaptions(DXW.Captions openXmlElement, DMW.AutoCaptions? value, DiffList? diffs, string? objName)
  {
    return DMXW.AutoCaptionsConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.AutoCaptions>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAutoCaptions(DXW.Captions openXmlElement, DMW.AutoCaptions? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.AutoCaptions>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.AutoCaptionsConverter.CreateOpenXmlElement<DXW.AutoCaptions>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.Captions? CreateModelElement(DXW.Captions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Captions();
      value.Caption = GetCaption(openXmlElement);
      value.AutoCaptions = GetAutoCaptions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Captions? openXmlElement, DMW.Captions? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCaption(openXmlElement, value.Caption, diffs, objName))
        ok = false;
      if (!CmpAutoCaptions(openXmlElement, value.AutoCaptions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Captions? value)
    where OpenXmlElementType: DXW.Captions, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCaption(openXmlElement, value?.Caption);
      SetAutoCaptions(openXmlElement, value?.AutoCaptions);
      return openXmlElement;
    }
    return default;
  }
}
