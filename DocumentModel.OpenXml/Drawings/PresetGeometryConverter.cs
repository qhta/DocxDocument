namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Preset geometry.
/// </summary>
public static class PresetGeometryConverter
{
  /// <summary>
  /// Preset Shape
  /// </summary>
  private static DMDraws.ShapeKind? GetPreset(DXDraw.PresetGeometry openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ShapeTypeValues, DMDraws.ShapeKind>(openXmlElement?.Preset?.Value);
  }
  
  private static bool CmpPreset(DXDraw.PresetGeometry openXmlElement, DMDraws.ShapeKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.ShapeTypeValues, DMDraws.ShapeKind>(openXmlElement?.Preset?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPreset(DXDraw.PresetGeometry openXmlElement, DMDraws.ShapeKind? value)
  {
    openXmlElement.Preset = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ShapeTypeValues, DMDraws.ShapeKind>(value);
  }
  
  /// <summary>
  /// List of Shape Adjust Values.
  /// </summary>
  private static DMDraws.AdjustValueList? GetAdjustValueList(DXDraw.PresetGeometry openXmlElement)
  {
    return DMXDraws.AdjustValueListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.AdjustValueList>());
  }
  
  private static bool CmpAdjustValueList(DXDraw.PresetGeometry openXmlElement, DMDraws.AdjustValueList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.AdjustValueListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.AdjustValueList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAdjustValueList(DXDraw.PresetGeometry openXmlElement, DMDraws.AdjustValueList? value)
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
  
  public static DMDraws.PresetGeometry? CreateModelElement(DXDraw.PresetGeometry? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.PresetGeometry();
      value.Preset = GetPreset(openXmlElement);
      value.AdjustValueList = GetAdjustValueList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.PresetGeometry? openXmlElement, DMDraws.PresetGeometry? value, DiffList? diffs, string? objName)
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
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.PresetGeometry? value)
    where OpenXmlElementType: DXDraw.PresetGeometry, new()
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
