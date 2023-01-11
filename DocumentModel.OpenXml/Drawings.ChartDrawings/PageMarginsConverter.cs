namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the PageMargins Class.
/// </summary>
public static class PageMarginsConverter
{
  /// <summary>
  /// l, this property is only available in Office 2016 and later.
  /// </summary>
  public static Double? GetL(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins? openXmlElement)
  {
    return openXmlElement?.L?.Value;
  }
  
  public static void SetL(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.L = value;
  }
  
  /// <summary>
  /// r, this property is only available in Office 2016 and later.
  /// </summary>
  public static Double? GetR(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins? openXmlElement)
  {
    return openXmlElement?.R?.Value;
  }
  
  public static void SetR(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.R = value;
  }
  
  /// <summary>
  /// t, this property is only available in Office 2016 and later.
  /// </summary>
  public static Double? GetT(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins? openXmlElement)
  {
    return openXmlElement?.T?.Value;
  }
  
  public static void SetT(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.T = value;
  }
  
  /// <summary>
  /// b, this property is only available in Office 2016 and later.
  /// </summary>
  public static Double? GetB(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins? openXmlElement)
  {
    return openXmlElement?.B?.Value;
  }
  
  public static void SetB(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.B = value;
  }
  
  /// <summary>
  /// header, this property is only available in Office 2016 and later.
  /// </summary>
  public static Double? GetHeader(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins? openXmlElement)
  {
    return openXmlElement?.Header?.Value;
  }
  
  public static void SetHeader(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Header = value;
  }
  
  /// <summary>
  /// footer, this property is only available in Office 2016 and later.
  /// </summary>
  public static Double? GetFooter(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins? openXmlElement)
  {
    return openXmlElement?.Footer?.Value;
  }
  
  public static void SetFooter(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
