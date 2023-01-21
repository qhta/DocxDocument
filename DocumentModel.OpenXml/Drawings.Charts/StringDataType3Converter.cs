namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StringDataType Class.
/// </summary>
public static class StringDataType3Converter
{
  /// <summary>
  /// PointCount.
  /// </summary>
  private static UInt32? GetPointCount(DXO2013DrawChart.StringDataType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.PointCount>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetPointCount(DXO2013DrawChart.StringDataType openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.PointCount>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.PointCount{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.StringDataType3? CreateModelElement(DXO2013DrawChart.StringDataType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.StringDataType3();
      value.PointCount = GetPointCount(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.StringDataType3? value)
    where OpenXmlElementType: DXO2013DrawChart.StringDataType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPointCount(openXmlElement, value?.PointCount);
      return openXmlElement;
    }
    return default;
  }
}
