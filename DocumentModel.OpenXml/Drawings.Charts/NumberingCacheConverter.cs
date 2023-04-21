namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the NumberingCache Class.
/// </summary>
public static class NumberingCacheConverter
{
  private static String? GetFormatCode(DXDC.NumberingCache openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDC.FormatCode>()?.Text;
  }
  
  private static bool CmpFormatCode(DXDC.NumberingCache openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDC.FormatCode>()?.Text == value;
  }
  
  private static void SetFormatCode(DXDC.NumberingCache openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.FormatCode>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDC.FormatCode { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static UInt32? GetPointCount(DXDC.NumberingCache openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.PointCount>()?.Val);
  }
  
  private static bool CmpPointCount(DXDC.NumberingCache openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.PointCount>()?.Val, value, diffs, objName, "PointCount");
  }
  
  private static void SetPointCount(DXDC.NumberingCache openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.PointCount,System.UInt32>(openXmlElement, value);
  }
  
  private static Collection<DMDC.NumericPoint>? GetNumericPoints(DXDC.NumberingCache openXmlElement)
  {
    var collection = new Collection<DMDC.NumericPoint>();
    foreach (var item in openXmlElement.Elements<DXDC.NumericPoint>())
    {
      var newItem = DMXDC.NumericPointConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpNumericPoints(DXDC.NumberingCache openXmlElement, Collection<DMDC.NumericPoint>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDC.NumericPoint>();
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
        if (!DMXDC.NumericPointConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetNumericPoints(DXDC.NumberingCache openXmlElement, Collection<DMDC.NumericPoint>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.NumericPoint>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.NumericPointConverter.CreateOpenXmlElement<DXDC.NumericPoint>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDC.ExtensionList? GetExtensionList(DXDC.NumberingCache openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ExtensionList>();
    if (element != null)
      return DMXDC.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDC.NumberingCache openXmlElement, DMDC.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXDC.NumberingCache openXmlElement, DMDC.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ExtensionListConverter.CreateOpenXmlElement<DXDC.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.NumberingCache? CreateModelElement(DXDC.NumberingCache? openXmlElement)
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
  
  public static bool CompareModelElement(DXDC.NumberingCache? openXmlElement, DMDC.NumberingCache? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.NumberingCache value)
    where OpenXmlElementType: DXDC.NumberingCache, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.NumberingCache openXmlElement, DMDC.NumberingCache value)
  {
    SetFormatCode(openXmlElement, value?.FormatCode);
    SetPointCount(openXmlElement, value?.PointCount);
    SetNumericPoints(openXmlElement, value?.NumericPoints);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
