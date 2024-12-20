namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the NumberingCache Class.
/// </summary>
public static class NumberingCacheConverter
{
  private static String? GetFormatCode(DXDrawCharts.NumberingCache openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.FormatCode>()?.Text;
  }
  
  private static bool CmpFormatCode(DXDrawCharts.NumberingCache openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.FormatCode>()?.Text == value;
  }
  
  private static void SetFormatCode(DXDrawCharts.NumberingCache openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.FormatCode>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.FormatCode { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static UInt32? GetPointCount(DXDrawCharts.NumberingCache openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.PointCount>()?.Val);
  }
  
  private static bool CmpPointCount(DXDrawCharts.NumberingCache openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.PointCount>()?.Val, value, diffs, objName, "PointCount");
  }
  
  private static void SetPointCount(DXDrawCharts.NumberingCache openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.PointCount,System.UInt32>(openXmlElement, value);
  }
  
  private static Collection<DMDrawsCharts.NumericPoint>? GetNumericPoints(DXDrawCharts.NumberingCache openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.NumericPoint>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.NumericPoint>())
    {
      var newItem = DMXDrawsCharts.NumericPointConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpNumericPoints(DXDrawCharts.NumberingCache openXmlElement, Collection<DMDrawsCharts.NumericPoint>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.NumericPoint>();
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
        if (!DMXDrawsCharts.NumericPointConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetNumericPoints(DXDrawCharts.NumberingCache openXmlElement, Collection<DMDrawsCharts.NumericPoint>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.NumericPoint>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.NumericPointConverter.CreateOpenXmlElement<DXDrawCharts.NumericPoint>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXDrawCharts.NumberingCache openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (element != null)
      return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDrawCharts.NumberingCache openXmlElement, DMDrawsCharts.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDrawCharts.NumberingCache openXmlElement, DMDrawsCharts.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.NumberingCache? CreateModelElement(DXDrawCharts.NumberingCache? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.NumberingCache();
      value.FormatCode = GetFormatCode(openXmlElement);
      value.PointCount = GetPointCount(openXmlElement);
      value.NumericPoints = GetNumericPoints(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.NumberingCache? openXmlElement, DMDrawsCharts.NumberingCache? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFormatCode(openXmlElement, value.FormatCode, diffs, objName))
        ok = false;
      if (!CmpPointCount(openXmlElement, value.PointCount, diffs, objName))
        ok = false;
      if (!CmpNumericPoints(openXmlElement, value.NumericPoints, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.NumberingCache value)
    where OpenXmlElementType: DXDrawCharts.NumberingCache, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.NumberingCache openXmlElement, DMDrawsCharts.NumberingCache value)
  {
    SetFormatCode(openXmlElement, value?.FormatCode);
    SetPointCount(openXmlElement, value?.PointCount);
    SetNumericPoints(openXmlElement, value?.NumericPoints);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
