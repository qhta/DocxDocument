namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the PageSetup Class.
/// </summary>
public static class PageSetupConverter
{
  /// <summary>
  /// paperSize, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetPaperSize(DXO2016DrawChartDraw.PageSetup openXmlElement)
  {
    return openXmlElement?.PaperSize?.Value;
  }
  
  private static bool CmpPaperSize(DXO2016DrawChartDraw.PageSetup openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.PaperSize?.Value == value) return true;
    diffs?.Add(objName, "PaperSize", openXmlElement?.PaperSize?.Value, value);
    return false;
  }
  
  private static void SetPaperSize(DXO2016DrawChartDraw.PageSetup openXmlElement, UInt32? value)
  {
    openXmlElement.PaperSize = value;
  }
  
  /// <summary>
  /// firstPageNumber, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetFirstPageNumber(DXO2016DrawChartDraw.PageSetup openXmlElement)
  {
    return openXmlElement?.FirstPageNumber?.Value;
  }
  
  private static bool CmpFirstPageNumber(DXO2016DrawChartDraw.PageSetup openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.FirstPageNumber?.Value == value) return true;
    diffs?.Add(objName, "FirstPageNumber", openXmlElement?.FirstPageNumber?.Value, value);
    return false;
  }
  
  private static void SetFirstPageNumber(DXO2016DrawChartDraw.PageSetup openXmlElement, UInt32? value)
  {
    openXmlElement.FirstPageNumber = value;
  }
  
  /// <summary>
  /// orientation, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDrawsChartDraws.PageOrientation? GetOrientation(DXO2016DrawChartDraw.PageSetup openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageOrientation, DMDrawsChartDraws.PageOrientation>(openXmlElement?.Orientation?.Value);
  }
  
  private static bool CmpOrientation(DXO2016DrawChartDraw.PageSetup openXmlElement, DMDrawsChartDraws.PageOrientation? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageOrientation, DMDrawsChartDraws.PageOrientation>(openXmlElement?.Orientation?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOrientation(DXO2016DrawChartDraw.PageSetup openXmlElement, DMDrawsChartDraws.PageOrientation? value)
  {
    openXmlElement.Orientation = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageOrientation, DMDrawsChartDraws.PageOrientation>(value);
  }
  
  /// <summary>
  /// blackAndWhite, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetBlackAndWhite(DXO2016DrawChartDraw.PageSetup openXmlElement)
  {
    return openXmlElement?.BlackAndWhite?.Value;
  }
  
  private static bool CmpBlackAndWhite(DXO2016DrawChartDraw.PageSetup openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.BlackAndWhite?.Value == value) return true;
    diffs?.Add(objName, "BlackAndWhite", openXmlElement?.BlackAndWhite?.Value, value);
    return false;
  }
  
  private static void SetBlackAndWhite(DXO2016DrawChartDraw.PageSetup openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.BlackAndWhite = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.BlackAndWhite = null;
  }
  
  /// <summary>
  /// draft, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetDraft(DXO2016DrawChartDraw.PageSetup openXmlElement)
  {
    return openXmlElement?.Draft?.Value;
  }
  
  private static bool CmpDraft(DXO2016DrawChartDraw.PageSetup openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Draft?.Value == value) return true;
    diffs?.Add(objName, "Draft", openXmlElement?.Draft?.Value, value);
    return false;
  }
  
  private static void SetDraft(DXO2016DrawChartDraw.PageSetup openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Draft = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Draft = null;
  }
  
  /// <summary>
  /// useFirstPageNumber, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetUseFirstPageNumber(DXO2016DrawChartDraw.PageSetup openXmlElement)
  {
    return openXmlElement?.UseFirstPageNumber?.Value;
  }
  
  private static bool CmpUseFirstPageNumber(DXO2016DrawChartDraw.PageSetup openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.UseFirstPageNumber?.Value == value) return true;
    diffs?.Add(objName, "UseFirstPageNumber", openXmlElement?.UseFirstPageNumber?.Value, value);
    return false;
  }
  
  private static void SetUseFirstPageNumber(DXO2016DrawChartDraw.PageSetup openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UseFirstPageNumber = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.UseFirstPageNumber = null;
  }
  
  /// <summary>
  /// horizontalDpi, this property is only available in Office 2016 and later.
  /// </summary>
  private static Int32? GetHorizontalDpi(DXO2016DrawChartDraw.PageSetup openXmlElement)
  {
    return openXmlElement?.HorizontalDpi?.Value;
  }
  
  private static bool CmpHorizontalDpi(DXO2016DrawChartDraw.PageSetup openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HorizontalDpi?.Value == value) return true;
    diffs?.Add(objName, "HorizontalDpi", openXmlElement?.HorizontalDpi?.Value, value);
    return false;
  }
  
  private static void SetHorizontalDpi(DXO2016DrawChartDraw.PageSetup openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalDpi = value;
  }
  
  /// <summary>
  /// verticalDpi, this property is only available in Office 2016 and later.
  /// </summary>
  private static Int32? GetVerticalDpi(DXO2016DrawChartDraw.PageSetup openXmlElement)
  {
    return openXmlElement?.VerticalDpi?.Value;
  }
  
  private static bool CmpVerticalDpi(DXO2016DrawChartDraw.PageSetup openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.VerticalDpi?.Value == value) return true;
    diffs?.Add(objName, "VerticalDpi", openXmlElement?.VerticalDpi?.Value, value);
    return false;
  }
  
  private static void SetVerticalDpi(DXO2016DrawChartDraw.PageSetup openXmlElement, Int32? value)
  {
    openXmlElement.VerticalDpi = value;
  }
  
  /// <summary>
  /// copies, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetCopies(DXO2016DrawChartDraw.PageSetup openXmlElement)
  {
    return openXmlElement?.Copies?.Value;
  }
  
  private static bool CmpCopies(DXO2016DrawChartDraw.PageSetup openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Copies?.Value == value) return true;
    diffs?.Add(objName, "Copies", openXmlElement?.Copies?.Value, value);
    return false;
  }
  
  private static void SetCopies(DXO2016DrawChartDraw.PageSetup openXmlElement, UInt32? value)
  {
    openXmlElement.Copies = value;
  }
  
  public static DMDrawsChartDraws.PageSetup? CreateModelElement(DXO2016DrawChartDraw.PageSetup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.PageSetup();
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
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.PageSetup? openXmlElement, DMDrawsChartDraws.PageSetup? value, DiffList? diffs, string? objName)
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.PageSetup? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.PageSetup, new()
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
