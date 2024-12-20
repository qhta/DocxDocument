namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Alpha Modulate Effect.
/// </summary>
public static class AlphaModulationEffectConverter
{
  /// <summary>
  /// EffectContainer.
  /// </summary>
  private static DMD.EffectContainer? GetEffectContainer(DXD.AlphaModulationEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EffectContainer>();
    if (element != null)
      return DMXD.EffectContainerConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectContainer(DXD.AlphaModulationEffect openXmlElement, DMD.EffectContainer? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.EffectContainerConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectContainer>(), value, diffs, objName, propName);
  }
  
  private static void SetEffectContainer(DXD.AlphaModulationEffect openXmlElement, DMD.EffectContainer? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.EffectContainer>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.EffectContainerConverter.CreateOpenXmlElement<DXD.EffectContainer>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.AlphaModulationEffect? CreateModelElement(DXD.AlphaModulationEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.AlphaModulationEffect();
      value.EffectContainer = GetEffectContainer(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.AlphaModulationEffect? openXmlElement, DMD.AlphaModulationEffect? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEffectContainer(openXmlElement, value.EffectContainer, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.AlphaModulationEffect value)
    where OpenXmlElementType: DXD.AlphaModulationEffect, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.AlphaModulationEffect openXmlElement, DMD.AlphaModulationEffect value)
  {
    SetEffectContainer(openXmlElement, value?.EffectContainer);
  }
}
