namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Page Margins.
/// </summary>
public static class PageMarginsConverter
{
  /// <summary>
  /// Left
  /// </summary>
  public static Double? GetLeft(DocumentFormat.OpenXml.Drawing.Charts.PageMargins? openXmlElement)
  {
    return openXmlElement?.Left?.Value;
  }
  
  public static void SetLeft(DocumentFormat.OpenXml.Drawing.Charts.PageMargins? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Left = value;
  }
  
  /// <summary>
  /// Right
  /// </summary>
  public static Double? GetRight(DocumentFormat.OpenXml.Drawing.Charts.PageMargins? openXmlElement)
  {
    return openXmlElement?.Right?.Value;
  }
  
  public static void SetRight(DocumentFormat.OpenXml.Drawing.Charts.PageMargins? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Right = value;
  }
  
  /// <summary>
  /// Top
  /// </summary>
  public static Double? GetTop(DocumentFormat.OpenXml.Drawing.Charts.PageMargins? openXmlElement)
  {
    return openXmlElement?.Top?.Value;
  }
  
  public static void SetTop(DocumentFormat.OpenXml.Drawing.Charts.PageMargins? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Top = value;
  }
  
  /// <summary>
  /// Bottom
  /// </summary>
  public static Double? GetBottom(DocumentFormat.OpenXml.Drawing.Charts.PageMargins? openXmlElement)
  {
    return openXmlElement?.Bottom?.Value;
  }
  
  public static void SetBottom(DocumentFormat.OpenXml.Drawing.Charts.PageMargins? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Bottom = value;
  }
  
  /// <summary>
  /// Header
  /// </summary>
  public static Double? GetHeader(DocumentFormat.OpenXml.Drawing.Charts.PageMargins? openXmlElement)
  {
    return openXmlElement?.Header?.Value;
  }
  
  public static void SetHeader(DocumentFormat.OpenXml.Drawing.Charts.PageMargins? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Header = value;
  }
  
  /// <summary>
  /// Footer
  /// </summary>
  public static Double? GetFooter(DocumentFormat.OpenXml.Drawing.Charts.PageMargins? openXmlElement)
  {
    return openXmlElement?.Footer?.Value;
  }
  
  public static void SetFooter(DocumentFormat.OpenXml.Drawing.Charts.PageMargins? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Footer = value;
  }
  
  public static DocumentModel.Drawings.Charts.PageMargins? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.PageMargins? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PageMargins();
      value.Left = GetLeft(openXmlElement);
      value.Right = GetRight(openXmlElement);
      value.Top = GetTop(openXmlElement);
      value.Bottom = GetBottom(openXmlElement);
      value.Header = GetHeader(openXmlElement);
      value.Footer = GetFooter(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.PageMargins? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.PageMargins, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLeft(openXmlElement, value?.Left);
      SetRight(openXmlElement, value?.Right);
      SetTop(openXmlElement, value?.Top);
      SetBottom(openXmlElement, value?.Bottom);
      SetHeader(openXmlElement, value?.Header);
      SetFooter(openXmlElement, value?.Footer);
      return openXmlElement;
    }
    return default;
  }
}
