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
  
  private static bool CmpBlendMode(DXDraw.Blend openXmlElement, DMDraws.BlendMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.BlendModeValues, DMDraws.BlendMode>(openXmlElement?.BlendMode?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.EffectContainerConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.EffectContainer>());
  }
  
  private static bool CmpEffectContainer(DXDraw.Blend openXmlElement, DMDraws.EffectContainer? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.EffectContainerConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.EffectContainer>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXDraw.Blend? openXmlElement, DMDraws.Blend? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBlendMode(openXmlElement, value.BlendMode, diffs, objName))
        ok = false;
      if (!CmpEffectContainer(openXmlElement, value.EffectContainer, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
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
