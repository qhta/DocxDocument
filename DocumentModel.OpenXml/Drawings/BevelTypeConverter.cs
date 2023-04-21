namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BevelType Class.
/// </summary>
public static class BevelTypeConverter
{
  /// <summary>
  /// Width
  /// </summary>
  private static Int64? GetWidth(DXD.BevelType openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  private static bool CmpWidth(DXD.BevelType openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Width?.Value == value) return true;
    diffs?.Add(objName, "Value", openXmlElement?.Width?.Value, value);
    return false;
  }
  
  private static void SetWidth(DXD.BevelType openXmlElement, Int64? value)
  {
    openXmlElement.Width = value;
  }
  
  /// <summary>
  /// Height
  /// </summary>
  private static Int64? GetHeight(DXD.BevelType openXmlElement)
  {
    return openXmlElement?.Height?.Value;
  }
  
  private static bool CmpHeight(DXD.BevelType openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Height?.Value == value) return true;
    diffs?.Add(objName, "Height", openXmlElement?.Height?.Value, value);
    return false;
  }
  
  private static void SetHeight(DXD.BevelType openXmlElement, Int64? value)
  {
    openXmlElement.Height = value;
  }
  
  /// <summary>
  /// Preset Bevel
  /// </summary>
  private static DMD.BevelPresetKind? GetPreset(DXD.BevelType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BevelPresetValues, DMD.BevelPresetKind>(openXmlElement?.Preset?.Value);
  }
  
  private static bool CmpPreset(DXD.BevelType openXmlElement, DMD.BevelPresetKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.BevelPresetValues, DMD.BevelPresetKind>(openXmlElement?.Preset?.Value, value, diffs, objName);
  }
  
  private static void SetPreset(DXD.BevelType openXmlElement, DMD.BevelPresetKind? value)
  {
    openXmlElement.Preset = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BevelPresetValues, DMD.BevelPresetKind>(value);
  }
  
  public static DocumentModel.Drawings.BevelType? CreateModelElement(DXD.BevelType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.BevelType();
      value.Width = GetWidth(openXmlElement);
      value.Height = GetHeight(openXmlElement);
      value.Preset = GetPreset(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.BevelType? openXmlElement, DMD.BevelType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpWidth(openXmlElement, value.Width, diffs, objName))
        ok = false;
      if (!CmpHeight(openXmlElement, value.Height, diffs, objName))
        ok = false;
      if (!CmpPreset(openXmlElement, value.Preset, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.BevelType value)
    where OpenXmlElementType: DXD.BevelType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.BevelType openXmlElement, DMD.BevelType value)
  {
    SetWidth(openXmlElement, value?.Width);
    SetHeight(openXmlElement, value?.Height);
    SetPreset(openXmlElement, value?.Preset);
  }
}
