namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the StringLevel Class.
/// </summary>
public static class StringLevelConverter
{
  /// <summary>
  /// ptCount, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetPtCount(DXO16DCD.StringLevel openXmlElement)
  {
    return openXmlElement?.PtCount?.Value;
  }
  
  private static bool CmpPtCount(DXO16DCD.StringLevel openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.PtCount?.Value == value) return true;
    diffs?.Add(objName, "PtCount", openXmlElement?.PtCount?.Value, value);
    return false;
  }
  
  private static void SetPtCount(DXO16DCD.StringLevel openXmlElement, UInt32? value)
  {
    openXmlElement.PtCount = value;
  }
  
  /// <summary>
  /// name, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetName(DXO16DCD.StringLevel openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXO16DCD.StringLevel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXO16DCD.StringLevel openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  private static Collection<DMDCDs.ChartStringValue>? GetChartStringValues(DXO16DCD.StringLevel openXmlElement)
  {
    var collection = new Collection<DMDCDs.ChartStringValue>();
    foreach (var item in openXmlElement.Elements<DXO16DCD.ChartStringValue>())
    {
      var newItem = DMXDCDs.ChartStringValueConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpChartStringValues(DXO16DCD.StringLevel openXmlElement, Collection<DMDCDs.ChartStringValue>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO16DCD.ChartStringValue>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDCDs.ChartStringValueConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetChartStringValues(DXO16DCD.StringLevel openXmlElement, Collection<DMDCDs.ChartStringValue>? value)
  {
    openXmlElement.RemoveAllChildren<DXO16DCD.ChartStringValue>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDCDs.ChartStringValueConverter.CreateOpenXmlElement<DXO16DCD.ChartStringValue>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.StringLevel? CreateModelElement(DXO16DCD.StringLevel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.StringLevel();
      value.PtCount = GetPtCount(openXmlElement);
      value.Name = GetName(openXmlElement);
      value.ChartStringValues = GetChartStringValues(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.StringLevel? openXmlElement, DMDCDs.StringLevel? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPtCount(openXmlElement, value.PtCount, diffs, objName))
        ok = false;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      if (!CmpChartStringValues(openXmlElement, value.ChartStringValues, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.StringLevel value)
    where OpenXmlElementType: DXO16DCD.StringLevel, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.StringLevel openXmlElement, DMDCDs.StringLevel value)
  {
    SetPtCount(openXmlElement, value?.PtCount);
    SetName(openXmlElement, value?.Name);
    SetChartStringValues(openXmlElement, value?.ChartStringValues);
  }
}
