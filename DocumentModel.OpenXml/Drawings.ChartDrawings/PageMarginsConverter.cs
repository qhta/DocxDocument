namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the PageMargins Class.
/// </summary>
public static class PageMarginsConverter
{
  /// <summary>
  /// l, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetL(DXO16DCD.PageMargins openXmlElement)
  {
    return openXmlElement?.L?.Value;
  }
  
  private static bool CmpL(DXO16DCD.PageMargins openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.L?.Value == value) return true;
    diffs?.Add(objName, "L", openXmlElement?.L?.Value, value);
    return false;
  }
  
  private static void SetL(DXO16DCD.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.L = value;
  }
  
  /// <summary>
  /// r, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetR(DXO16DCD.PageMargins openXmlElement)
  {
    return openXmlElement?.R?.Value;
  }
  
  private static bool CmpR(DXO16DCD.PageMargins openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.R?.Value == value) return true;
    diffs?.Add(objName, "R", openXmlElement?.R?.Value, value);
    return false;
  }
  
  private static void SetR(DXO16DCD.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.R = value;
  }
  
  /// <summary>
  /// t, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetT(DXO16DCD.PageMargins openXmlElement)
  {
    return openXmlElement?.T?.Value;
  }
  
  private static bool CmpT(DXO16DCD.PageMargins openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.T?.Value == value) return true;
    diffs?.Add(objName, "ModelType", openXmlElement?.T?.Value, value);
    return false;
  }
  
  private static void SetT(DXO16DCD.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.T = value;
  }
  
  /// <summary>
  /// b, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetB(DXO16DCD.PageMargins openXmlElement)
  {
    return openXmlElement?.B?.Value;
  }
  
  private static bool CmpB(DXO16DCD.PageMargins openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.B?.Value == value) return true;
    diffs?.Add(objName, "B", openXmlElement?.B?.Value, value);
    return false;
  }
  
  private static void SetB(DXO16DCD.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.B = value;
  }
  
  /// <summary>
  /// header, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetHeader(DXO16DCD.PageMargins openXmlElement)
  {
    return openXmlElement?.Header?.Value;
  }
  
  private static bool CmpHeader(DXO16DCD.PageMargins openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Header?.Value == value) return true;
    diffs?.Add(objName, "Header", openXmlElement?.Header?.Value, value);
    return false;
  }
  
  private static void SetHeader(DXO16DCD.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.Header = value;
  }
  
  /// <summary>
  /// footer, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetFooter(DXO16DCD.PageMargins openXmlElement)
  {
    return openXmlElement?.Footer?.Value;
  }
  
  private static bool CmpFooter(DXO16DCD.PageMargins openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Footer?.Value == value) return true;
    diffs?.Add(objName, "Footer", openXmlElement?.Footer?.Value, value);
    return false;
  }
  
  private static void SetFooter(DXO16DCD.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.Footer = value;
  }
  
  public static DocumentModel.Drawings.ChartDrawings.PageMargins? CreateModelElement(DXO16DCD.PageMargins? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.PageMargins();
      value.L = GetL(openXmlElement);
      value.R = GetR(openXmlElement);
      value.T = GetT(openXmlElement);
      value.B = GetB(openXmlElement);
      value.Header = GetHeader(openXmlElement);
      value.Footer = GetFooter(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.PageMargins? openXmlElement, DMDCDs.PageMargins? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpL(openXmlElement, value.L, diffs, objName, propName))
        ok = false;
      if (!CmpR(openXmlElement, value.R, diffs, objName, propName))
        ok = false;
      if (!CmpT(openXmlElement, value.T, diffs, objName, propName))
        ok = false;
      if (!CmpB(openXmlElement, value.B, diffs, objName, propName))
        ok = false;
      if (!CmpHeader(openXmlElement, value.Header, diffs, objName, propName))
        ok = false;
      if (!CmpFooter(openXmlElement, value.Footer, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.PageMargins value)
    where OpenXmlElementType: DXO16DCD.PageMargins, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.PageMargins openXmlElement, DMDCDs.PageMargins value)
  {
    SetL(openXmlElement, value?.L);
    SetR(openXmlElement, value?.R);
    SetT(openXmlElement, value?.T);
    SetB(openXmlElement, value?.B);
    SetHeader(openXmlElement, value?.Header);
    SetFooter(openXmlElement, value?.Footer);
  }
}
