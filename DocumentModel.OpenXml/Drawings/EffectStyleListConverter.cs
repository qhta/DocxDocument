namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Effect Style List.
/// </summary>
public static class EffectStyleListConverter
{
  private static DMDraws.EffectStyle? GetEffectStyle(DXDraw.EffectStyleList openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.EffectStyle>();
    if (itemElement != null)
      return DMXDraws.EffectStyleConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDraws.EffectStyleList? CreateModelElement(DXDraw.EffectStyleList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.EffectStyleList();
      value.EffectStyle = GetEffectStyle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.EffectStyleList? value)
    where OpenXmlElementType: DXDraw.EffectStyleList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEffectStyle(openXmlElement, value?.EffectStyle);
      return openXmlElement;
    }
    return default;
  }
}
