namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Effect Style List.
/// </summary>
public static class EffectStyleListConverter
{
  private static DMDraws.EffectStyle? GetEffectStyle(DXDraw.EffectStyleList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.EffectStyle>();
    if (element != null)
      return DMXDraws.EffectStyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectStyle(DXDraw.EffectStyleList openXmlElement, DMDraws.EffectStyle? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.EffectStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.EffectStyle>(), value, diffs, objName);
  }
  
  private static void SetEffectStyle(DXDraw.EffectStyleList openXmlElement, DMDraws.EffectStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.EffectStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.EffectStyleConverter.CreateOpenXmlElement<DXDraw.EffectStyle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.EffectStyleList? CreateModelElement(DXDraw.EffectStyleList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.EffectStyleList();
      value.EffectStyle = GetEffectStyle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.EffectStyleList? openXmlElement, DMDraws.EffectStyleList? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.EffectStyleList value)
    where OpenXmlElementType: DXDraw.EffectStyleList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.EffectStyleList openXmlElement, DMDraws.EffectStyleList value)
  {
    SetEffectStyle(openXmlElement, value?.EffectStyle);
  }
}
