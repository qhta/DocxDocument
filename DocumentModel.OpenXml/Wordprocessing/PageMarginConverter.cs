namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PageMargin Class.
/// </summary>
public static class PageMarginConverter
{
  /// <summary>
  /// Top Margin Spacing
  /// </summary>
  public static Int32? GetTop(DocumentFormat.OpenXml.Wordprocessing.PageMargin? openXmlElement)
  {
    return openXmlElement?.Top?.Value;
  }
  
  public static void SetTop(DocumentFormat.OpenXml.Wordprocessing.PageMargin? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Top = value;
  }
  
  /// <summary>
  /// Right Margin Spacing
  /// </summary>
  public static UInt32? GetRight(DocumentFormat.OpenXml.Wordprocessing.PageMargin? openXmlElement)
  {
    return openXmlElement?.Right?.Value;
  }
  
  public static void SetRight(DocumentFormat.OpenXml.Wordprocessing.PageMargin? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Right = value;
  }
  
  /// <summary>
  /// Page Bottom Spacing
  /// </summary>
  public static Int32? GetBottom(DocumentFormat.OpenXml.Wordprocessing.PageMargin? openXmlElement)
  {
    return openXmlElement?.Bottom?.Value;
  }
  
  public static void SetBottom(DocumentFormat.OpenXml.Wordprocessing.PageMargin? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Bottom = value;
  }
  
  /// <summary>
  /// Left Margin Spacing
  /// </summary>
  public static UInt32? GetLeft(DocumentFormat.OpenXml.Wordprocessing.PageMargin? openXmlElement)
  {
    return openXmlElement?.Left?.Value;
  }
  
  public static void SetLeft(DocumentFormat.OpenXml.Wordprocessing.PageMargin? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Left = value;
  }
  
  /// <summary>
  /// Spacing to Top of Header
  /// </summary>
  public static UInt32? GetHeader(DocumentFormat.OpenXml.Wordprocessing.PageMargin? openXmlElement)
  {
    return openXmlElement?.Header?.Value;
  }
  
  public static void SetHeader(DocumentFormat.OpenXml.Wordprocessing.PageMargin? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Header = value;
  }
  
  /// <summary>
  /// Spacing to Bottom of Footer
  /// </summary>
  public static UInt32? GetFooter(DocumentFormat.OpenXml.Wordprocessing.PageMargin? openXmlElement)
  {
    return openXmlElement?.Footer?.Value;
  }
  
  public static void SetFooter(DocumentFormat.OpenXml.Wordprocessing.PageMargin? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Footer = value;
  }
  
  /// <summary>
  /// Page Gutter Spacing
  /// </summary>
  public static UInt32? GetGutter(DocumentFormat.OpenXml.Wordprocessing.PageMargin? openXmlElement)
  {
    return openXmlElement?.Gutter?.Value;
  }
  
  public static void SetGutter(DocumentFormat.OpenXml.Wordprocessing.PageMargin? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Gutter = value;
  }
  
  public static DocumentModel.Wordprocessing.PageMargin? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.PageMargin? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.PageMargin();
      value.Top = GetTop(openXmlElement);
      value.Right = GetRight(openXmlElement);
      value.Bottom = GetBottom(openXmlElement);
      value.Left = GetLeft(openXmlElement);
      value.Header = GetHeader(openXmlElement);
      value.Footer = GetFooter(openXmlElement);
      value.Gutter = GetGutter(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.PageMargin? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.PageMargin, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
