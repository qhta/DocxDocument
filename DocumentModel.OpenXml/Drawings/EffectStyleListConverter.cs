namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Effect Style List.
/// </summary>
public static class EffectStyleListConverter
{
  private static DMD.EffectStyle? GetEffectStyle(DXD.EffectStyleList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EffectStyle>();
    if (element != null)
      return DMXD.EffectStyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectStyle(DXD.EffectStyleList openXmlElement, DMD.EffectStyle? value, DiffList? diffs, string? objName)
  {
    return DMXD.EffectStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectStyle>(), value, diffs, objName);
  }
  
  private static void SetEffectStyle(DXD.EffectStyleList openXmlElement, DMD.EffectStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.EffectStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.EffectStyleConverter.CreateOpenXmlElement<DXD.EffectStyle>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.EffectStyleList? CreateModelElement(DXD.EffectStyleList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.EffectStyleList();
      value.EffectStyle = GetEffectStyle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.EffectStyleList? openXmlElement, DMD.EffectStyleList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEffectStyle(openXmlElement, value.EffectStyle, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.EffectStyleList value)
    where OpenXmlElementType: DXD.EffectStyleList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.EffectStyleList openXmlElement, DMD.EffectStyleList value)
  {
    SetEffectStyle(openXmlElement, value?.EffectStyle);
  }
}
