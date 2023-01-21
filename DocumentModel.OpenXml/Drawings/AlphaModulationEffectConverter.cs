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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.EffectContainer>();
    if (itemElement != null)
      return DMXDraws.EffectContainerConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDraws.AlphaModulationEffect? CreateModelElement(DXDraw.AlphaModulationEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.AlphaModulationEffect();
      value.EffectContainer = GetEffectContainer(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.AlphaModulationEffect? value)
    where OpenXmlElementType: DXDraw.AlphaModulationEffect, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEffectContainer(openXmlElement, value?.EffectContainer);
      return openXmlElement;
    }
    return default;
  }
}
