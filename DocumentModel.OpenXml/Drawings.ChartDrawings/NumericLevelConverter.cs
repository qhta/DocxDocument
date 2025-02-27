namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the NumericLevel Class.
/// </summary>
public static class NumericLevelConverter
{
  /// <summary>
  /// ptCount, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetPtCount(DXO16DCD.NumericLevel openXmlElement)
  {
    return openXmlElement?.PtCount?.Value;
  }
  
  private static bool CmpPtCount(DXO16DCD.NumericLevel openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.PtCount?.Value == value) return true;
    diffs?.Add(objName, "PtCount", openXmlElement?.PtCount?.Value, value);
    return false;
  }
  
  private static void SetPtCount(DXO16DCD.NumericLevel openXmlElement, UInt32? value)
  {
    openXmlElement.PtCount = value;
  }
  
  /// <summary>
  /// formatCode, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetFormatCode(DXO16DCD.NumericLevel openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.FormatCode);
  }
  
  private static bool CmpFormatCode(DXO16DCD.NumericLevel openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.FormatCode, value, diffs, objName, "FormatCode");
  }
  
  private static void SetFormatCode(DXO16DCD.NumericLevel openXmlElement, String? value)
  {
    openXmlElement.FormatCode = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// name, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetName(DXO16DCD.NumericLevel openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXO16DCD.NumericLevel openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXO16DCD.NumericLevel openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  private static Collection<DMDCDs.NumericValue>? GetNumericValues(DXO16DCD.NumericLevel openXmlElement)
  {
    var collection = new Collection<DMDCDs.NumericValue>();
    foreach (var item in openXmlElement.Elements<DXO16DCD.NumericValue>())
    {
      var newItem = DMXDCDs.NumericValueConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpNumericValues(DXO16DCD.NumericLevel openXmlElement, Collection<DMDCDs.NumericValue>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXO16DCD.NumericValue>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, propName ?? openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDCDs.NumericValueConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetNumericValues(DXO16DCD.NumericLevel openXmlElement, Collection<DMDCDs.NumericValue>? value)
  {
    openXmlElement.RemoveAllChildren<DXO16DCD.NumericValue>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDCDs.NumericValueConverter.CreateOpenXmlElement<DXO16DCD.NumericValue>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMDCDs.NumericLevel? CreateModelElement(DXO16DCD.NumericLevel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.NumericLevel();
      value.PtCount = GetPtCount(openXmlElement);
      value.FormatCode = GetFormatCode(openXmlElement);
      value.Name = GetName(openXmlElement);
      value.NumericValues = GetNumericValues(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.NumericLevel? openXmlElement, DMDCDs.NumericLevel? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPtCount(openXmlElement, value.PtCount, diffs, objName, propName))
        ok = false;
      if (!CmpFormatCode(openXmlElement, value.FormatCode, diffs, objName, propName))
        ok = false;
      if (!CmpName(openXmlElement, value.Name, diffs, objName, propName))
        ok = false;
      if (!CmpNumericValues(openXmlElement, value.NumericValues, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.NumericLevel value)
    where OpenXmlElementType: DXO16DCD.NumericLevel, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.NumericLevel openXmlElement, DMDCDs.NumericLevel value)
  {
    SetPtCount(openXmlElement, value?.PtCount);
    SetFormatCode(openXmlElement, value?.FormatCode);
    SetName(openXmlElement, value?.Name);
    SetNumericValues(openXmlElement, value?.NumericValues);
  }
}
