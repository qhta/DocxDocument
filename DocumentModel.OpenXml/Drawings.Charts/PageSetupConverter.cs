namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Page Setup.
/// </summary>
public static class PageSetupConverter
{
  /// <summary>
  /// Page Size
  /// </summary>
  private static UInt32? GetPaperSize(DXDrawCharts.PageSetup openXmlElement)
  {
    return openXmlElement.PaperSize?.Value;
  }
  
  private static bool CmpPaperSize(DXDrawCharts.PageSetup openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.PaperSize?.Value == value;
  }
  
  private static void SetPaperSize(DXDrawCharts.PageSetup openXmlElement, UInt32? value)
  {
    openXmlElement.PaperSize = value;
  }
  
  /// <summary>
  /// First Page Number
  /// </summary>
  private static Int32? GetFirstPageNumber(DXDrawCharts.PageSetup openXmlElement)
  {
    return openXmlElement.FirstPageNumber?.Value;
  }
  
  private static bool CmpFirstPageNumber(DXDrawCharts.PageSetup openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.FirstPageNumber?.Value == value;
  }
  
  private static void SetFirstPageNumber(DXDrawCharts.PageSetup openXmlElement, Int32? value)
  {
    openXmlElement.FirstPageNumber = value;
  }
  
  /// <summary>
  /// Orientation
  /// </summary>
  private static DMDrawsCharts.PageSetupOrientationKind? GetOrientation(DXDrawCharts.PageSetup openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.PageSetupOrientationValues, DMDrawsCharts.PageSetupOrientationKind>(openXmlElement?.Orientation?.Value);
  }
  
