namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Numeric Point.
/// </summary>
public static class NumericPointConverter
{
  /// <summary>
  /// Index
  /// </summary>
  private static UInt32? GetIndex(DXDrawCharts.NumericPoint openXmlElement)
  {
    return openXmlElement.Index?.Value;
  }
  
  private static void SetIndex(DXDrawCharts.NumericPoint openXmlElement, UInt32? value)
  {
    openXmlElement.Index = value;
  }
  
  /// <summary>
  /// Number Format
  /// </summary>
  private static String? GetFormatCode(DXDrawCharts.NumericPoint openXmlElement)
  {
    return openXmlElement?.FormatCode?.Value;
  }
  
  private static void SetFormatCode(DXDrawCharts.NumericPoint openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.FormatCode = new StringValue { Value = value };
    else
      openXmlElement.FormatCode = null;
  }
  
  /// <summary>
  /// Numeric Value.
  /// </summary>
  private static String? GetNumericValue(DXDrawCharts.NumericPoint openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.NumericValue>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetNumericValue(DXDrawCharts.NumericPoint openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.NumericValue>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.NumericValue { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.NumericPoint? CreateModelElement(DXDrawCharts.NumericPoint? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.NumericPoint();
      value.Index = GetIndex(openXmlElement);
      value.FormatCode = GetFormatCode(openXmlElement);
      value.NumericValue = GetNumericValue(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.NumericPoint? value)
    where OpenXmlElementType: DXDrawCharts.NumericPoint, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIndex(openXmlElement, value?.Index);
      SetFormatCode(openXmlElement, value?.FormatCode);
      SetNumericValue(openXmlElement, value?.NumericValue);
      return openXmlElement;
    }
    return default;
  }
}
