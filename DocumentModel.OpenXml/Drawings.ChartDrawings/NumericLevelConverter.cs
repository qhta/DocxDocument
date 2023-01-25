namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the NumericLevel Class.
/// </summary>
public static class NumericLevelConverter
{
  /// <summary>
  /// ptCount, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetPtCount(DXO2016DrawChartDraw.NumericLevel openXmlElement)
  {
    return openXmlElement?.PtCount?.Value;
  }
  
  private static bool CmpPtCount(DXO2016DrawChartDraw.NumericLevel openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.PtCount?.Value == value) return true;
    diffs?.Add(objName, "PtCount", openXmlElement?.PtCount?.Value, value);
    return false;
  }
  
  private static void SetPtCount(DXO2016DrawChartDraw.NumericLevel openXmlElement, UInt32? value)
  {
    openXmlElement.PtCount = value;
  }
  
  /// <summary>
  /// formatCode, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetFormatCode(DXO2016DrawChartDraw.NumericLevel openXmlElement)
  {
    return openXmlElement?.FormatCode?.Value;
  }
  
  private static bool CmpFormatCode(DXO2016DrawChartDraw.NumericLevel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.FormatCode?.Value == value;
  }
  
  private static void SetFormatCode(DXO2016DrawChartDraw.NumericLevel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.FormatCode = new StringValue { Value = value };
    else
      openXmlElement.FormatCode = null;
  }
  
  /// <summary>
  /// name, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetName(DXO2016DrawChartDraw.NumericLevel openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static bool CmpName(DXO2016DrawChartDraw.NumericLevel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Name?.Value == value;
  }
  
  private static void SetName(DXO2016DrawChartDraw.NumericLevel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  private static Collection<DMDrawsChartDraws.NumericValue> GetNumericValues(DXO2016DrawChartDraw.NumericLevel openXmlElement)
  {
    var collection = new Collection<DMDrawsChartDraws.NumericValue>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.NumericValue>())
    {
      var newItem = DMXDrawsChartDraws.NumericValueConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpNumericValues(DXO2016DrawChartDraw.NumericLevel openXmlElement, Collection<DMDrawsChartDraws.NumericValue>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXO2016DrawChartDraw.NumericValue>();
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
        if (!DMXDrawsChartDraws.NumericValueConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetNumericValues(DXO2016DrawChartDraw.NumericLevel openXmlElement, Collection<DMDrawsChartDraws.NumericValue>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.NumericValue>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsChartDraws.NumericValueConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.NumericValue>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsChartDraws.NumericLevel? CreateModelElement(DXO2016DrawChartDraw.NumericLevel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.NumericLevel();
      value.PtCount = GetPtCount(openXmlElement);
      value.FormatCode = GetFormatCode(openXmlElement);
      value.Name = GetName(openXmlElement);
      value.NumericValues = GetNumericValues(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.NumericLevel? openXmlElement, DMDrawsChartDraws.NumericLevel? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPtCount(openXmlElement, value.PtCount, diffs, objName))
        ok = false;
      if (!CmpFormatCode(openXmlElement, value.FormatCode, diffs, objName))
        ok = false;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      if (!CmpNumericValues(openXmlElement, value.NumericValues, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.NumericLevel? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.NumericLevel, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPtCount(openXmlElement, value?.PtCount);
      SetFormatCode(openXmlElement, value?.FormatCode);
      SetName(openXmlElement, value?.Name);
      SetNumericValues(openXmlElement, value?.NumericValues);
      return openXmlElement;
    }
    return default;
  }
}
