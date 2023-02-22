namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ValAxExtension Class.
/// </summary>
public static class ValAxExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.ValAxExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDrawCharts.ValAxExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDrawCharts.ValAxExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDrawsCharts.NumberingFormat3? GetNumberingFormat(DXDrawCharts.ValAxExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.NumberingFormat>();
    if (element != null)
      return DMXDrawsCharts.NumberingFormat3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberingFormat(DXDrawCharts.ValAxExtension openXmlElement, DMDrawsCharts.NumberingFormat3? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.NumberingFormat3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.NumberingFormat>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNumberingFormat(DXDrawCharts.ValAxExtension openXmlElement, DMDrawsCharts.NumberingFormat3? value)
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
  
  public static DocumentModel.Drawings.Charts.ValAxExtension? CreateModelElement(DXDrawCharts.ValAxExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ValAxExtension();
      value.Uri = GetUri(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.ValAxExtension? openXmlElement, DMDrawsCharts.ValAxExtension? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ValAxExtension value)
    where OpenXmlElementType: DXDrawCharts.ValAxExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.ValAxExtension openXmlElement, DMDrawsCharts.ValAxExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetNumberingFormat(openXmlElement, value?.NumberingFormat);
    }
  }
