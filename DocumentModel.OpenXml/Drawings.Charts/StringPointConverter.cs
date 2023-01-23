namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// String Point.
/// </summary>
public static class StringPointConverter
{
  /// <summary>
  /// Index
  /// </summary>
  private static UInt32? GetIndex(DXDrawCharts.StringPoint openXmlElement)
  {
    return openXmlElement.Index?.Value;
  }
  
  private static bool CmpIndex(DXDrawCharts.StringPoint openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Index?.Value == value;
  }
  
  private static void SetIndex(DXDrawCharts.StringPoint openXmlElement, UInt32? value)
  {
    openXmlElement.Index = value;
  }
  
  /// <summary>
  /// Text Value.
  /// </summary>
  private static String? GetNumericValue(DXDrawCharts.StringPoint openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.NumericValue>()?.Text;
  }
  
  private static bool CmpNumericValue(DXDrawCharts.StringPoint openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.NumericValue>()?.Text == value;
  }
  
  private static void SetNumericValue(DXDrawCharts.StringPoint openXmlElement, String? value)
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
  
  public static DMDrawsCharts.StringPoint? CreateModelElement(DXDrawCharts.StringPoint? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.StringPoint();
      value.Index = GetIndex(openXmlElement);
      value.NumericValue = GetNumericValue(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.StringPoint? openXmlElement, DMDrawsCharts.StringPoint? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIndex(openXmlElement, value.Index, diffs, objName))
        ok = false;
      if (!CmpNumericValue(openXmlElement, value.NumericValue, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.StringPoint? value)
    where OpenXmlElementType: DXDrawCharts.StringPoint, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIndex(openXmlElement, value?.Index);
      SetNumericValue(openXmlElement, value?.NumericValue);
      return openXmlElement;
    }
    return default;
  }
}
