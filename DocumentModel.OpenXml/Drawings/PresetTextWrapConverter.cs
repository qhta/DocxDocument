namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Preset Text Warp.
/// </summary>
public static class PresetTextWrapConverter
{
  /// <summary>
  /// Preset Warp Shape
  /// </summary>
  private static DMDraws.TextShapeKind? GetPreset(DXDraw.PresetTextWrap openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextShapeValues, DMDraws.TextShapeKind>(openXmlElement?.Preset?.Value);
  }
  
  private static bool CmpPreset(DXDraw.PresetTextWrap openXmlElement, DMDraws.TextShapeKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextShapeValues, DMDraws.TextShapeKind>(openXmlElement?.Preset?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPreset(DXDraw.PresetTextWrap openXmlElement, DMDraws.TextShapeKind? value)
  {
    openXmlElement.Preset = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextShapeValues, DMDraws.TextShapeKind>(value);
  }
  
  /// <summary>
  /// Adjust Value List.
  /// </summary>
  private static DMDraws.AdjustValueList? GetAdjustValueList(DXDraw.PresetTextWrap openXmlElement)
  {
    return DMXDraws.AdjustValueListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.AdjustValueList>());
  }
  
  private static bool CmpAdjustValueList(DXDraw.PresetTextWrap openXmlElement, DMDraws.AdjustValueList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.AdjustValueListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.AdjustValueList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAdjustValueList(DXDraw.PresetTextWrap openXmlElement, DMDraws.AdjustValueList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.AdjustValueList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.AdjustValueListConverter.CreateOpenXmlElement<DXDraw.AdjustValueList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.PresetTextWrap? CreateModelElement(DXDraw.PresetTextWrap? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.PresetTextWrap();
      value.Preset = GetPreset(openXmlElement);
      value.AdjustValueList = GetAdjustValueList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.PresetTextWrap? openXmlElement, DMDraws.PresetTextWrap? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPreset(openXmlElement, value.Preset, diffs, objName))
        ok = false;
      if (!CmpAdjustValueList(openXmlElement, value.AdjustValueList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.PresetTextWrap? value)
    where OpenXmlElementType: DXDraw.PresetTextWrap, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPreset(openXmlElement, value?.Preset);
      SetAdjustValueList(openXmlElement, value?.AdjustValueList);
      return openXmlElement;
    }
    return default;
  }
}
