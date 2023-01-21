namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Blend Effect.
/// </summary>
public static class BlendConverter
{
  /// <summary>
  /// Blend Mode
  /// </summary>
  private static DMDraws.BlendMode? GetBlendMode(DXDraw.Blend openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlendModeValues, DMDraws.BlendMode>(openXmlElement?.BlendMode?.Value);
  }
  
  private static void SetBlendMode(DXDraw.Blend openXmlElement, DMDraws.BlendMode? value)
  {
    openXmlElement.BlendMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlendModeValues, DMDraws.BlendMode>(value);
  }
  
  /// <summary>
  /// Effect to blend.
  /// </summary>
  private static DMDraws.EffectContainer? GetEffectContainer(DXDraw.Blend openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.EffectContainer>();
    if (itemElement != null)
      return DMXDraws.EffectContainerConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEffectContainer(DXDraw.Blend openXmlElement, DMDraws.EffectContainer? value)
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
  
  public static DMDraws.Blend? CreateModelElement(DXDraw.Blend? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Blend();
      value.BlendMode = GetBlendMode(openXmlElement);
      value.EffectContainer = GetEffectContainer(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Blend? value)
    where OpenXmlElementType: DXDraw.Blend, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBlendMode(openXmlElement, value?.BlendMode);
      SetEffectContainer(openXmlElement, value?.EffectContainer);
      return openXmlElement;
    }
    return default;
  }
}
