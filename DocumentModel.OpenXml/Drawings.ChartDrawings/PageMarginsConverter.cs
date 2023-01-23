namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the PageMargins Class.
/// </summary>
public static class PageMarginsConverter
{
  /// <summary>
  /// l, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetL(DXO2016DrawChartDraw.PageMargins openXmlElement)
  {
    return openXmlElement.L?.Value;
  }
  
  private static bool CmpL(DXO2016DrawChartDraw.PageMargins openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.L?.Value == value;
  }
  
  private static void SetL(DXO2016DrawChartDraw.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.L = value;
  }
  
  /// <summary>
  /// r, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetR(DXO2016DrawChartDraw.PageMargins openXmlElement)
  {
    return openXmlElement.R?.Value;
  }
  
  private static bool CmpR(DXO2016DrawChartDraw.PageMargins openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.R?.Value == value;
  }
  
  private static void SetR(DXO2016DrawChartDraw.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.R = value;
  }
  
  /// <summary>
  /// t, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetT(DXO2016DrawChartDraw.PageMargins openXmlElement)
  {
    return openXmlElement.T?.Value;
  }
  
  private static bool CmpT(DXO2016DrawChartDraw.PageMargins openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.T?.Value == value;
  }
  
  private static void SetT(DXO2016DrawChartDraw.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.T = value;
  }
  
  /// <summary>
  /// b, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetB(DXO2016DrawChartDraw.PageMargins openXmlElement)
  {
    return openXmlElement.B?.Value;
  }
  
  private static bool CmpB(DXO2016DrawChartDraw.PageMargins openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.B?.Value == value;
  }
  
  private static void SetB(DXO2016DrawChartDraw.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.B = value;
  }
  
  /// <summary>
  /// header, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetHeader(DXO2016DrawChartDraw.PageMargins openXmlElement)
  {
    return openXmlElement.Header?.Value;
  }
  
  private static bool CmpHeader(DXO2016DrawChartDraw.PageMargins openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Header?.Value == value;
  }
  
  private static void SetHeader(DXO2016DrawChartDraw.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.Header = value;
  }
  
  /// <summary>
  /// footer, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetFooter(DXO2016DrawChartDraw.PageMargins openXmlElement)
  {
    return openXmlElement.Footer?.Value;
  }
  
  private static bool CmpFooter(DXO2016DrawChartDraw.PageMargins openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Footer?.Value == value;
  }
  
  private static void SetFooter(DXO2016DrawChartDraw.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.Footer = value;
  }
  
  public static DMDrawsChartDraws.PageMargins? CreateModelElement(DXO2016DrawChartDraw.PageMargins? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.PageMargins();
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
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.PageMargins? openXmlElement, DMDrawsChartDraws.PageMargins? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpL(openXmlElement, value.L, diffs, objName))
        ok = false;
      if (!CmpR(openXmlElement, value.R, diffs, objName))
        ok = false;
      if (!CmpT(openXmlElement, value.T, diffs, objName))
        ok = false;
      if (!CmpB(openXmlElement, value.B, diffs, objName))
        ok = false;
      if (!CmpHeader(openXmlElement, value.Header, diffs, objName))
        ok = false;
      if (!CmpFooter(openXmlElement, value.Footer, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.PageMargins? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.PageMargins, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetL(openXmlElement, value?.L);
      SetR(openXmlElement, value?.R);
      SetT(openXmlElement, value?.T);
      SetB(openXmlElement, value?.B);
      SetHeader(openXmlElement, value?.Header);
      SetFooter(openXmlElement, value?.Footer);
      return openXmlElement;
    }
    return default;
  }
}
