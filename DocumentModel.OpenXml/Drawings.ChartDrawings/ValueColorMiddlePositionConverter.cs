namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ValueColorMiddlePosition Class converter from/to OpenXml.
///</summary>
public static class ValueColorMiddlePositionConverter
{
  /// <summary>
  /// NumberColorPosition.
  /// </summary>
  private static Double? GetNumberColorPosition(DXO2016DrawChartDraw.ValueColorMiddlePosition openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.NumberColorPosition>()?.Val);
  }
  
  private static bool CmpNumberColorPosition(DXO2016DrawChartDraw.ValueColorMiddlePosition openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.NumberColorPosition>()?.Val, value, diffs, objName, "NumberColorPosition");
  }
  
  private static void SetNumberColorPosition(DXO2016DrawChartDraw.ValueColorMiddlePosition openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXO2016DrawChartDraw.NumberColorPosition,System.Double>(openXmlElement, value);
  }
  
  /// <summary>
  /// PercentageColorPosition.
  /// </summary>
  private static Double? GetPercentageColorPosition(DXO2016DrawChartDraw.ValueColorMiddlePosition openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.PercentageColorPosition>()?.Val);
  }
  
  private static bool CmpPercentageColorPosition(DXO2016DrawChartDraw.ValueColorMiddlePosition openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.PercentageColorPosition>()?.Val, value, diffs, objName, "PercentageColorPosition");
  }
  
  private static void SetPercentageColorPosition(DXO2016DrawChartDraw.ValueColorMiddlePosition openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXO2016DrawChartDraw.PercentageColorPosition,System.Double>(openXmlElement, value);
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ValueColorMiddlePosition? CreateModelElement(DXO2016DrawChartDraw.ValueColorMiddlePosition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ValueColorMiddlePosition();
      value.NumberColorPosition = GetNumberColorPosition(openXmlElement);
      value.PercentageColorPosition = GetPercentageColorPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.ValueColorMiddlePosition? openXmlElement, DMDrawsChartDraws.ValueColorMiddlePosition? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNumberColorPosition(openXmlElement, value.NumberColorPosition, diffs, objName))
        ok = false;
      if (!CmpPercentageColorPosition(openXmlElement, value.PercentageColorPosition, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.ValueColorMiddlePosition value)
    where OpenXmlElementType: DXO2016DrawChartDraw.ValueColorMiddlePosition, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.ValueColorMiddlePosition openXmlElement, DMDrawsChartDraws.ValueColorMiddlePosition value)
  {
    SetNumberColorPosition(openXmlElement, value?.NumberColorPosition);
    SetPercentageColorPosition(openXmlElement, value?.PercentageColorPosition);
  }
}
