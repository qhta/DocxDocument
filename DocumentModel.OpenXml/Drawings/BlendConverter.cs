namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Blend Effect.
/// </summary>
public static class BlendConverter
{
  /// <summary>
  /// Blend Mode
  /// </summary>
  private static DMD.BlendMode? GetBlendMode(DXD.Blend openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlendModeValues, DMD.BlendMode>(openXmlElement?.BlendMode?.Value);
  }
  
  private static bool CmpBlendMode(DXD.Blend openXmlElement, DMD.BlendMode? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.BlendModeValues, DMD.BlendMode>(openXmlElement?.BlendMode?.Value, value, diffs, objName, propName);
  }
  
  private static void SetBlendMode(DXD.Blend openXmlElement, DMD.BlendMode? value)
  {
    openXmlElement.BlendMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlendModeValues, DMD.BlendMode>(value);
  }
  
  /// <summary>
  /// Effect to blend.
  /// </summary>
  private static DMD.EffectContainer? GetEffectContainer(DXD.Blend openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EffectContainer>();
    if (element != null)
      return DMXD.EffectContainerConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectContainer(DXD.Blend openXmlElement, DMD.EffectContainer? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.EffectContainerConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectContainer>(), value, diffs, objName, propName);
  }
  
  private static void SetEffectContainer(DXD.Blend openXmlElement, DMD.EffectContainer? value)
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
  
  public static DocumentModel.Drawings.Blend? CreateModelElement(DXD.Blend? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Blend();
      value.BlendMode = GetBlendMode(openXmlElement);
      value.EffectContainer = GetEffectContainer(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.Blend? openXmlElement, DMD.Blend? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBlendMode(openXmlElement, value.BlendMode, diffs, objName, propName))
        ok = false;
      if (!CmpEffectContainer(openXmlElement, value.EffectContainer, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Blend value)
    where OpenXmlElementType: DXD.Blend, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Blend openXmlElement, DMD.Blend value)
  {
    SetBlendMode(openXmlElement, value?.BlendMode);
    SetEffectContainer(openXmlElement, value?.EffectContainer);
  }
}
