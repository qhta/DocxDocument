namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DateAxExtension Class.
/// </summary>
public static class DateAxExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.DateAxExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDrawCharts.DateAxExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDrawCharts.DateAxExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDrawsCharts.NumberingFormat3? GetNumberingFormat(DXDrawCharts.DateAxExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.NumberingFormat>();
    if (element != null)
      return DMXDrawsCharts.NumberingFormat3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberingFormat(DXDrawCharts.DateAxExtension openXmlElement, DMDrawsCharts.NumberingFormat3? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.NumberingFormat3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.NumberingFormat>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNumberingFormat(DXDrawCharts.DateAxExtension openXmlElement, DMDrawsCharts.NumberingFormat3? value)
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
  
  public static DocumentModel.Drawings.Charts.DateAxExtension? CreateModelElement(DXDrawCharts.DateAxExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DateAxExtension();
      value.Uri = GetUri(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.DateAxExtension? openXmlElement, DMDrawsCharts.DateAxExtension? value, DiffList? diffs, string? objName)
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.DateAxExtension value)
    where OpenXmlElementType: DXDrawCharts.DateAxExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.DateAxExtension openXmlElement, DMDrawsCharts.DateAxExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetNumberingFormat(openXmlElement, value?.NumberingFormat);
  }
}
