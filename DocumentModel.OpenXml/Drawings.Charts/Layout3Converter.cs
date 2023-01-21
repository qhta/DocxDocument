namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Layout Class.
/// </summary>
public static class Layout3Converter
{
  /// <summary>
  /// Manual Layout.
  /// </summary>
  private static DMDrawsCharts.ManualLayout? GetManualLayout(DXO2013DrawChart.Layout openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ManualLayout>();
    if (itemElement != null)
      return DMXDrawsCharts.ManualLayoutConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetManualLayout(DXO2013DrawChart.Layout openXmlElement, DMDrawsCharts.ManualLayout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ManualLayout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ManualLayoutConverter.CreateOpenXmlElement<DXDrawCharts.ManualLayout>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXO2013DrawChart.Layout openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXO2013DrawChart.Layout openXmlElement, DMDrawsCharts.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.Layout3? CreateModelElement(DXO2013DrawChart.Layout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.Layout3();
      value.ManualLayout = GetManualLayout(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Layout3? value)
    where OpenXmlElementType: DXO2013DrawChart.Layout, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetManualLayout(openXmlElement, value?.ManualLayout);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
