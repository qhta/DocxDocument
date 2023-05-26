namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ValueColorPositions Class.
/// </summary>
public static class ValueColorPositionsConverter
{
  /// <summary>
  /// count, this property is only available in Office 2016 and later.
  /// </summary>
  private static Int32? GetCount(DXO16DCD.ValueColorPositions openXmlElement)
  {
    return openXmlElement?.Count?.Value;
  }
  
  private static bool CmpCount(DXO16DCD.ValueColorPositions openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Count?.Value == value) return true;
    diffs?.Add(objName, "Count", openXmlElement?.Count?.Value, value);
    return false;
  }
  
  private static void SetCount(DXO16DCD.ValueColorPositions openXmlElement, Int32? value)
  {
    openXmlElement.Count = value;
  }
  
  /// <summary>
  /// MinValueColorEndPosition.
  /// </summary>
  private static DMDCDs.MinValueColorEndPosition? GetMinValueColorEndPosition(DXO16DCD.ValueColorPositions openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.MinValueColorEndPosition>();
    if (element != null)
      return DMXDCDs.MinValueColorEndPositionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMinValueColorEndPosition(DXO16DCD.ValueColorPositions openXmlElement, DMDCDs.MinValueColorEndPosition? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.MinValueColorEndPositionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.MinValueColorEndPosition>(), value, diffs, objName, propName);
  }
  
  private static void SetMinValueColorEndPosition(DXO16DCD.ValueColorPositions openXmlElement, DMDCDs.MinValueColorEndPosition? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.MinValueColorEndPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.MinValueColorEndPositionConverter.CreateOpenXmlElement<DXO16DCD.MinValueColorEndPosition>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ValueColorMiddlePosition.
  /// </summary>
  private static DMDCDs.ValueColorMiddlePosition? GetValueColorMiddlePosition(DXO16DCD.ValueColorPositions openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ValueColorMiddlePosition>();
    if (element != null)
      return DMXDCDs.ValueColorMiddlePositionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpValueColorMiddlePosition(DXO16DCD.ValueColorPositions openXmlElement, DMDCDs.ValueColorMiddlePosition? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.ValueColorMiddlePositionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ValueColorMiddlePosition>(), value, diffs, objName, propName);
  }
  
  private static void SetValueColorMiddlePosition(DXO16DCD.ValueColorPositions openXmlElement, DMDCDs.ValueColorMiddlePosition? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.ValueColorMiddlePosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.ValueColorMiddlePositionConverter.CreateOpenXmlElement<DXO16DCD.ValueColorMiddlePosition>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// MaxValueColorEndPosition.
  /// </summary>
  private static DMDCDs.MaxValueColorEndPosition? GetMaxValueColorEndPosition(DXO16DCD.ValueColorPositions openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.MaxValueColorEndPosition>();
    if (element != null)
      return DMXDCDs.MaxValueColorEndPositionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMaxValueColorEndPosition(DXO16DCD.ValueColorPositions openXmlElement, DMDCDs.MaxValueColorEndPosition? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.MaxValueColorEndPositionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.MaxValueColorEndPosition>(), value, diffs, objName, propName);
  }
  
  private static void SetMaxValueColorEndPosition(DXO16DCD.ValueColorPositions openXmlElement, DMDCDs.MaxValueColorEndPosition? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.MaxValueColorEndPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.MaxValueColorEndPositionConverter.CreateOpenXmlElement<DXO16DCD.MaxValueColorEndPosition>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ValueColorPositions? CreateModelElement(DXO16DCD.ValueColorPositions? openXmlElement)
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
  
  public static bool CompareModelElement(DXO16DCD.ValueColorPositions? openXmlElement, DMDCDs.ValueColorPositions? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCount(openXmlElement, value.Count, diffs, objName, propName))
        ok = false;
      if (!CmpMinValueColorEndPosition(openXmlElement, value.MinValueColorEndPosition, diffs, objName, propName))
        ok = false;
      if (!CmpValueColorMiddlePosition(openXmlElement, value.ValueColorMiddlePosition, diffs, objName, propName))
        ok = false;
      if (!CmpMaxValueColorEndPosition(openXmlElement, value.MaxValueColorEndPosition, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.ValueColorPositions value)
    where OpenXmlElementType: DXO16DCD.ValueColorPositions, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.ValueColorPositions openXmlElement, DMDCDs.ValueColorPositions value)
  {
    SetCount(openXmlElement, value?.Count);
    SetMinValueColorEndPosition(openXmlElement, value?.MinValueColorEndPosition);
    SetValueColorMiddlePosition(openXmlElement, value?.ValueColorMiddlePosition);
    SetMaxValueColorEndPosition(openXmlElement, value?.MaxValueColorEndPosition);
  }
}
