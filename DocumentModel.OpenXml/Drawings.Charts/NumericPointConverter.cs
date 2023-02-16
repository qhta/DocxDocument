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
    return openXmlElement?.Index?.Value;
  }
  
  private static bool CmpIndex(DXDrawCharts.NumericPoint openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Index?.Value == value) return true;
    diffs?.Add(objName, "Index", openXmlElement?.Index?.Value, value);
    return false;
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
  
  private static bool CmpFormatCode(DXDrawCharts.NumericPoint openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.FormatCode?.Value == value) return true;
    diffs?.Add(objName, "FormatCode", openXmlElement?.FormatCode?.Value, value);
    return false;
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
      return openXmlElement?.GetFirstChild<DXDrawCharts.NumericValue>()?.Text;
  }
  
  private static bool CmpNumericValue(DXDrawCharts.NumericPoint openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.NumericValue>()?.Text == value;
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
  
  public static DocumentModel.Drawings.Charts.NumericPoint? CreateModelElement(DXDrawCharts.NumericPoint? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.NumericPoint();
      value.Index = GetIndex(openXmlElement);
      value.FormatCode = GetFormatCode(openXmlElement);
      value.NumericValue = GetNumericValue(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.NumericPoint? openXmlElement, DMDrawsCharts.NumericPoint? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIndex(openXmlElement, value.Index, diffs, objName))
        ok = false;
      if (!CmpFormatCode(openXmlElement, value.FormatCode, diffs, objName))
        ok = false;
      if (!CmpNumericValue(openXmlElement, value.NumericValue, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
