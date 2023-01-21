namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the PivotSource Class.
/// </summary>
public static class PivotSourceConverter
{
  /// <summary>
  /// Pivot Name.
  /// </summary>
  private static String? GetPivotTableName(DXDrawCharts.PivotSource openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.PivotTableName>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetPivotTableName(DXDrawCharts.PivotSource openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.PivotTableName>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.PivotTableName { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Format ID.
  /// </summary>
  private static UInt32? GetFormatId(DXDrawCharts.PivotSource openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.FormatId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetFormatId(DXDrawCharts.PivotSource openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.FormatId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.FormatId{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXDrawCharts.PivotSource openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDrawCharts.PivotSource openXmlElement, DMDrawsCharts.ExtensionList? value)
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
  
  public static DMDrawsCharts.PivotSource? CreateModelElement(DXDrawCharts.PivotSource? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.PivotSource();
      value.PivotTableName = GetPivotTableName(openXmlElement);
      value.FormatId = GetFormatId(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.PivotSource? value)
    where OpenXmlElementType: DXDrawCharts.PivotSource, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPivotTableName(openXmlElement, value?.PivotTableName);
      SetFormatId(openXmlElement, value?.FormatId);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
