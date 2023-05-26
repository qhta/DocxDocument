namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the PageSetup Class.
/// </summary>
public static class PageSetupConverter
{
  /// <summary>
  /// paperSize, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetPaperSize(DXO16DCD.PageSetup openXmlElement)
  {
    return openXmlElement?.PaperSize?.Value;
  }
  
  private static bool CmpPaperSize(DXO16DCD.PageSetup openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.PaperSize?.Value == value) return true;
    diffs?.Add(objName, "PaperSize", openXmlElement?.PaperSize?.Value, value);
    return false;
  }
  
  private static void SetPaperSize(DXO16DCD.PageSetup openXmlElement, UInt32? value)
  {
    openXmlElement.PaperSize = value;
  }
  
  /// <summary>
  /// firstPageNumber, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetFirstPageNumber(DXO16DCD.PageSetup openXmlElement)
  {
    return openXmlElement?.FirstPageNumber?.Value;
  }
  
  private static bool CmpFirstPageNumber(DXO16DCD.PageSetup openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.FirstPageNumber?.Value == value) return true;
    diffs?.Add(objName, "FirstPageNumber", openXmlElement?.FirstPageNumber?.Value, value);
    return false;
  }
  
  private static void SetFirstPageNumber(DXO16DCD.PageSetup openXmlElement, UInt32? value)
  {
    openXmlElement.FirstPageNumber = value;
  }
  
  /// <summary>
  /// orientation, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDCDs.PageOrientation? GetOrientation(DXO16DCD.PageSetup openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageOrientation, DMDCDs.PageOrientation>(openXmlElement?.Orientation?.Value);
  }
  
  private static bool CmpOrientation(DXO16DCD.PageSetup openXmlElement, DMDCDs.PageOrientation? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageOrientation, DMDCDs.PageOrientation>(openXmlElement?.Orientation?.Value, value, diffs, objName, propName);
  }
  
  private static void SetOrientation(DXO16DCD.PageSetup openXmlElement, DMDCDs.PageOrientation? value)
  {
    openXmlElement.Orientation = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageOrientation, DMDCDs.PageOrientation>(value);
  }
  
  /// <summary>
  /// blackAndWhite, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetBlackAndWhite(DXO16DCD.PageSetup openXmlElement)
  {
    return openXmlElement?.BlackAndWhite?.Value;
  }
  
  private static bool CmpBlackAndWhite(DXO16DCD.PageSetup openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.BlackAndWhite?.Value == value) return true;
    diffs?.Add(objName, "BlackAndWhite", openXmlElement?.BlackAndWhite?.Value, value);
    return false;
  }
  
  private static void SetBlackAndWhite(DXO16DCD.PageSetup openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.BlackAndWhite = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.BlackAndWhite = null;
  }
  
  /// <summary>
  /// draft, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetDraft(DXO16DCD.PageSetup openXmlElement)
  {
    return openXmlElement?.Draft?.Value;
  }
  
  private static bool CmpDraft(DXO16DCD.PageSetup openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Draft?.Value == value) return true;
    diffs?.Add(objName, "Draft", openXmlElement?.Draft?.Value, value);
    return false;
  }
  
  private static void SetDraft(DXO16DCD.PageSetup openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Draft = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Draft = null;
  }
  
  /// <summary>
  /// useFirstPageNumber, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetUseFirstPageNumber(DXO16DCD.PageSetup openXmlElement)
  {
    return openXmlElement?.UseFirstPageNumber?.Value;
  }
  
  private static bool CmpUseFirstPageNumber(DXO16DCD.PageSetup openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.UseFirstPageNumber?.Value == value) return true;
    diffs?.Add(objName, "UseFirstPageNumber", openXmlElement?.UseFirstPageNumber?.Value, value);
    return false;
  }
  
  private static void SetUseFirstPageNumber(DXO16DCD.PageSetup openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UseFirstPageNumber = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.UseFirstPageNumber = null;
  }
  
  /// <summary>
  /// horizontalDpi, this property is only available in Office 2016 and later.
  /// </summary>
  private static Int32? GetHorizontalDpi(DXO16DCD.PageSetup openXmlElement)
  {
    return openXmlElement?.HorizontalDpi?.Value;
  }
  
  private static bool CmpHorizontalDpi(DXO16DCD.PageSetup openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.HorizontalDpi?.Value == value) return true;
    diffs?.Add(objName, "HorizontalDpi", openXmlElement?.HorizontalDpi?.Value, value);
    return false;
  }
  
  private static void SetHorizontalDpi(DXO16DCD.PageSetup openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalDpi = value;
  }
  
  /// <summary>
  /// verticalDpi, this property is only available in Office 2016 and later.
  /// </summary>
  private static Int32? GetVerticalDpi(DXO16DCD.PageSetup openXmlElement)
  {
    return openXmlElement?.VerticalDpi?.Value;
  }
  
  private static bool CmpVerticalDpi(DXO16DCD.PageSetup openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.VerticalDpi?.Value == value) return true;
    diffs?.Add(objName, "VerticalDpi", openXmlElement?.VerticalDpi?.Value, value);
    return false;
  }
  
  private static void SetVerticalDpi(DXO16DCD.PageSetup openXmlElement, Int32? value)
  {
    openXmlElement.VerticalDpi = value;
  }
  
  /// <summary>
  /// copies, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetCopies(DXO16DCD.PageSetup openXmlElement)
  {
    return openXmlElement?.Copies?.Value;
  }
  
  private static bool CmpCopies(DXO16DCD.PageSetup openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Copies?.Value == value) return true;
    diffs?.Add(objName, "Copies", openXmlElement?.Copies?.Value, value);
    return false;
  }
  
  private static void SetCopies(DXO16DCD.PageSetup openXmlElement, UInt32? value)
  {
    openXmlElement.Copies = value;
  }
  
  public static DocumentModel.Drawings.ChartDrawings.PageSetup? CreateModelElement(DXO16DCD.PageSetup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.PageSetup();
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
  
  public static bool CompareModelElement(DXO16DCD.PageSetup? openXmlElement, DMDCDs.PageSetup? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPaperSize(openXmlElement, value.PaperSize, diffs, objName, propName))
        ok = false;
      if (!CmpFirstPageNumber(openXmlElement, value.FirstPageNumber, diffs, objName, propName))
        ok = false;
      if (!CmpOrientation(openXmlElement, value.Orientation, diffs, objName, propName))
        ok = false;
      if (!CmpBlackAndWhite(openXmlElement, value.BlackAndWhite, diffs, objName, propName))
        ok = false;
      if (!CmpDraft(openXmlElement, value.Draft, diffs, objName, propName))
        ok = false;
      if (!CmpUseFirstPageNumber(openXmlElement, value.UseFirstPageNumber, diffs, objName, propName))
        ok = false;
      if (!CmpHorizontalDpi(openXmlElement, value.HorizontalDpi, diffs, objName, propName))
        ok = false;
      if (!CmpVerticalDpi(openXmlElement, value.VerticalDpi, diffs, objName, propName))
        ok = false;
      if (!CmpCopies(openXmlElement, value.Copies, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.PageSetup value)
    where OpenXmlElementType: DXO16DCD.PageSetup, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.PageSetup openXmlElement, DMDCDs.PageSetup value)
  {
    SetPaperSize(openXmlElement, value?.PaperSize);
    SetFirstPageNumber(openXmlElement, value?.FirstPageNumber);
    SetOrientation(openXmlElement, value?.Orientation);
    SetBlackAndWhite(openXmlElement, value?.BlackAndWhite);
    SetDraft(openXmlElement, value?.Draft);
    SetUseFirstPageNumber(openXmlElement, value?.UseFirstPageNumber);
    SetHorizontalDpi(openXmlElement, value?.HorizontalDpi);
    SetVerticalDpi(openXmlElement, value?.VerticalDpi);
    SetCopies(openXmlElement, value?.Copies);
  }
}
