namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the HiddenEffectsProperties Class converter from/to OpenXml.
///</summary>
public static class HiddenEffectsPropertiesConverter
{
  /// <summary>
  /// Effect Container.
  /// </summary>
  private static DMDraws.EffectList? GetEffectList(DXO2010Draw.HiddenEffectsProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.EffectList>();
    if (element != null)
      return DMXDraws.EffectListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectList(DXO2010Draw.HiddenEffectsProperties openXmlElement, DMDraws.EffectList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.EffectListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.EffectList>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXDraw.EffectDag>();
    if (element != null)
      return DMXDraws.EffectDagConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectDag(DXO2010Draw.HiddenEffectsProperties openXmlElement, DMDraws.EffectDag? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.EffectDagConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.EffectDag>(), value, diffs, objName);
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
  
  public static DocumentModel.Drawings.HiddenEffectsProperties? CreateModelElement(DXO2010Draw.HiddenEffectsProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.HiddenEffectsProperties();
      value.EffectList = GetEffectList(openXmlElement);
      value.EffectDag = GetEffectDag(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010Draw.HiddenEffectsProperties? openXmlElement, DMDraws.HiddenEffectsProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEffectList(openXmlElement, value.EffectList, diffs, objName))
        ok = false;
      if (!CmpEffectDag(openXmlElement, value.EffectDag, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.HiddenEffectsProperties value)
    where OpenXmlElementType: DXO2010Draw.HiddenEffectsProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010Draw.HiddenEffectsProperties openXmlElement, DMDraws.HiddenEffectsProperties value)
  {
    SetEffectList(openXmlElement, value?.EffectList);
    SetEffectDag(openXmlElement, value?.EffectDag);
  }
}
