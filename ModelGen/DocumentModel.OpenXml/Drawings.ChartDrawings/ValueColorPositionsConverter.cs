namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ValueColorPositions Class.
/// </summary>
public static class ValueColorPositionsConverter
{
  /// <summary>
  /// count, this property is only available in Office 2016 and later.
  /// </summary>
  private static Int32? GetCount(DXO2016DrawChartDraw.ValueColorPositions openXmlElement)
  {
    return openXmlElement?.Count?.Value;
  }
  
  private static bool CmpCount(DXO2016DrawChartDraw.ValueColorPositions openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Count?.Value == value) return true;
    diffs?.Add(objName, "Count", openXmlElement?.Count?.Value, value);
    return false;
  }
  
  private static void SetCount(DXO2016DrawChartDraw.ValueColorPositions openXmlElement, Int32? value)
  {
    openXmlElement.Count = value;
  }
  
  /// <summary>
  /// MinValueColorEndPosition.
  /// </summary>
  private static DMDrawsChartDraws.MinValueColorEndPosition? GetMinValueColorEndPosition(DXO2016DrawChartDraw.ValueColorPositions openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.MinValueColorEndPosition>();
    if (element != null)
      return DMXDrawsChartDraws.MinValueColorEndPositionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMinValueColorEndPosition(DXO2016DrawChartDraw.ValueColorPositions openXmlElement, DMDrawsChartDraws.MinValueColorEndPosition? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.MinValueColorEndPositionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.MinValueColorEndPosition>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMinValueColorEndPosition(DXO2016DrawChartDraw.ValueColorPositions openXmlElement, DMDrawsChartDraws.MinValueColorEndPosition? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.MinValueColorEndPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.MinValueColorEndPositionConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.MinValueColorEndPosition>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ValueColorMiddlePosition.
  /// </summary>
  private static DMDrawsChartDraws.ValueColorMiddlePosition? GetValueColorMiddlePosition(DXO2016DrawChartDraw.ValueColorPositions openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ValueColorMiddlePosition>();
    if (element != null)
      return DMXDrawsChartDraws.ValueColorMiddlePositionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpValueColorMiddlePosition(DXO2016DrawChartDraw.ValueColorPositions openXmlElement, DMDrawsChartDraws.ValueColorMiddlePosition? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ValueColorMiddlePositionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ValueColorMiddlePosition>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetValueColorMiddlePosition(DXO2016DrawChartDraw.ValueColorPositions openXmlElement, DMDrawsChartDraws.ValueColorMiddlePosition? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ValueColorMiddlePosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.ValueColorMiddlePositionConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.ValueColorMiddlePosition>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// MaxValueColorEndPosition.
  /// </summary>
  private static DMDrawsChartDraws.MaxValueColorEndPosition? GetMaxValueColorEndPosition(DXO2016DrawChartDraw.ValueColorPositions openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.MaxValueColorEndPosition>();
    if (element != null)
      return DMXDrawsChartDraws.MaxValueColorEndPositionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMaxValueColorEndPosition(DXO2016DrawChartDraw.ValueColorPositions openXmlElement, DMDrawsChartDraws.MaxValueColorEndPosition? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.MaxValueColorEndPositionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.MaxValueColorEndPosition>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMaxValueColorEndPosition(DXO2016DrawChartDraw.ValueColorPositions openXmlElement, DMDrawsChartDraws.MaxValueColorEndPosition? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.MaxValueColorEndPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.MaxValueColorEndPositionConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.MaxValueColorEndPosition>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ValueColorPositions? CreateModelElement(DXO2016DrawChartDraw.ValueColorPositions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ValueColorPositions();
      value.Count = GetCount(openXmlElement);
      value.MinValueColorEndPosition = GetMinValueColorEndPosition(openXmlElement);
      value.ValueColorMiddlePosition = GetValueColorMiddlePosition(openXmlElement);
      value.MaxValueColorEndPosition = GetMaxValueColorEndPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.ValueColorPositions? openXmlElement, DMDrawsChartDraws.ValueColorPositions? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCount(openXmlElement, value.Count, diffs, objName))
        ok = false;
      if (!CmpMinValueColorEndPosition(openXmlElement, value.MinValueColorEndPosition, diffs, objName))
        ok = false;
      if (!CmpValueColorMiddlePosition(openXmlElement, value.ValueColorMiddlePosition, diffs, objName))
        ok = false;
      if (!CmpMaxValueColorEndPosition(openXmlElement, value.MaxValueColorEndPosition, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.ValueColorPositions value)
    where OpenXmlElementType: DXO2016DrawChartDraw.ValueColorPositions, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.ValueColorPositions openXmlElement, DMDrawsChartDraws.ValueColorPositions value)
  {
    SetCount(openXmlElement, value?.Count);
    SetMinValueColorEndPosition(openXmlElement, value?.MinValueColorEndPosition);
    SetValueColorMiddlePosition(openXmlElement, value?.ValueColorMiddlePosition);
    SetMaxValueColorEndPosition(openXmlElement, value?.MaxValueColorEndPosition);
  }
}
