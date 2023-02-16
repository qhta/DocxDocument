namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ChartStringValue Class.
/// </summary>
public static class ChartStringValueConverter
{
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetIndex(DXO2016DrawChartDraw.ChartStringValue openXmlElement)
  {
    return openXmlElement?.Index?.Value;
  }
  
  private static bool CmpIndex(DXO2016DrawChartDraw.ChartStringValue openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Index?.Value == value) return true;
    diffs?.Add(objName, "Index", openXmlElement?.Index?.Value, value);
    return false;
  }
  
  private static void SetIndex(DXO2016DrawChartDraw.ChartStringValue openXmlElement, UInt32? value)
  {
    openXmlElement.Index = value;
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ChartStringValue? CreateModelElement(DXO2016DrawChartDraw.ChartStringValue? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ChartStringValue();
      value.Index = GetIndex(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.ChartStringValue? openXmlElement, DMDrawsChartDraws.ChartStringValue? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIndex(openXmlElement, value.Index, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.ChartStringValue? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.ChartStringValue, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIndex(openXmlElement, value?.Index);
      return openXmlElement;
    }
    return default;
  }
}
