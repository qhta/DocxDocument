namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ColorMappingType Class.
/// </summary>
public static class ColorMappingTypeConverter
{
  /// <summary>
  /// Background 1
  /// </summary>
  private static DMD.ColorSchemeIndexKind? GetBackground1(DXD.ColorMappingType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(openXmlElement?.Background1?.Value);
  }
  
  private static bool CmpBackground1(DXD.ColorMappingType openXmlElement, DMD.ColorSchemeIndexKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(openXmlElement?.Background1?.Value, value, diffs, objName, propName);
  }
  
  private static void SetBackground1(DXD.ColorMappingType openXmlElement, DMD.ColorSchemeIndexKind? value)
  {
    openXmlElement.Background1 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Text 1
  /// </summary>
  private static DMD.ColorSchemeIndexKind? GetText1(DXD.ColorMappingType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(openXmlElement?.Text1?.Value);
  }
  
  private static bool CmpText1(DXD.ColorMappingType openXmlElement, DMD.ColorSchemeIndexKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(openXmlElement?.Text1?.Value, value, diffs, objName, propName);
  }
  
  private static void SetText1(DXD.ColorMappingType openXmlElement, DMD.ColorSchemeIndexKind? value)
  {
    openXmlElement.Text1 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Background 2
  /// </summary>
  private static DMD.ColorSchemeIndexKind? GetBackground2(DXD.ColorMappingType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(openXmlElement?.Background2?.Value);
  }
  
  private static bool CmpBackground2(DXD.ColorMappingType openXmlElement, DMD.ColorSchemeIndexKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(openXmlElement?.Background2?.Value, value, diffs, objName, propName);
  }
  
  private static void SetBackground2(DXD.ColorMappingType openXmlElement, DMD.ColorSchemeIndexKind? value)
  {
    openXmlElement.Background2 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Text 2
  /// </summary>
  private static DMD.ColorSchemeIndexKind? GetText2(DXD.ColorMappingType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(openXmlElement?.Text2?.Value);
  }
  
  private static bool CmpText2(DXD.ColorMappingType openXmlElement, DMD.ColorSchemeIndexKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(openXmlElement?.Text2?.Value, value, diffs, objName, propName);
  }
  
  private static void SetText2(DXD.ColorMappingType openXmlElement, DMD.ColorSchemeIndexKind? value)
  {
    openXmlElement.Text2 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 1
  /// </summary>
  private static DMD.ColorSchemeIndexKind? GetAccent1(DXD.ColorMappingType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(openXmlElement?.Accent1?.Value);
  }
  
  private static bool CmpAccent1(DXD.ColorMappingType openXmlElement, DMD.ColorSchemeIndexKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(openXmlElement?.Accent1?.Value, value, diffs, objName, propName);
  }
  
  private static void SetAccent1(DXD.ColorMappingType openXmlElement, DMD.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent1 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 2
  /// </summary>
  private static DMD.ColorSchemeIndexKind? GetAccent2(DXD.ColorMappingType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(openXmlElement?.Accent2?.Value);
  }
  
  private static bool CmpAccent2(DXD.ColorMappingType openXmlElement, DMD.ColorSchemeIndexKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(openXmlElement?.Accent2?.Value, value, diffs, objName, propName);
  }
  
  private static void SetAccent2(DXD.ColorMappingType openXmlElement, DMD.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent2 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 3
  /// </summary>
  private static DMD.ColorSchemeIndexKind? GetAccent3(DXD.ColorMappingType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(openXmlElement?.Accent3?.Value);
  }
  
  private static bool CmpAccent3(DXD.ColorMappingType openXmlElement, DMD.ColorSchemeIndexKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(openXmlElement?.Accent3?.Value, value, diffs, objName, propName);
  }
  
  private static void SetAccent3(DXD.ColorMappingType openXmlElement, DMD.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent3 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 4
  /// </summary>
  private static DMD.ColorSchemeIndexKind? GetAccent4(DXD.ColorMappingType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(openXmlElement?.Accent4?.Value);
  }
  
  private static bool CmpAccent4(DXD.ColorMappingType openXmlElement, DMD.ColorSchemeIndexKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(openXmlElement?.Accent4?.Value, value, diffs, objName, propName);
  }
  
  private static void SetAccent4(DXD.ColorMappingType openXmlElement, DMD.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent4 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 5
  /// </summary>
  private static DMD.ColorSchemeIndexKind? GetAccent5(DXD.ColorMappingType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(openXmlElement?.Accent5?.Value);
  }
  
  private static bool CmpAccent5(DXD.ColorMappingType openXmlElement, DMD.ColorSchemeIndexKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(openXmlElement?.Accent5?.Value, value, diffs, objName, propName);
  }
  
  private static void SetAccent5(DXD.ColorMappingType openXmlElement, DMD.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent5 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 6
  /// </summary>
  private static DMD.ColorSchemeIndexKind? GetAccent6(DXD.ColorMappingType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(openXmlElement?.Accent6?.Value);
  }
  
  private static bool CmpAccent6(DXD.ColorMappingType openXmlElement, DMD.ColorSchemeIndexKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(openXmlElement?.Accent6?.Value, value, diffs, objName, propName);
  }
  
  private static void SetAccent6(DXD.ColorMappingType openXmlElement, DMD.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent6 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Hyperlink
  /// </summary>
  private static DMD.ColorSchemeIndexKind? GetHyperlink(DXD.ColorMappingType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(openXmlElement?.Hyperlink?.Value);
  }
  
  private static bool CmpHyperlink(DXD.ColorMappingType openXmlElement, DMD.ColorSchemeIndexKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(openXmlElement?.Hyperlink?.Value, value, diffs, objName, propName);
  }
  
  private static void SetHyperlink(DXD.ColorMappingType openXmlElement, DMD.ColorSchemeIndexKind? value)
  {
    openXmlElement.Hyperlink = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Followed Hyperlink
  /// </summary>
  private static DMD.ColorSchemeIndexKind? GetFollowedHyperlink(DXD.ColorMappingType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(openXmlElement?.FollowedHyperlink?.Value);
  }
  
  private static bool CmpFollowedHyperlink(DXD.ColorMappingType openXmlElement, DMD.ColorSchemeIndexKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(openXmlElement?.FollowedHyperlink?.Value, value, diffs, objName, propName);
  }
  
  private static void SetFollowedHyperlink(DXD.ColorMappingType openXmlElement, DMD.ColorSchemeIndexKind? value)
  {
    openXmlElement.FollowedHyperlink = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMD.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMD.ExtensionList? GetExtensionList(DXD.ColorMappingType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtensionList>();
    if (element != null)
      return DMXD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXD.ColorMappingType openXmlElement, DMD.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXD.ColorMappingType openXmlElement, DMD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ExtensionListConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.ColorMappingType? CreateModelElement(DXD.ColorMappingType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.ColorMappingType();
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
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.ColorMappingType? openXmlElement, DMD.ColorMappingType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBackground1(openXmlElement, value.Background1, diffs, objName, propName))
        ok = false;
      if (!CmpText1(openXmlElement, value.Text1, diffs, objName, propName))
        ok = false;
      if (!CmpBackground2(openXmlElement, value.Background2, diffs, objName, propName))
        ok = false;
      if (!CmpText2(openXmlElement, value.Text2, diffs, objName, propName))
        ok = false;
      if (!CmpAccent1(openXmlElement, value.Accent1, diffs, objName, propName))
        ok = false;
      if (!CmpAccent2(openXmlElement, value.Accent2, diffs, objName, propName))
        ok = false;
      if (!CmpAccent3(openXmlElement, value.Accent3, diffs, objName, propName))
        ok = false;
      if (!CmpAccent4(openXmlElement, value.Accent4, diffs, objName, propName))
        ok = false;
      if (!CmpAccent5(openXmlElement, value.Accent5, diffs, objName, propName))
        ok = false;
      if (!CmpAccent6(openXmlElement, value.Accent6, diffs, objName, propName))
        ok = false;
      if (!CmpHyperlink(openXmlElement, value.Hyperlink, diffs, objName, propName))
        ok = false;
      if (!CmpFollowedHyperlink(openXmlElement, value.FollowedHyperlink, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ColorMappingType value)
    where OpenXmlElementType: DXD.ColorMappingType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.ColorMappingType openXmlElement, DMD.ColorMappingType value)
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
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
