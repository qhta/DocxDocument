namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StringDataType Class converter from/to OpenXml.
///</summary>
public static class StringDataType3Converter
{
  /// <summary>
  /// PointCount.
  /// </summary>
  private static UInt32? GetPointCount(DXO2013DrawChart.StringDataType openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.PointCount>()?.Val);
  }
  
  private static bool CmpPointCount(DXO2013DrawChart.StringDataType openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.PointCount>()?.Val, value, diffs, objName, "PointCount");
  }
  
  private static void SetPointCount(DXO2013DrawChart.StringDataType openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.PointCount,System.UInt32>(openXmlElement, value);
  }
  
  public static DocumentModel.Drawings.Charts.StringDataType3? CreateModelElement(DXO2013DrawChart.StringDataType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StringDataType3();
      value.PointCount = GetPointCount(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013DrawChart.StringDataType? openXmlElement, DMDrawsCharts.StringDataType3? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.StringDataType3 value)
    where OpenXmlElementType: DXO2013DrawChart.StringDataType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013DrawChart.StringDataType openXmlElement, DMDrawsCharts.StringDataType3 value)
  {
    SetPointCount(openXmlElement, value?.PointCount);
  }
}
