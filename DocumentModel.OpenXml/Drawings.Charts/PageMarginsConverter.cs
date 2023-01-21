namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Page Margins.
/// </summary>
public static class PageMarginsConverter
{
  /// <summary>
  /// Left
  /// </summary>
  private static Double? GetLeft(DXDrawCharts.PageMargins openXmlElement)
  {
    return openXmlElement.Left?.Value;
  }
  
  private static void SetLeft(DXDrawCharts.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.Left = value;
  }
  
  /// <summary>
  /// Right
  /// </summary>
  private static Double? GetRight(DXDrawCharts.PageMargins openXmlElement)
  {
    return openXmlElement.Right?.Value;
  }
  
  private static void SetRight(DXDrawCharts.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.Right = value;
  }
  
  /// <summary>
  /// Top
  /// </summary>
  private static Double? GetTop(DXDrawCharts.PageMargins openXmlElement)
  {
    return openXmlElement.Top?.Value;
  }
  
  private static void SetTop(DXDrawCharts.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.Top = value;
  }
  
  /// <summary>
  /// Bottom
  /// </summary>
  private static Double? GetBottom(DXDrawCharts.PageMargins openXmlElement)
  {
    return openXmlElement.Bottom?.Value;
  }
  
  private static void SetBottom(DXDrawCharts.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.Bottom = value;
  }
  
  /// <summary>
  /// Header
  /// </summary>
  private static Double? GetHeader(DXDrawCharts.PageMargins openXmlElement)
  {
    return openXmlElement.Header?.Value;
  }
  
  private static void SetHeader(DXDrawCharts.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.Header = value;
  }
  
  /// <summary>
  /// Footer
  /// </summary>
  private static Double? GetFooter(DXDrawCharts.PageMargins openXmlElement)
  {
    return openXmlElement.Footer?.Value;
  }
  
  private static void SetFooter(DXDrawCharts.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.Footer = value;
  }
  
  public static DMDrawsCharts.PageMargins? CreateModelElement(DXDrawCharts.PageMargins? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.PageMargins();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.PageMargins? value)
    where OpenXmlElementType: DXDrawCharts.PageMargins, new()
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
