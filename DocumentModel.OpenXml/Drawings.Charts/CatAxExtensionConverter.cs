namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the CatAxExtension Class.
/// </summary>
public static class CatAxExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.CatAxExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXDrawCharts.CatAxExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.NumberingFormat3? GetNumberingFormat(DXDrawCharts.CatAxExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.NumberingFormat>();
    if (itemElement != null)
      return DMXDrawsCharts.NumberingFormat3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNumberingFormat(DXDrawCharts.CatAxExtension openXmlElement, DMDrawsCharts.NumberingFormat3? value)
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
  
  public static DMDrawsCharts.CatAxExtension? CreateModelElement(DXDrawCharts.CatAxExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.CatAxExtension();
      value.Uri = GetUri(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.CatAxExtension? value)
    where OpenXmlElementType: DXDrawCharts.CatAxExtension, new()
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
