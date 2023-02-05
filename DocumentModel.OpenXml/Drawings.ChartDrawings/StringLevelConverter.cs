namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the StringLevel Class.
/// </summary>
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
    return openXmlElement?.Name?.Value;
  }
  
  private static bool CmpName(DXO2016DrawChartDraw.StringLevel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Name?.Value == value) return true;
    diffs?.Add(objName, "Name", openXmlElement?.Name?.Value, value);
    return false;
  }
  
  private static void SetName(DXO2016DrawChartDraw.StringLevel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  private static Collection<DMDrawsChartDraws.ChartStringValue> GetChartStringValues(DXO2016DrawChartDraw.StringLevel openXmlElement)
  {
    var collection = new Collection<DMDrawsChartDraws.ChartStringValue>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.ChartStringValue>())
    {
      var newItem = DMXDrawsChartDraws.ChartStringValueConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpChartStringValues(DXO2016DrawChartDraw.StringLevel openXmlElement, Collection<DMDrawsChartDraws.ChartStringValue>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXO2016DrawChartDraw.ChartStringValue>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
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
    if (openXmlElement == null && value == null) return true;
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
  
  public static DMDrawsChartDraws.StringLevel? CreateModelElement(DXO2016DrawChartDraw.StringLevel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.StringLevel();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.StringLevel? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.StringLevel, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPtCount(openXmlElement, value?.PtCount);
      SetName(openXmlElement, value?.Name);
      SetChartStringValues(openXmlElement, value?.ChartStringValues);
      return openXmlElement;
    }
    return default;
  }
}
