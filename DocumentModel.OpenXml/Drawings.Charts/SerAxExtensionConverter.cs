namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the SerAxExtension Class.
/// </summary>
public static class SerAxExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.SerAxExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static bool CmpUri(DXDrawCharts.SerAxExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Uri?.Value == value;
  }
  
  private static void SetUri(DXDrawCharts.SerAxExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.NumberingFormat3? GetNumberingFormat(DXDrawCharts.SerAxExtension openXmlElement)
  {
    return DMXDrawsCharts.NumberingFormat3Converter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.NumberingFormat>());
  }
  
  private static bool CmpNumberingFormat(DXDrawCharts.SerAxExtension openXmlElement, DMDrawsCharts.NumberingFormat3? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.NumberingFormat3Converter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.NumberingFormat>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNumberingFormat(DXDrawCharts.SerAxExtension openXmlElement, DMDrawsCharts.NumberingFormat3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.NumberingFormat>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.NumberingFormat3Converter.CreateOpenXmlElement<DXO2013DrawChart.NumberingFormat>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.SerAxExtension? CreateModelElement(DXDrawCharts.SerAxExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.SerAxExtension();
      value.Uri = GetUri(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.SerAxExtension? openXmlElement, DMDrawsCharts.SerAxExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpNumberingFormat(openXmlElement, value.NumberingFormat, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.SerAxExtension? value)
    where OpenXmlElementType: DXDrawCharts.SerAxExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetNumberingFormat(openXmlElement, value?.NumberingFormat);
      return openXmlElement;
    }
    return default;
  }
}
