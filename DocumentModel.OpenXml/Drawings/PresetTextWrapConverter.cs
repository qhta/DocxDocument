namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Preset Text Warp.
/// </summary>
public static class PresetTextWrapConverter
{
  /// <summary>
  /// Preset Warp Shape
  /// </summary>
  private static DMD.TextShapeKind? GetPreset(DXD.PresetTextWrap openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextShapeValues, DMD.TextShapeKind>(openXmlElement?.Preset?.Value);
  }
  
  private static bool CmpPreset(DXD.PresetTextWrap openXmlElement, DMD.TextShapeKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextShapeValues, DMD.TextShapeKind>(openXmlElement?.Preset?.Value, value, diffs, objName);
  }
  
  private static void SetPreset(DXD.PresetTextWrap openXmlElement, DMD.TextShapeKind? value)
  {
    openXmlElement.Preset = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextShapeValues, DMD.TextShapeKind>(value);
  }
  
  /// <summary>
  /// Adjust Value List.
  /// </summary>
  private static DMD.AdjustValueList? GetAdjustValueList(DXD.PresetTextWrap openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.AdjustValueList>();
    if (element != null)
      return DMXD.AdjustValueListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAdjustValueList(DXD.PresetTextWrap openXmlElement, DMD.AdjustValueList? value, DiffList? diffs, string? objName)
  {
    return DMXD.AdjustValueListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.AdjustValueList>(), value, diffs, objName);
  }
  
  private static void SetAdjustValueList(DXD.PresetTextWrap openXmlElement, DMD.AdjustValueList? value)
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
  
  public static DocumentModel.Drawings.PresetTextWrap? CreateModelElement(DXD.PresetTextWrap? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PresetTextWrap();
      value.Preset = GetPreset(openXmlElement);
      value.AdjustValueList = GetAdjustValueList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.PresetTextWrap? openXmlElement, DMD.PresetTextWrap? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.PresetTextWrap value)
    where OpenXmlElementType: DXD.PresetTextWrap, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.PresetTextWrap openXmlElement, DMD.PresetTextWrap value)
  {
    SetPreset(openXmlElement, value?.Preset);
    SetAdjustValueList(openXmlElement, value?.AdjustValueList);
  }
}
