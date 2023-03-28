namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ColorMappingType Class converter from/to OpenXml.
///</summary>
public static class ColorMappingTypeConverter
{
  /// <summary>
  /// Background 1
  /// </summary>
  private static DMDraws.ColorSchemeIndexKind? GetBackground1(DXO2016DrawChartDraw.ColorMappingType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(openXmlElement?.Background1?.Value);
  }
  
  private static bool CmpBackground1(DXO2016DrawChartDraw.ColorMappingType openXmlElement, DMDraws.ColorSchemeIndexKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(openXmlElement?.Background1?.Value, value, diffs, objName);
  }
  
  private static void SetBackground1(DXO2016DrawChartDraw.ColorMappingType openXmlElement, DMDraws.ColorSchemeIndexKind? value)
  {
    openXmlElement.Background1 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Text 1
  /// </summary>
  private static DMDraws.ColorSchemeIndexKind? GetText1(DXO2016DrawChartDraw.ColorMappingType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(openXmlElement?.Text1?.Value);
  }
  
  private static bool CmpText1(DXO2016DrawChartDraw.ColorMappingType openXmlElement, DMDraws.ColorSchemeIndexKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(openXmlElement?.Text1?.Value, value, diffs, objName);
  }
  
  private static void SetText1(DXO2016DrawChartDraw.ColorMappingType openXmlElement, DMDraws.ColorSchemeIndexKind? value)
  {
    openXmlElement.Text1 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Background 2
  /// </summary>
  private static DMDraws.ColorSchemeIndexKind? GetBackground2(DXO2016DrawChartDraw.ColorMappingType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(openXmlElement?.Background2?.Value);
  }
  
  private static bool CmpBackground2(DXO2016DrawChartDraw.ColorMappingType openXmlElement, DMDraws.ColorSchemeIndexKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(openXmlElement?.Background2?.Value, value, diffs, objName);
  }
  
  private static void SetBackground2(DXO2016DrawChartDraw.ColorMappingType openXmlElement, DMDraws.ColorSchemeIndexKind? value)
  {
    openXmlElement.Background2 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Text 2
  /// </summary>
  private static DMDraws.ColorSchemeIndexKind? GetText2(DXO2016DrawChartDraw.ColorMappingType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(openXmlElement?.Text2?.Value);
  }
  
  private static bool CmpText2(DXO2016DrawChartDraw.ColorMappingType openXmlElement, DMDraws.ColorSchemeIndexKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(openXmlElement?.Text2?.Value, value, diffs, objName);
  }
  
  private static void SetText2(DXO2016DrawChartDraw.ColorMappingType openXmlElement, DMDraws.ColorSchemeIndexKind? value)
  {
    openXmlElement.Text2 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 1
  /// </summary>
  private static DMDraws.ColorSchemeIndexKind? GetAccent1(DXO2016DrawChartDraw.ColorMappingType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(openXmlElement?.Accent1?.Value);
  }
  
  private static bool CmpAccent1(DXO2016DrawChartDraw.ColorMappingType openXmlElement, DMDraws.ColorSchemeIndexKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(openXmlElement?.Accent1?.Value, value, diffs, objName);
  }
  
  private static void SetAccent1(DXO2016DrawChartDraw.ColorMappingType openXmlElement, DMDraws.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent1 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 2
  /// </summary>
  private static DMDraws.ColorSchemeIndexKind? GetAccent2(DXO2016DrawChartDraw.ColorMappingType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(openXmlElement?.Accent2?.Value);
  }
  
  private static bool CmpAccent2(DXO2016DrawChartDraw.ColorMappingType openXmlElement, DMDraws.ColorSchemeIndexKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(openXmlElement?.Accent2?.Value, value, diffs, objName);
  }
  
  private static void SetAccent2(DXO2016DrawChartDraw.ColorMappingType openXmlElement, DMDraws.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent2 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 3
  /// </summary>
  private static DMDraws.ColorSchemeIndexKind? GetAccent3(DXO2016DrawChartDraw.ColorMappingType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(openXmlElement?.Accent3?.Value);
  }
  
  private static bool CmpAccent3(DXO2016DrawChartDraw.ColorMappingType openXmlElement, DMDraws.ColorSchemeIndexKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(openXmlElement?.Accent3?.Value, value, diffs, objName);
  }
  
  private static void SetAccent3(DXO2016DrawChartDraw.ColorMappingType openXmlElement, DMDraws.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent3 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 4
  /// </summary>
  private static DMDraws.ColorSchemeIndexKind? GetAccent4(DXO2016DrawChartDraw.ColorMappingType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(openXmlElement?.Accent4?.Value);
  }
  
  private static bool CmpAccent4(DXO2016DrawChartDraw.ColorMappingType openXmlElement, DMDraws.ColorSchemeIndexKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(openXmlElement?.Accent4?.Value, value, diffs, objName);
  }
  
  private static void SetAccent4(DXO2016DrawChartDraw.ColorMappingType openXmlElement, DMDraws.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent4 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 5
  /// </summary>
  private static DMDraws.ColorSchemeIndexKind? GetAccent5(DXO2016DrawChartDraw.ColorMappingType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(openXmlElement?.Accent5?.Value);
  }
  
  private static bool CmpAccent5(DXO2016DrawChartDraw.ColorMappingType openXmlElement, DMDraws.ColorSchemeIndexKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(openXmlElement?.Accent5?.Value, value, diffs, objName);
  }
  
  private static void SetAccent5(DXO2016DrawChartDraw.ColorMappingType openXmlElement, DMDraws.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent5 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 6
  /// </summary>
  private static DMDraws.ColorSchemeIndexKind? GetAccent6(DXO2016DrawChartDraw.ColorMappingType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(openXmlElement?.Accent6?.Value);
  }
  
  private static bool CmpAccent6(DXO2016DrawChartDraw.ColorMappingType openXmlElement, DMDraws.ColorSchemeIndexKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(openXmlElement?.Accent6?.Value, value, diffs, objName);
  }
  
  private static void SetAccent6(DXO2016DrawChartDraw.ColorMappingType openXmlElement, DMDraws.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent6 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Hyperlink
  /// </summary>
  private static DMDraws.ColorSchemeIndexKind? GetHyperlink(DXO2016DrawChartDraw.ColorMappingType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(openXmlElement?.Hyperlink?.Value);
  }
  
  private static bool CmpHyperlink(DXO2016DrawChartDraw.ColorMappingType openXmlElement, DMDraws.ColorSchemeIndexKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(openXmlElement?.Hyperlink?.Value, value, diffs, objName);
  }
  
  private static void SetHyperlink(DXO2016DrawChartDraw.ColorMappingType openXmlElement, DMDraws.ColorSchemeIndexKind? value)
  {
    openXmlElement.Hyperlink = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Followed Hyperlink
  /// </summary>
  private static DMDraws.ColorSchemeIndexKind? GetFollowedHyperlink(DXO2016DrawChartDraw.ColorMappingType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(openXmlElement?.FollowedHyperlink?.Value);
  }
  
  private static bool CmpFollowedHyperlink(DXO2016DrawChartDraw.ColorMappingType openXmlElement, DMDraws.ColorSchemeIndexKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(openXmlElement?.FollowedHyperlink?.Value, value, diffs, objName);
  }
  
  private static void SetFollowedHyperlink(DXO2016DrawChartDraw.ColorMappingType openXmlElement, DMDraws.ColorSchemeIndexKind? value)
  {
    openXmlElement.FollowedHyperlink = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DMDraws.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDraws.ExtensionList? GetExtensionList(DXO2016DrawChartDraw.ColorMappingType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (element != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO2016DrawChartDraw.ColorMappingType openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXO2016DrawChartDraw.ColorMappingType openXmlElement, DMDraws.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ExtensionListConverter.CreateOpenXmlElement<DXDraw.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ColorMappingType? CreateModelElement(DXO2016DrawChartDraw.ColorMappingType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ColorMappingType();
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
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.ColorMappingType? openXmlElement, DMDrawsChartDraws.ColorMappingType? value, DiffList? diffs, string? objName)
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
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.ColorMappingType value)
    where OpenXmlElementType: DXO2016DrawChartDraw.ColorMappingType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.ColorMappingType openXmlElement, DMDrawsChartDraws.ColorMappingType value)
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
