namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BackgroundProperties Class.
/// </summary>
public static class BackgroundPropertiesConverter
{
  /// <summary>
  /// bwMode, this property is only available in Office 2013 and later.
  /// </summary>
  private static DMDraws.BlackWhiteMode? GetMode(DXO2013Draw.BackgroundProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMDraws.BlackWhiteMode>(openXmlElement?.Mode?.Value);
  }
  
  private static bool CmpMode(DXO2013Draw.BackgroundProperties openXmlElement, DMDraws.BlackWhiteMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMDraws.BlackWhiteMode>(openXmlElement?.Mode?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMode(DXO2013Draw.BackgroundProperties openXmlElement, DMDraws.BlackWhiteMode? value)
  {
    openXmlElement.Mode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMDraws.BlackWhiteMode>(value);
  }
  
  /// <summary>
  /// bwPure, this property is only available in Office 2013 and later.
  /// </summary>
  private static DMDraws.BlackWhiteMode? GetPure(DXO2013Draw.BackgroundProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMDraws.BlackWhiteMode>(openXmlElement?.Pure?.Value);
  }
  
  private static bool CmpPure(DXO2013Draw.BackgroundProperties openXmlElement, DMDraws.BlackWhiteMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMDraws.BlackWhiteMode>(openXmlElement?.Pure?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPure(DXO2013Draw.BackgroundProperties openXmlElement, DMDraws.BlackWhiteMode? value)
  {
    openXmlElement.Pure = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMDraws.BlackWhiteMode>(value);
  }
  
  /// <summary>
  /// bwNormal, this property is only available in Office 2013 and later.
  /// </summary>
  private static DMDraws.BlackWhiteMode? GetNormal(DXO2013Draw.BackgroundProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMDraws.BlackWhiteMode>(openXmlElement?.Normal?.Value);
  }
  
  private static bool CmpNormal(DXO2013Draw.BackgroundProperties openXmlElement, DMDraws.BlackWhiteMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMDraws.BlackWhiteMode>(openXmlElement?.Normal?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNormal(DXO2013Draw.BackgroundProperties openXmlElement, DMDraws.BlackWhiteMode? value)
  {
    openXmlElement.Normal = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMDraws.BlackWhiteMode>(value);
  }
  
  /// <summary>
  /// targetScreenSize, this property is only available in Office 2013 and later.
  /// </summary>
  private static DMDraws.TargetScreenSize? GetTargetScreenSize(DXO2013Draw.BackgroundProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2013.Drawing.TargetScreenSize, DMDraws.TargetScreenSize>(openXmlElement?.TargetScreenSize?.Value);
  }
  
  private static bool CmpTargetScreenSize(DXO2013Draw.BackgroundProperties openXmlElement, DMDraws.TargetScreenSize? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2013.Drawing.TargetScreenSize, DMDraws.TargetScreenSize>(openXmlElement?.TargetScreenSize?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTargetScreenSize(DXO2013Draw.BackgroundProperties openXmlElement, DMDraws.TargetScreenSize? value)
  {
    openXmlElement.TargetScreenSize = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2013.Drawing.TargetScreenSize, DMDraws.TargetScreenSize>(value);
  }
  
  public static DMDraws.BackgroundProperties? CreateModelElement(DXO2013Draw.BackgroundProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.BackgroundProperties();
      value.Mode = GetMode(openXmlElement);
      value.Pure = GetPure(openXmlElement);
      value.Normal = GetNormal(openXmlElement);
      value.TargetScreenSize = GetTargetScreenSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013Draw.BackgroundProperties? openXmlElement, DMDraws.BackgroundProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMode(openXmlElement, value.Mode, diffs, objName))
        ok = false;
      if (!CmpPure(openXmlElement, value.Pure, diffs, objName))
        ok = false;
      if (!CmpNormal(openXmlElement, value.Normal, diffs, objName))
        ok = false;
      if (!CmpTargetScreenSize(openXmlElement, value.TargetScreenSize, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.BackgroundProperties? value)
    where OpenXmlElementType: DXO2013Draw.BackgroundProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMode(openXmlElement, value?.Mode);
      SetPure(openXmlElement, value?.Pure);
      SetNormal(openXmlElement, value?.Normal);
      SetTargetScreenSize(openXmlElement, value?.TargetScreenSize);
      return openXmlElement;
    }
    return default;
  }
}
