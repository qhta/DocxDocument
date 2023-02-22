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
    return openXmlElement?.Left?.Value;
  }
  
  private static bool CmpLeft(DXDrawCharts.PageMargins openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Left?.Value == value) return true;
    diffs?.Add(objName, "Left", openXmlElement?.Left?.Value, value);
    return false;
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
    return openXmlElement?.Right?.Value;
  }
  
  private static bool CmpRight(DXDrawCharts.PageMargins openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Right?.Value == value) return true;
    diffs?.Add(objName, "Right", openXmlElement?.Right?.Value, value);
    return false;
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
    return openXmlElement?.Top?.Value;
  }
  
  private static bool CmpTop(DXDrawCharts.PageMargins openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Top?.Value == value) return true;
    diffs?.Add(objName, "Top", openXmlElement?.Top?.Value, value);
    return false;
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
    return openXmlElement?.Bottom?.Value;
  }
  
  private static bool CmpBottom(DXDrawCharts.PageMargins openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Bottom?.Value == value) return true;
    diffs?.Add(objName, "Bottom", openXmlElement?.Bottom?.Value, value);
    return false;
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
    return openXmlElement?.Header?.Value;
  }
  
  private static bool CmpHeader(DXDrawCharts.PageMargins openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Header?.Value == value) return true;
    diffs?.Add(objName, "Header", openXmlElement?.Header?.Value, value);
    return false;
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
    return openXmlElement?.Footer?.Value;
  }
  
  private static bool CmpFooter(DXDrawCharts.PageMargins openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Footer?.Value == value) return true;
    diffs?.Add(objName, "Footer", openXmlElement?.Footer?.Value, value);
    return false;
  }
  
  private static void SetFooter(DXDrawCharts.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.Footer = value;
  }
  
  public static DocumentModel.Drawings.Charts.PageMargins? CreateModelElement(DXDrawCharts.PageMargins? openXmlElement)
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
  
  public static bool CompareModelElement(DXDrawCharts.PageMargins? openXmlElement, DMDrawsCharts.PageMargins? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLeft(openXmlElement, value.Left, diffs, objName))
        ok = false;
      if (!CmpRight(openXmlElement, value.Right, diffs, objName))
        ok = false;
      if (!CmpTop(openXmlElement, value.Top, diffs, objName))
        ok = false;
      if (!CmpBottom(openXmlElement, value.Bottom, diffs, objName))
        ok = false;
      if (!CmpHeader(openXmlElement, value.Header, diffs, objName))
        ok = false;
      if (!CmpFooter(openXmlElement, value.Footer, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.PageMargins value)
    where OpenXmlElementType: DXDrawCharts.PageMargins, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.PageMargins openXmlElement, DMDrawsCharts.PageMargins value)
  {
    SetLeft(openXmlElement, value?.Left);
    SetRight(openXmlElement, value?.Right);
    SetTop(openXmlElement, value?.Top);
    SetBottom(openXmlElement, value?.Bottom);
    SetHeader(openXmlElement, value?.Header);
    SetFooter(openXmlElement, value?.Footer);
    }
  }
