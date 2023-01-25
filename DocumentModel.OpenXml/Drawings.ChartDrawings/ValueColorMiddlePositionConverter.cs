namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ValueColorMiddlePosition Class.
/// </summary>
public static class ValueColorMiddlePositionConverter
{
  /// <summary>
  /// NumberColorPosition.
  /// </summary>
  private static Double? GetNumberColorPosition(DXO2016DrawChartDraw.ValueColorMiddlePosition openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.NumberColorPosition>()?.Val?.Value;
  }
  
  private static bool CmpNumberColorPosition(DXO2016DrawChartDraw.ValueColorMiddlePosition openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.NumberColorPosition>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXO2016DrawChartDraw.NumberColorPosition", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetNumberColorPosition(DXO2016DrawChartDraw.ValueColorMiddlePosition openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.NumberColorPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2016DrawChartDraw.NumberColorPosition{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// PercentageColorPosition.
  /// </summary>
  private static Double? GetPercentageColorPosition(DXO2016DrawChartDraw.ValueColorMiddlePosition openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.PercentageColorPosition>()?.Val?.Value;
  }
  
  private static bool CmpPercentageColorPosition(DXO2016DrawChartDraw.ValueColorMiddlePosition openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.PercentageColorPosition>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXO2016DrawChartDraw.PercentageColorPosition", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetPercentageColorPosition(DXO2016DrawChartDraw.ValueColorMiddlePosition openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.PercentageColorPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2016DrawChartDraw.PercentageColorPosition{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraws.ValueColorMiddlePosition? CreateModelElement(DXO2016DrawChartDraw.ValueColorMiddlePosition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.ValueColorMiddlePosition();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.ValueColorMiddlePosition? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.ValueColorMiddlePosition, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNumberColorPosition(openXmlElement, value?.NumberColorPosition);
      SetPercentageColorPosition(openXmlElement, value?.PercentageColorPosition);
      return openXmlElement;
    }
    return default;
  }
}
