namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the BevelType Class.
/// </summary>
public static class BevelTypeConverter
{
  /// <summary>
  /// w, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetWidth(DXO2010W.BevelType openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  private static bool CmpWidth(DXO2010W.BevelType openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Width?.Value == value) return true;
    diffs?.Add(objName, "Width", openXmlElement?.Width?.Value, value);
    return false;
  }
  
  private static void SetWidth(DXO2010W.BevelType openXmlElement, Int64? value)
  {
    openXmlElement.Width = value;
  }
  
  /// <summary>
  /// h, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetHeight(DXO2010W.BevelType openXmlElement)
  {
    return openXmlElement?.Height?.Value;
  }
  
  private static bool CmpHeight(DXO2010W.BevelType openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Height?.Value == value) return true;
    diffs?.Add(objName, "Height", openXmlElement?.Height?.Value, value);
    return false;
  }
  
  private static void SetHeight(DXO2010W.BevelType openXmlElement, Int64? value)
  {
    openXmlElement.Height = value;
  }
  
  /// <summary>
  /// prst, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMW.BevelPresetKind? GetPresetProfileType(DXO2010W.BevelType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.BevelPresetTypeValues, DMW.BevelPresetKind>(openXmlElement?.PresetProfileType?.Value);
  }
  
  private static bool CmpPresetProfileType(DXO2010W.BevelType openXmlElement, DMW.BevelPresetKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.BevelPresetTypeValues, DMW.BevelPresetKind>(openXmlElement?.PresetProfileType?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPresetProfileType(DXO2010W.BevelType openXmlElement, DMW.BevelPresetKind? value)
  {
    openXmlElement.PresetProfileType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.BevelPresetTypeValues, DMW.BevelPresetKind>(value);
  }
  
  public static DocumentModel.Wordprocessing.BevelType? CreateModelElement(DXO2010W.BevelType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.BevelType();
      value.Width = GetWidth(openXmlElement);
      value.Height = GetHeight(openXmlElement);
      value.PresetProfileType = GetPresetProfileType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010W.BevelType? openXmlElement, DMW.BevelType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpWidth(openXmlElement, value.Width, diffs, objName))
        ok = false;
      if (!CmpHeight(openXmlElement, value.Height, diffs, objName))
        ok = false;
      if (!CmpPresetProfileType(openXmlElement, value.PresetProfileType, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.BevelType value)
    where OpenXmlElementType: DXO2010W.BevelType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010W.BevelType openXmlElement, DMW.BevelType value)
  {
    SetWidth(openXmlElement, value?.Width);
    SetHeight(openXmlElement, value?.Height);
    SetPresetProfileType(openXmlElement, value?.PresetProfileType);
  }
}
