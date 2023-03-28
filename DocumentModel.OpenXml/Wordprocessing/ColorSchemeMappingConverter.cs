namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Theme Color Mappings converter from/to OpenXml.
///</summary>
public static class ColorSchemeMappingConverter
{
  /// <summary>
  /// Background 1 Theme Color Mapping
  /// </summary>
  private static DMW.ColorSchemeIndexKind? GetBackground1(DXW.ColorSchemeMapping openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Background1?.Value);
  }
  
  private static bool CmpBackground1(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Background1?.Value, value, diffs, objName);
  }
  
  private static void SetBackground1(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value)
  {
    openXmlElement.Background1 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Text 1 Theme Color Mapping
  /// </summary>
  private static DMW.ColorSchemeIndexKind? GetText1(DXW.ColorSchemeMapping openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Text1?.Value);
  }
  
  private static bool CmpText1(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Text1?.Value, value, diffs, objName);
  }
  
  private static void SetText1(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value)
  {
    openXmlElement.Text1 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Background 2 Theme Color Mapping
  /// </summary>
  private static DMW.ColorSchemeIndexKind? GetBackground2(DXW.ColorSchemeMapping openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Background2?.Value);
  }
  
  private static bool CmpBackground2(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Background2?.Value, value, diffs, objName);
  }
  
  private static void SetBackground2(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value)
  {
    openXmlElement.Background2 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Text 2 Theme Color Mapping
  /// </summary>
  private static DMW.ColorSchemeIndexKind? GetText2(DXW.ColorSchemeMapping openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Text2?.Value);
  }
  
  private static bool CmpText2(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Text2?.Value, value, diffs, objName);
  }
  
  private static void SetText2(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value)
  {
    openXmlElement.Text2 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 1 Theme Color Mapping
  /// </summary>
  private static DMW.ColorSchemeIndexKind? GetAccent1(DXW.ColorSchemeMapping openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Accent1?.Value);
  }
  
  private static bool CmpAccent1(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Accent1?.Value, value, diffs, objName);
  }
  
  private static void SetAccent1(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent1 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 2 Theme Color Mapping
  /// </summary>
  private static DMW.ColorSchemeIndexKind? GetAccent2(DXW.ColorSchemeMapping openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Accent2?.Value);
  }
  
  private static bool CmpAccent2(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Accent2?.Value, value, diffs, objName);
  }
  
  private static void SetAccent2(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent2 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent3 Theme Color Mapping
  /// </summary>
  private static DMW.ColorSchemeIndexKind? GetAccent3(DXW.ColorSchemeMapping openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Accent3?.Value);
  }
  
  private static bool CmpAccent3(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Accent3?.Value, value, diffs, objName);
  }
  
  private static void SetAccent3(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent3 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent4 Theme Color Mapping
  /// </summary>
  private static DMW.ColorSchemeIndexKind? GetAccent4(DXW.ColorSchemeMapping openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Accent4?.Value);
  }
  
  private static bool CmpAccent4(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Accent4?.Value, value, diffs, objName);
  }
  
  private static void SetAccent4(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent4 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent5 Theme Color Mapping
  /// </summary>
  private static DMW.ColorSchemeIndexKind? GetAccent5(DXW.ColorSchemeMapping openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Accent5?.Value);
  }
  
  private static bool CmpAccent5(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Accent5?.Value, value, diffs, objName);
  }
  
  private static void SetAccent5(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent5 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent6 Theme Color Mapping
  /// </summary>
  private static DMW.ColorSchemeIndexKind? GetAccent6(DXW.ColorSchemeMapping openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Accent6?.Value);
  }
  
  private static bool CmpAccent6(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Accent6?.Value, value, diffs, objName);
  }
  
  private static void SetAccent6(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent6 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Hyperlink Theme Color Mapping
  /// </summary>
  private static DMW.ColorSchemeIndexKind? GetHyperlink(DXW.ColorSchemeMapping openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Hyperlink?.Value);
  }
  
  private static bool CmpHyperlink(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Hyperlink?.Value, value, diffs, objName);
  }
  
  private static void SetHyperlink(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value)
  {
    openXmlElement.Hyperlink = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Followed Hyperlink Theme Color Mapping
  /// </summary>
  private static DMW.ColorSchemeIndexKind? GetFollowedHyperlink(DXW.ColorSchemeMapping openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.FollowedHyperlink?.Value);
  }
  
  private static bool CmpFollowedHyperlink(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.FollowedHyperlink?.Value, value, diffs, objName);
  }
  
  private static void SetFollowedHyperlink(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value)
  {
    openXmlElement.FollowedHyperlink = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(value);
  }
  
  public static DMW.ColorSchemeMapping? CreateModelElement(DXW.ColorSchemeMapping? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.ColorSchemeMapping();
      value.Background1 = GetBackground1(openXmlElement);
      value.Text1 = GetText1(openXmlElement);
      value.Background2 = GetBackground2(openXmlElement);
      value.Text2 = GetText2(openXmlElement);
      value.Accent1 = GetAccent1(openXmlElement);
      value.Accent2 = GetAccent2(openXmlElement);
      value.Accent3 = GetAccent3(openXmlElement);
      value.Accent4 = GetAccent4(openXmlElement);
      value.Accent5 = GetAccent5(openXmlElement);
      value.Accent6 = GetAccent6(openXmlElement);
      value.Hyperlink = GetHyperlink(openXmlElement);
      value.FollowedHyperlink = GetFollowedHyperlink(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.ColorSchemeMapping? openXmlElement, DMW.ColorSchemeMapping? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBackground1(openXmlElement, value.Background1, diffs, objName))
        ok = false;
      if (!CmpText1(openXmlElement, value.Text1, diffs, objName))
        ok = false;
      if (!CmpBackground2(openXmlElement, value.Background2, diffs, objName))
        ok = false;
      if (!CmpText2(openXmlElement, value.Text2, diffs, objName))
        ok = false;
      if (!CmpAccent1(openXmlElement, value.Accent1, diffs, objName))
        ok = false;
      if (!CmpAccent2(openXmlElement, value.Accent2, diffs, objName))
        ok = false;
      if (!CmpAccent3(openXmlElement, value.Accent3, diffs, objName))
        ok = false;
      if (!CmpAccent4(openXmlElement, value.Accent4, diffs, objName))
        ok = false;
      if (!CmpAccent5(openXmlElement, value.Accent5, diffs, objName))
        ok = false;
      if (!CmpAccent6(openXmlElement, value.Accent6, diffs, objName))
        ok = false;
      if (!CmpHyperlink(openXmlElement, value.Hyperlink, diffs, objName))
        ok = false;
      if (!CmpFollowedHyperlink(openXmlElement, value.FollowedHyperlink, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.ColorSchemeMapping value)
    where OpenXmlElementType: DXW.ColorSchemeMapping, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeMapping value)
  {
    SetBackground1(openXmlElement, value?.Background1);
    SetText1(openXmlElement, value?.Text1);
    SetBackground2(openXmlElement, value?.Background2);
    SetText2(openXmlElement, value?.Text2);
    SetAccent1(openXmlElement, value?.Accent1);
    SetAccent2(openXmlElement, value?.Accent2);
    SetAccent3(openXmlElement, value?.Accent3);
    SetAccent4(openXmlElement, value?.Accent4);
    SetAccent5(openXmlElement, value?.Accent5);
    SetAccent6(openXmlElement, value?.Accent6);
    SetHyperlink(openXmlElement, value?.Hyperlink);
    SetFollowedHyperlink(openXmlElement, value?.FollowedHyperlink);
  }
}
