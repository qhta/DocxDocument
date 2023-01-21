namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the HiddenEffectsProperties Class.
/// </summary>
public static class HiddenEffectsPropertiesConverter
{
  /// <summary>
  /// Effect Container.
  /// </summary>
  private static DMDraws.EffectList? GetEffectList(DXO2010Draw.HiddenEffectsProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.EffectList>();
    if (itemElement != null)
      return DMXDraws.EffectListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEffectList(DXO2010Draw.HiddenEffectsProperties openXmlElement, DMDraws.EffectList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.EffectList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.EffectListConverter.CreateOpenXmlElement<DXDraw.EffectList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Effect Container.
  /// </summary>
  private static DMDraws.EffectDag? GetEffectDag(DXO2010Draw.HiddenEffectsProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.EffectDag>();
    if (itemElement != null)
      return DMXDraws.EffectDagConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEffectDag(DXO2010Draw.HiddenEffectsProperties openXmlElement, DMDraws.EffectDag? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.EffectDag>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.EffectDagConverter.CreateOpenXmlElement<DXDraw.EffectDag>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.HiddenEffectsProperties? CreateModelElement(DXO2010Draw.HiddenEffectsProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.HiddenEffectsProperties();
      value.EffectList = GetEffectList(openXmlElement);
      value.EffectDag = GetEffectDag(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.HiddenEffectsProperties? value)
    where OpenXmlElementType: DXO2010Draw.HiddenEffectsProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEffectList(openXmlElement, value?.EffectList);
      SetEffectDag(openXmlElement, value?.EffectDag);
      return openXmlElement;
    }
    return default;
  }
}
