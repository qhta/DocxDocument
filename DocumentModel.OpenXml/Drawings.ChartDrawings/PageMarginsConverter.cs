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
