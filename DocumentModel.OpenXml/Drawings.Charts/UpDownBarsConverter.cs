namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the UpDownBars Class.
/// </summary>
public static class UpDownBarsConverter
{
  /// <summary>
  /// Gap Width.
  /// </summary>
  private static UInt16? GetGapWidth(DXDrawCharts.UpDownBars openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.GapWidth>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetGapWidth(DXDrawCharts.UpDownBars openXmlElement, UInt16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.GapWidth>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.GapWidth{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Up Bars.
  /// </summary>
  private static DMDrawsCharts.UpBars? GetUpBars(DXDrawCharts.UpDownBars openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.UpBars>();
    if (itemElement != null)
      return DMXDrawsCharts.UpBarsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetUpBars(DXDrawCharts.UpDownBars openXmlElement, DMDrawsCharts.UpBars? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.UpBars>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.UpBarsConverter.CreateOpenXmlElement<DXDrawCharts.UpBars>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Down Bars.
  /// </summary>
  private static DMDrawsCharts.DownBars? GetDownBars(DXDrawCharts.UpDownBars openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.DownBars>();
    if (itemElement != null)
      return DMXDrawsCharts.DownBarsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDownBars(DXDrawCharts.UpDownBars openXmlElement, DMDrawsCharts.DownBars? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.DownBars>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.DownBarsConverter.CreateOpenXmlElement<DXDrawCharts.DownBars>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXDrawCharts.UpDownBars openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDrawCharts.UpDownBars openXmlElement, DMDrawsCharts.ExtensionList? value)
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
  
  public static DMDrawsCharts.UpDownBars? CreateModelElement(DXDrawCharts.UpDownBars? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.UpDownBars();
      value.GapWidth = GetGapWidth(openXmlElement);
      value.UpBars = GetUpBars(openXmlElement);
      value.DownBars = GetDownBars(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.UpDownBars? value)
    where OpenXmlElementType: DXDrawCharts.UpDownBars, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGapWidth(openXmlElement, value?.GapWidth);
      SetUpBars(openXmlElement, value?.UpBars);
      SetDownBars(openXmlElement, value?.DownBars);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
