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
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXDrawCharts.DateAxExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.NumberingFormat3? GetNumberingFormat(DXDrawCharts.DateAxExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.NumberingFormat>();
    if (itemElement != null)
      return DMXDrawsCharts.NumberingFormat3Converter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDrawsCharts.DateAxExtension? CreateModelElement(DXDrawCharts.DateAxExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.DateAxExtension();
      value.Uri = GetUri(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.DateAxExtension? value)
    where OpenXmlElementType: DXDrawCharts.DateAxExtension, new()
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
