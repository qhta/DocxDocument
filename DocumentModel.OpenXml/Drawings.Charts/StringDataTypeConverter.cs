namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StringDataType Class converter from/to OpenXml.
///</summary>
public static class StringDataTypeConverter
{
  /// <summary>
  /// PointCount.
  /// </summary>
  private static UInt32? GetPointCount(DXDrawCharts.StringDataType openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.PointCount>()?.Val);
  }
  
  private static bool CmpPointCount(DXDrawCharts.StringDataType openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.PointCount>()?.Val, value, diffs, objName, "PointCount");
  }
  
  private static void SetPointCount(DXDrawCharts.StringDataType openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.PointCount,System.UInt32>(openXmlElement, value);
  }
  
  public static DocumentModel.Drawings.Charts.StringDataType? CreateModelElement(DXDrawCharts.StringDataType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StringDataType();
      value.PointCount = GetPointCount(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.StringDataType? openXmlElement, DMDrawsCharts.StringDataType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPointCount(openXmlElement, value.PointCount, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.StringDataType value)
    where OpenXmlElementType: DXDrawCharts.StringDataType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.StringDataType openXmlElement, DMDrawsCharts.StringDataType value)
  {
    SetPointCount(openXmlElement, value?.PointCount);
  }
}
