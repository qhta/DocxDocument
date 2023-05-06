namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Preset geometry.
/// </summary>
public static class PresetGeometryConverter
{
  /// <summary>
  /// Preset Shape
  /// </summary>
  private static DMD.ShapeKind? GetPreset(DXD.PresetGeometry openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ShapeTypeValues, DMD.ShapeKind>(openXmlElement?.Preset?.Value);
  }
  
  private static bool CmpPreset(DXD.PresetGeometry openXmlElement, DMD.ShapeKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.ShapeTypeValues, DMD.ShapeKind>(openXmlElement?.Preset?.Value, value, diffs, objName);
  }
  
  private static void SetPreset(DXD.PresetGeometry openXmlElement, DMD.ShapeKind? value)
  {
    openXmlElement.Preset = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ShapeTypeValues, DMD.ShapeKind>(value);
  }
  
  /// <summary>
  /// List of Shape Adjust Values.
  /// </summary>
  private static DMD.AdjustValueList? GetAdjustValueList(DXD.PresetGeometry openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.AdjustValueList>();
    if (element != null)
      return DMXD.AdjustValueListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAdjustValueList(DXD.PresetGeometry openXmlElement, DMD.AdjustValueList? value, DiffList? diffs, string? objName)
  {
    return DMXD.AdjustValueListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.AdjustValueList>(), value, diffs, objName);
  }
  
  private static void SetAdjustValueList(DXD.PresetGeometry openXmlElement, DMD.AdjustValueList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.AdjustValueList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.AdjustValueListConverter.CreateOpenXmlElement<DXD.AdjustValueList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.PresetGeometry? CreateModelElement(DXD.PresetGeometry? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PresetGeometry();
      value.Preset = GetPreset(openXmlElement);
      value.AdjustValueList = GetAdjustValueList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.PresetGeometry? openXmlElement, DMD.PresetGeometry? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.PresetGeometry value)
    where OpenXmlElementType: DXD.PresetGeometry, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.PresetGeometry openXmlElement, DMD.PresetGeometry value)
  {
    SetPreset(openXmlElement, value?.Preset);
    SetAdjustValueList(openXmlElement, value?.AdjustValueList);
  }
}