  private static bool CmpOrientation(DXDrawCharts.PageSetup openXmlElement, DMDrawsCharts.PageSetupOrientationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.PageSetupOrientationValues, DMDrawsCharts.PageSetupOrientationKind>(openXmlElement?.Orientation?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOrientation(DXDrawCharts.PageSetup openXmlElement, DMDrawsCharts.PageSetupOrientationKind? value)
  {
    openXmlElement.Orientation = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Charts.PageSetupOrientationValues, DMDrawsCharts.PageSetupOrientationKind>(value);
  }
  
  /// <summary>
  /// Black and White
  /// </summary>
  private static Boolean? GetBlackAndWhite(DXDrawCharts.PageSetup openXmlElement)
  {
    return openXmlElement?.BlackAndWhite?.Value;
  }
  
  private static bool CmpBlackAndWhite(DXDrawCharts.PageSetup openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.BlackAndWhite?.Value == value;
  }
  
  private static void SetBlackAndWhite(DXDrawCharts.PageSetup openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.BlackAndWhite = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.BlackAndWhite = null;
  }
  
  /// <summary>
  /// Draft
  /// </summary>
  private static Boolean? GetDraft(DXDrawCharts.PageSetup openXmlElement)
  {
    return openXmlElement?.Draft?.Value;
  }
  
  private static bool CmpDraft(DXDrawCharts.PageSetup openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Draft?.Value == value;
  }
  
  private static void SetDraft(DXDrawCharts.PageSetup openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Draft = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Draft = null;
  }
  
  /// <summary>
  /// Use First Page Number
  /// </summary>
  private static Boolean? GetUseFirstPageNumber(DXDrawCharts.PageSetup openXmlElement)
  {
    return openXmlElement?.UseFirstPageNumber?.Value;
  }
  
  private static bool CmpUseFirstPageNumber(DXDrawCharts.PageSetup openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.UseFirstPageNumber?.Value == value;
  }
  
  private static void SetUseFirstPageNumber(DXDrawCharts.PageSetup openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UseFirstPageNumber = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.UseFirstPageNumber = null;
  }
  
  /// <summary>
  /// Horizontal DPI
  /// </summary>
  private static Int32? GetHorizontalDpi(DXDrawCharts.PageSetup openXmlElement)
  {
    return openXmlElement.HorizontalDpi?.Value;
  }
  
  private static bool CmpHorizontalDpi(DXDrawCharts.PageSetup openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.HorizontalDpi?.Value == value;
  }
  
  private static void SetHorizontalDpi(DXDrawCharts.PageSetup openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalDpi = value;
  }
  
  /// <summary>
  /// Vertical DPI
  /// </summary>
  private static Int32? GetVerticalDpi(DXDrawCharts.PageSetup openXmlElement)
  {
    return openXmlElement.VerticalDpi?.Value;
  }
  
  private static bool CmpVerticalDpi(DXDrawCharts.PageSetup openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.VerticalDpi?.Value == value;
  }
  
  private static void SetVerticalDpi(DXDrawCharts.PageSetup openXmlElement, Int32? value)
  {
    openXmlElement.VerticalDpi = value;
  }
  
  /// <summary>
  /// Copies
  /// </summary>
  private static UInt32? GetCopies(DXDrawCharts.PageSetup openXmlElement)
  {
    return openXmlElement.Copies?.Value;
  }
  
  private static bool CmpCopies(DXDrawCharts.PageSetup openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Copies?.Value == value;
  }
  
  private static void SetCopies(DXDrawCharts.PageSetup openXmlElement, UInt32? value)
  {
    openXmlElement.Copies = value;
  }
  
  public static DMDrawsCharts.PageSetup? CreateModelElement(DXDrawCharts.PageSetup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.PageSetup();
      value.PaperSize = GetPaperSize(openXmlElement);
      value.FirstPageNumber = GetFirstPageNumber(openXmlElement);
      value.Orientation = GetOrientation(openXmlElement);
      value.BlackAndWhite = GetBlackAndWhite(openXmlElement);
      value.Draft = GetDraft(openXmlElement);
      value.UseFirstPageNumber = GetUseFirstPageNumber(openXmlElement);
      value.HorizontalDpi = GetHorizontalDpi(openXmlElement);
      value.VerticalDpi = GetVerticalDpi(openXmlElement);
      value.Copies = GetCopies(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.PageSetup? openXmlElement, DMDrawsCharts.PageSetup? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPaperSize(openXmlElement, value.PaperSize, diffs, objName))
        ok = false;
      if (!CmpFirstPageNumber(openXmlElement, value.FirstPageNumber, diffs, objName))
        ok = false;
      if (!CmpOrientation(openXmlElement, value.Orientation, diffs, objName))
        ok = false;
      if (!CmpBlackAndWhite(openXmlElement, value.BlackAndWhite, diffs, objName))
        ok = false;
      if (!CmpDraft(openXmlElement, value.Draft, diffs, objName))
        ok = false;
      if (!CmpUseFirstPageNumber(openXmlElement, value.UseFirstPageNumber, diffs, objName))
        ok = false;
      if (!CmpHorizontalDpi(openXmlElement, value.HorizontalDpi, diffs, objName))
        ok = false;
      if (!CmpVerticalDpi(openXmlElement, value.VerticalDpi, diffs, objName))
        ok = false;
      if (!CmpCopies(openXmlElement, value.Copies, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.PageSetup? value)
    where OpenXmlElementType: DXDrawCharts.PageSetup, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPaperSize(openXmlElement, value?.PaperSize);
      SetFirstPageNumber(openXmlElement, value?.FirstPageNumber);
      SetOrientation(openXmlElement, value?.Orientation);
      SetBlackAndWhite(openXmlElement, value?.BlackAndWhite);
      SetDraft(openXmlElement, value?.Draft);
      SetUseFirstPageNumber(openXmlElement, value?.UseFirstPageNumber);
      SetHorizontalDpi(openXmlElement, value?.HorizontalDpi);
      SetVerticalDpi(openXmlElement, value?.VerticalDpi);
      SetCopies(openXmlElement, value?.Copies);
      return openXmlElement;
    }
    return default;
  }
}
