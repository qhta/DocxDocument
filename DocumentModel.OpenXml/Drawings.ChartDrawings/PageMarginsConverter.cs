namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the PageMargins Class.
/// </summary>
public static class PageMarginsConverter
{
  /// <summary>
  /// l, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetL(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins openXmlElement)
  {
    return openXmlElement.L?.Value;
  }
  
  private static void SetL(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.L = value;
  }
  
  /// <summary>
  /// r, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetR(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins openXmlElement)
  {
    return openXmlElement.R?.Value;
  }
  
  private static void SetR(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.R = value;
  }
  
  /// <summary>
  /// t, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetT(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins openXmlElement)
  {
    return openXmlElement.T?.Value;
  }
  
  private static void SetT(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.T = value;
  }
  
  /// <summary>
  /// b, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetB(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins openXmlElement)
  {
    return openXmlElement.B?.Value;
  }
  
  private static void SetB(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.B = value;
  }
  
  /// <summary>
  /// header, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetHeader(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins openXmlElement)
  {
    return openXmlElement.Header?.Value;
  }
  
  private static void SetHeader(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.Header = value;
  }
  
  /// <summary>
  /// footer, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetFooter(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins openXmlElement)
  {
    return openXmlElement.Footer?.Value;
  }
  
  private static void SetFooter(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.Footer = value;
  }
  
  public static DocumentModel.Drawings.ChartDrawings.PageMargins? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.PageMargins? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins, new()
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
