namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StringDataType Class.
/// </summary>
public static class StringDataTypeConverter
{
  /// <summary>
  /// PointCount.
  /// </summary>
  private static UInt32? GetPointCount(DXDrawCharts.StringDataType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.PointCount>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetPointCount(DXDrawCharts.StringDataType openXmlElement, UInt32? value)
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
  
  public static DMDrawsCharts.StringDataType? CreateModelElement(DXDrawCharts.StringDataType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.StringDataType();
      value.PointCount = GetPointCount(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.StringDataType? value)
    where OpenXmlElementType: DXDrawCharts.StringDataType, new()
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
