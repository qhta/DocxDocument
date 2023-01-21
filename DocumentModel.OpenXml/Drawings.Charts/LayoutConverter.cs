namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Layout.
/// </summary>
public static class LayoutConverter
{
  /// <summary>
  /// Manual Layout.
  /// </summary>
  private static DMDrawsCharts.ManualLayout? GetManualLayout(DXDrawCharts.Layout openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ManualLayout>();
    if (itemElement != null)
      return DMXDrawsCharts.ManualLayoutConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetManualLayout(DXDrawCharts.Layout openXmlElement, DMDrawsCharts.ManualLayout? value)
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
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXDrawCharts.Layout openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDrawCharts.Layout openXmlElement, DMDrawsCharts.ExtensionList? value)
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
  
  public static DMDrawsCharts.Layout? CreateModelElement(DXDrawCharts.Layout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.Layout();
      value.ManualLayout = GetManualLayout(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Layout? value)
    where OpenXmlElementType: DXDrawCharts.Layout, new()
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
