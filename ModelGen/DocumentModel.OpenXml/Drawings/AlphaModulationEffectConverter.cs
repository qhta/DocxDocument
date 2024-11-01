namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Alpha Modulate Effect.
/// </summary>
public static class AlphaModulationEffectConverter
{
  /// <summary>
  /// EffectContainer.
  /// </summary>
  private static DMDraws.EffectContainer? GetEffectContainer(DXDraw.AlphaModulationEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.EffectContainer>();
    if (element != null)
      return DMXDraws.EffectContainerConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectContainer(DXDraw.AlphaModulationEffect openXmlElement, DMDraws.EffectContainer? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.EffectContainerConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.EffectContainer>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEffectContainer(DXDraw.AlphaModulationEffect openXmlElement, DMDraws.EffectContainer? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.EffectContainer>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.EffectContainerConverter.CreateOpenXmlElement<DXDraw.EffectContainer>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.AlphaModulationEffect? CreateModelElement(DXDraw.AlphaModulationEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AlphaModulationEffect();
      value.EffectContainer = GetEffectContainer(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.AlphaModulationEffect? openXmlElement, DMDraws.AlphaModulationEffect? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEffectContainer(openXmlElement, value.EffectContainer, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.AlphaModulationEffect value)
    where OpenXmlElementType: DXDraw.AlphaModulationEffect, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.AlphaModulationEffect openXmlElement, DMDraws.AlphaModulationEffect value)
  {
    SetEffectContainer(openXmlElement, value?.EffectContainer);
  }
}
