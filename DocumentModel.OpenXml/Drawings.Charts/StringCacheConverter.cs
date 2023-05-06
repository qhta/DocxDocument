namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StringCache Class.
/// </summary>
public static class StringCacheConverter
{
  private static UInt32? GetPointCount(DXDC.StringCache openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.PointCount>()?.Val);
  }
  
  private static bool CmpPointCount(DXDC.StringCache openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.PointCount>()?.Val, value, diffs, objName, "PointCount");
  }
  
  private static void SetPointCount(DXDC.StringCache openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.PointCount,System.UInt32>(openXmlElement, value);
  }
  
  private static Collection<DMDC.StringPoint>? GetStringPoints(DXDC.StringCache openXmlElement)
  {
    var collection = new Collection<DMDC.StringPoint>();
    foreach (var item in openXmlElement.Elements<DXDC.StringPoint>())
    {
      var newItem = DMXDC.StringPointConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpStringPoints(DXDC.StringCache openXmlElement, Collection<DMDC.StringPoint>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDC.StringPoint>();
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
        if (!DMXDC.StringPointConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetStringPoints(DXDC.StringCache openXmlElement, Collection<DMDC.StringPoint>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.StringPoint>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.StringPointConverter.CreateOpenXmlElement<DXDC.StringPoint>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  private static DMDC.StrDataExtensionList? GetStrDataExtensionList(DXDC.StringCache openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.StrDataExtensionList>();
    if (element != null)
      return DMXDC.StrDataExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStrDataExtensionList(DXDC.StringCache openXmlElement, DMDC.StrDataExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDC.StrDataExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.StrDataExtensionList>(), value, diffs, objName);
  }
  
  private static void SetStrDataExtensionList(DXDC.StringCache openXmlElement, DMDC.StrDataExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.StrDataExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.StrDataExtensionListConverter.CreateOpenXmlElement<DXDC.StrDataExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.StringCache? CreateModelElement(DXDC.StringCache? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StringCache();
      value.PointCount = GetPointCount(openXmlElement);
      value.StringPoints = GetStringPoints(openXmlElement);
      value.StrDataExtensionList = GetStrDataExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.StringCache? openXmlElement, DMDC.StringCache? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPointCount(openXmlElement, value.PointCount, diffs, objName))
        ok = false;
      if (!CmpStringPoints(openXmlElement, value.StringPoints, diffs, objName))
        ok = false;
      if (!CmpStrDataExtensionList(openXmlElement, value.StrDataExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.StringCache value)
    where OpenXmlElementType: DXDC.StringCache, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.StringCache openXmlElement, DMDC.StringCache value)
  {
    SetPointCount(openXmlElement, value?.PointCount);
    SetStringPoints(openXmlElement, value?.StringPoints);
    SetStrDataExtensionList(openXmlElement, value?.StrDataExtensionList);
  }
}
