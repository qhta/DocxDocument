namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Document Background.
/// </summary>
public static class BackgroundConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DXV.Background openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXV.Background openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXV.Background openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  private static Boolean? GetFilled(DXV.Background openXmlElement)
  {
    return openXmlElement?.Filled?.Value;
  }
  
  private static bool CmpFilled(DXV.Background openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Filled?.Value == value) return true;
    diffs?.Add(objName, "Filled", openXmlElement?.Filled?.Value, value);
    return false;
  }
  
  private static void SetFilled(DXV.Background openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Filled = value;
    else
      openXmlElement.Filled = null;
  }
  
  /// <summary>
  /// Fill Color
  /// </summary>
  private static String? GetFillcolor(DXV.Background openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Fillcolor);
  }
  
  private static bool CmpFillcolor(DXV.Background openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Fillcolor, value, diffs, objName, "Fillcolor");
  }
  
  private static void SetFillcolor(DXV.Background openXmlElement, String? value)
  {
    openXmlElement.Fillcolor = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Black-and-White Mode
  /// </summary>
  private static DMV.BlackAndWhiteMode? GetBlackWhiteMode(DXV.Background openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMV.BlackAndWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }
  
  private static bool CmpBlackWhiteMode(DXV.Background openXmlElement, DMV.BlackAndWhiteMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMV.BlackAndWhiteMode>(openXmlElement?.BlackWhiteMode?.Value, value, diffs, objName);
  }
  
  private static void SetBlackWhiteMode(DXV.Background openXmlElement, DMV.BlackAndWhiteMode? value)
  {
    openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMV.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Pure Black-and-White Mode
  /// </summary>
  private static DMV.BlackAndWhiteMode? GetPureBlackWhiteMode(DXV.Background openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMV.BlackAndWhiteMode>(openXmlElement?.PureBlackWhiteMode?.Value);
  }
  
  private static bool CmpPureBlackWhiteMode(DXV.Background openXmlElement, DMV.BlackAndWhiteMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMV.BlackAndWhiteMode>(openXmlElement?.PureBlackWhiteMode?.Value, value, diffs, objName);
  }
  
  private static void SetPureBlackWhiteMode(DXV.Background openXmlElement, DMV.BlackAndWhiteMode? value)
  {
    openXmlElement.PureBlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMV.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Normal Black-and-White Mode
  /// </summary>
  private static DMV.BlackAndWhiteMode? GetNormalBlackWhiteMode(DXV.Background openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMV.BlackAndWhiteMode>(openXmlElement?.NormalBlackWhiteMode?.Value);
  }
  
  private static bool CmpNormalBlackWhiteMode(DXV.Background openXmlElement, DMV.BlackAndWhiteMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMV.BlackAndWhiteMode>(openXmlElement?.NormalBlackWhiteMode?.Value, value, diffs, objName);
  }
  
  private static void SetNormalBlackWhiteMode(DXV.Background openXmlElement, DMV.BlackAndWhiteMode? value)
  {
    openXmlElement.NormalBlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMV.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Target Screen Size
  /// </summary>
  private static DMV.ScreenSizeKind? GetTargetScreenSize(DXV.Background openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.ScreenSizeValues, DMV.ScreenSizeKind>(openXmlElement?.TargetScreenSize?.Value);
  }
  
  private static bool CmpTargetScreenSize(DXV.Background openXmlElement, DMV.ScreenSizeKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.ScreenSizeValues, DMV.ScreenSizeKind>(openXmlElement?.TargetScreenSize?.Value, value, diffs, objName);
  }
  
  private static void SetTargetScreenSize(DXV.Background openXmlElement, DMV.ScreenSizeKind? value)
  {
    openXmlElement.TargetScreenSize = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.ScreenSizeValues, DMV.ScreenSizeKind>(value);
  }
  
  /// <summary>
  /// Fill.
  /// </summary>
  private static DMV.Fill? GetFill(DXV.Background openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Fill>();
    if (element != null)
      return DMXV.FillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFill(DXV.Background openXmlElement, DMV.Fill? value, DiffList? diffs, string? objName)
  {
    return DMXV.FillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Fill>(), value, diffs, objName);
  }
  
  private static void SetFill(DXV.Background openXmlElement, DMV.Fill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Fill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.FillConverter.CreateOpenXmlElement<DXV.Fill>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Vml.Background? CreateModelElement(DXV.Background? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Background();
      value.Id = GetId(openXmlElement);
      value.Filled = GetFilled(openXmlElement);
      value.Fillcolor = GetFillcolor(openXmlElement);
      value.BlackWhiteMode = GetBlackWhiteMode(openXmlElement);
      value.PureBlackWhiteMode = GetPureBlackWhiteMode(openXmlElement);
      value.NormalBlackWhiteMode = GetNormalBlackWhiteMode(openXmlElement);
      value.TargetScreenSize = GetTargetScreenSize(openXmlElement);
      value.Fill = GetFill(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXV.Background? openXmlElement, DMV.Background? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpFilled(openXmlElement, value.Filled, diffs, objName))
        ok = false;
      if (!CmpFillcolor(openXmlElement, value.Fillcolor, diffs, objName))
        ok = false;
      if (!CmpBlackWhiteMode(openXmlElement, value.BlackWhiteMode, diffs, objName))
        ok = false;
      if (!CmpPureBlackWhiteMode(openXmlElement, value.PureBlackWhiteMode, diffs, objName))
        ok = false;
      if (!CmpNormalBlackWhiteMode(openXmlElement, value.NormalBlackWhiteMode, diffs, objName))
        ok = false;
      if (!CmpTargetScreenSize(openXmlElement, value.TargetScreenSize, diffs, objName))
        ok = false;
      if (!CmpFill(openXmlElement, value.Fill, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.Background value)
    where OpenXmlElementType: DXV.Background, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXV.Background openXmlElement, DMV.Background value)
  {
    SetId(openXmlElement, value?.Id);
    SetFilled(openXmlElement, value?.Filled);
    SetFillcolor(openXmlElement, value?.Fillcolor);
    SetBlackWhiteMode(openXmlElement, value?.BlackWhiteMode);
    SetPureBlackWhiteMode(openXmlElement, value?.PureBlackWhiteMode);
    SetNormalBlackWhiteMode(openXmlElement, value?.NormalBlackWhiteMode);
    SetTargetScreenSize(openXmlElement, value?.TargetScreenSize);
    SetFill(openXmlElement, value?.Fill);
  }
}
