using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the PageMargins Class.
/// </summary>
public static class PageMarginsConverter
{
  /// <summary>
  ///   l, this property is only available in Office 2016 and later.
  /// </summary>
  public static Double? GetL(PageMargins? openXmlElement)
  {
    return openXmlElement?.L?.Value;
  }

  public static void SetL(PageMargins? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.L = value;
  }

  /// <summary>
  ///   r, this property is only available in Office 2016 and later.
  /// </summary>
  public static Double? GetR(PageMargins? openXmlElement)
  {
    return openXmlElement?.R?.Value;
  }

  public static void SetR(PageMargins? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.R = value;
  }

  /// <summary>
  ///   t, this property is only available in Office 2016 and later.
  /// </summary>
  public static Double? GetT(PageMargins? openXmlElement)
  {
    return openXmlElement?.T?.Value;
  }

  public static void SetT(PageMargins? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.T = value;
  }

  /// <summary>
  ///   b, this property is only available in Office 2016 and later.
  /// </summary>
  public static Double? GetB(PageMargins? openXmlElement)
  {
    return openXmlElement?.B?.Value;
  }

  public static void SetB(PageMargins? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.B = value;
  }

  /// <summary>
  ///   header, this property is only available in Office 2016 and later.
  /// </summary>
  public static Double? GetHeader(PageMargins? openXmlElement)
  {
    return openXmlElement?.Header?.Value;
  }

  public static void SetHeader(PageMargins? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Header = value;
  }

  /// <summary>
  ///   footer, this property is only available in Office 2016 and later.
  /// </summary>
  public static Double? GetFooter(PageMargins? openXmlElement)
  {
    return openXmlElement?.Footer?.Value;
  }

  public static void SetFooter(PageMargins? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Footer = value;
  }

  public static DocumentModel.Drawings.ChartDrawings.PageMargins? CreateModelElement(PageMargins? openXmlElement)
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
    where OpenXmlElementType : PageMargins, new()
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