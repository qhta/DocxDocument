namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the StringLevel Class converter from/to OpenXml.
///</summary>
public static class StringLevelConverter
{
  /// <summary>
  /// ptCount, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetPtCount(DXO2016DrawChartDraw.StringLevel openXmlElement)
  {
    return openXmlElement?.PtCount?.Value;
  }
  
  private static bool CmpPtCount(DXO2016DrawChartDraw.StringLevel openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.PtCount?.Value == value) return true;
    diffs?.Add(objName, "PtCount", openXmlElement?.PtCount?.Value, value);
    return false;
  }
  
  private static void SetPtCount(DXO2016DrawChartDraw.StringLevel openXmlElement, UInt32? value)
  {
    openXmlElement.PtCount = value;
  }
  
  /// <summary>
  /// name, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetName(DXO2016DrawChartDraw.StringLevel openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXO2016DrawChartDraw.StringLevel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXO2016DrawChartDraw.StringLevel openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  private static Collection<DMDrawsChartDraws.ChartStringValue>? GetChartStringValues(DXO2016DrawChartDraw.StringLevel openXmlElement)
  {
    var collection = new Collection<DMDrawsChartDraws.ChartStringValue>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.ChartStringValue>())
    {
      var newItem = DMXDrawsChartDraws.ChartStringValueConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpChartStringValues(DXO2016DrawChartDraw.StringLevel openXmlElement, Collection<DMDrawsChartDraws.ChartStringValue>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO2016DrawChartDraw.ChartStringValue>();
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
        if (!DMXDrawsChartDraws.ChartStringValueConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetChartStringValues(DXO2016DrawChartDraw.StringLevel openXmlElement, Collection<DMDrawsChartDraws.ChartStringValue>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.ChartStringValue>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsChartDraws.ChartStringValueConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.ChartStringValue>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.StringLevel? CreateModelElement(DXO2016DrawChartDraw.StringLevel? openXmlElement)
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
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.StringLevel? openXmlElement, DMDrawsChartDraws.StringLevel? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.StringLevel value)
    where OpenXmlElementType: DXO2016DrawChartDraw.StringLevel, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.StringLevel openXmlElement, DMDrawsChartDraws.StringLevel value)
  {
    SetPtCount(openXmlElement, value?.PtCount);
    SetName(openXmlElement, value?.Name);
    SetChartStringValues(openXmlElement, value?.ChartStringValues);
  }
}
