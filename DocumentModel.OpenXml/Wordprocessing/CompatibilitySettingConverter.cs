namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CompatibilitySetting Class.
/// </summary>
public static class CompatibilitySettingConverter
{
  /// <summary>
  /// name
  /// </summary>
  private static DMW.CompatSettingNameKind? GetName(DXW.CompatibilitySetting openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CompatSettingNameValues, DMW.CompatSettingNameKind>(openXmlElement?.Name?.Value);
  }
  
  private static bool CmpName(DXW.CompatibilitySetting openXmlElement, DMW.CompatSettingNameKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.CompatSettingNameValues, DMW.CompatSettingNameKind>(openXmlElement?.Name?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetName(DXW.CompatibilitySetting openXmlElement, DMW.CompatSettingNameKind? value)
  {
    openXmlElement.Name = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.CompatSettingNameValues, DMW.CompatSettingNameKind>(value);
  }
  
  /// <summary>
  /// uri
  /// </summary>
  private static String? GetUri(DXW.CompatibilitySetting openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXW.CompatibilitySetting openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXW.CompatibilitySetting openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// val
  /// </summary>
  private static String? GetVal(DXW.CompatibilitySetting openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Val);
  }
  
  private static bool CmpVal(DXW.CompatibilitySetting openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Val, value, diffs, objName, "Val");
  }
  
  private static void SetVal(DXW.CompatibilitySetting openXmlElement, String? value)
  {
    openXmlElement.Val = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Wordprocessing.CompatibilitySetting? CreateModelElement(DXW.CompatibilitySetting? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.CompatibilitySetting();
      value.Name = GetName(openXmlElement);
      value.Uri = GetUri(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.CompatibilitySetting? openXmlElement, DMW.CompatibilitySetting? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.CompatibilitySetting value)
    where OpenXmlElementType: DXW.CompatibilitySetting, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.CompatibilitySetting openXmlElement, DMW.CompatibilitySetting value)
  {
    SetName(openXmlElement, value?.Name);
    SetUri(openXmlElement, value?.Uri);
    SetVal(openXmlElement, value?.Val);
  }
}
