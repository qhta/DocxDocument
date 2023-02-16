namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the NumericValue Class.
/// </summary>
public static class NumericValueConverter
{
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetIdx(DXO2016DrawChartDraw.NumericValue openXmlElement)
  {
    return openXmlElement?.Idx?.Value;
  }
  
  private static bool CmpIdx(DXO2016DrawChartDraw.NumericValue openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Idx?.Value == value) return true;
    diffs?.Add(objName, "Idx", openXmlElement?.Idx?.Value, value);
    return false;
  }
  
  private static void SetIdx(DXO2016DrawChartDraw.NumericValue openXmlElement, UInt32? value)
  {
    openXmlElement.Idx = value;
  }
  
  public static DocumentModel.Drawings.ChartDrawings.NumericValue? CreateModelElement(DXO2016DrawChartDraw.NumericValue? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.NumericValue();
      value.Idx = GetIdx(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.NumericValue? openXmlElement, DMDrawsChartDraws.NumericValue? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIdx(openXmlElement, value.Idx, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.NumericValue? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.NumericValue, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIdx(openXmlElement, value?.Idx);
      return openXmlElement;
    }
    return default;
  }
}
