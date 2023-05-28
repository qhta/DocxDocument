namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BackgroundProperties Class.
/// </summary>
public static class BackgroundPropertiesConverter
{
  /// <summary>
  /// bwMode, this property is only available in Office 2013 and later.
  /// </summary>
  private static DMD.BlackWhiteMode? GetMode(DXO13D.BackgroundProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMD.BlackWhiteMode>(openXmlElement?.Mode?.Value);
  }
  
  private static bool CmpMode(DXO13D.BackgroundProperties openXmlElement, DMD.BlackWhiteMode? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMD.BlackWhiteMode>(openXmlElement?.Mode?.Value, value, diffs, objName, propName);
  }
  
  private static void SetMode(DXO13D.BackgroundProperties openXmlElement, DMD.BlackWhiteMode? value)
  {
    openXmlElement.Mode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMD.BlackWhiteMode>(value);
  }
  
  /// <summary>
  /// bwPure, this property is only available in Office 2013 and later.
  /// </summary>
  private static DMD.BlackWhiteMode? GetPure(DXO13D.BackgroundProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMD.BlackWhiteMode>(openXmlElement?.Pure?.Value);
  }
  
  private static bool CmpPure(DXO13D.BackgroundProperties openXmlElement, DMD.BlackWhiteMode? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMD.BlackWhiteMode>(openXmlElement?.Pure?.Value, value, diffs, objName, propName);
  }
  
  private static void SetPure(DXO13D.BackgroundProperties openXmlElement, DMD.BlackWhiteMode? value)
  {
    openXmlElement.Pure = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMD.BlackWhiteMode>(value);
  }
  
  /// <summary>
  /// bwNormal, this property is only available in Office 2013 and later.
  /// </summary>
  private static DMD.BlackWhiteMode? GetNormal(DXO13D.BackgroundProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMD.BlackWhiteMode>(openXmlElement?.Normal?.Value);
  }
  
  private static bool CmpNormal(DXO13D.BackgroundProperties openXmlElement, DMD.BlackWhiteMode? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMD.BlackWhiteMode>(openXmlElement?.Normal?.Value, value, diffs, objName, propName);
  }
  
  private static void SetNormal(DXO13D.BackgroundProperties openXmlElement, DMD.BlackWhiteMode? value)
  {
    openXmlElement.Normal = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMD.BlackWhiteMode>(value);
  }
  
  /// <summary>
  /// targetScreenSize, this property is only available in Office 2013 and later.
  /// </summary>
  private static DMD.TargetScreenSize? GetTargetScreenSize(DXO13D.BackgroundProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2013.Drawing.TargetScreenSize, DMD.TargetScreenSize>(openXmlElement?.TargetScreenSize?.Value);
  }
  
  private static bool CmpTargetScreenSize(DXO13D.BackgroundProperties openXmlElement, DMD.TargetScreenSize? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2013.Drawing.TargetScreenSize, DMD.TargetScreenSize>(openXmlElement?.TargetScreenSize?.Value, value, diffs, objName, propName);
  }
  
  private static void SetTargetScreenSize(DXO13D.BackgroundProperties openXmlElement, DMD.TargetScreenSize? value)
  {
    openXmlElement.TargetScreenSize = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2013.Drawing.TargetScreenSize, DMD.TargetScreenSize>(value);
  }
  
  public static DMD.BackgroundProperties? CreateModelElement(DXO13D.BackgroundProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.BackgroundProperties();
      value.Mode = GetMode(openXmlElement);
      value.Pure = GetPure(openXmlElement);
      value.Normal = GetNormal(openXmlElement);
      value.TargetScreenSize = GetTargetScreenSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13D.BackgroundProperties? openXmlElement, DMD.BackgroundProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMode(openXmlElement, value.Mode, diffs, objName, propName))
        ok = false;
      if (!CmpPure(openXmlElement, value.Pure, diffs, objName, propName))
        ok = false;
      if (!CmpNormal(openXmlElement, value.Normal, diffs, objName, propName))
        ok = false;
      if (!CmpTargetScreenSize(openXmlElement, value.TargetScreenSize, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.BackgroundProperties value)
    where OpenXmlElementType: DXO13D.BackgroundProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13D.BackgroundProperties openXmlElement, DMD.BackgroundProperties value)
  {
    SetMode(openXmlElement, value?.Mode);
    SetPure(openXmlElement, value?.Pure);
    SetNormal(openXmlElement, value?.Normal);
    SetTargetScreenSize(openXmlElement, value?.TargetScreenSize);
  }
}
