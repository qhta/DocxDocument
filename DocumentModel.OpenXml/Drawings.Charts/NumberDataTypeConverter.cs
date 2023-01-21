namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the NumberDataType Class.
/// </summary>
public static class NumberDataTypeConverter
{
  /// <summary>
  /// Format Code.
  /// </summary>
  private static String? GetFormatCode(DXDrawCharts.NumberDataType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.FormatCode>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetFormatCode(DXDrawCharts.NumberDataType openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.FormatCode>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.FormatCode { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Point Count.
  /// </summary>
  private static UInt32? GetPointCount(DXDrawCharts.NumberDataType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.PointCount>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetPointCount(DXDrawCharts.NumberDataType openXmlElement, UInt32? value)
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
  
  public static DMDrawsCharts.NumberDataType? CreateModelElement(DXDrawCharts.NumberDataType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.NumberDataType();
      value.FormatCode = GetFormatCode(openXmlElement);
      value.PointCount = GetPointCount(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.NumberDataType? value)
    where OpenXmlElementType: DXDrawCharts.NumberDataType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFormatCode(openXmlElement, value?.FormatCode);
      SetPointCount(openXmlElement, value?.PointCount);
      return openXmlElement;
    }
    return default;
  }
}
