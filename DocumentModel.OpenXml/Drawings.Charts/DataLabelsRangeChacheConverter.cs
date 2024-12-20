namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DataLabelsRangeChache Class.
/// </summary>
public static class DataLabelsRangeChacheConverter
{
  private static UInt32? GetPointCount(DXO13DC.DataLabelsRangeChache openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.PointCount>()?.Val);
  }
  
  private static bool CmpPointCount(DXO13DC.DataLabelsRangeChache openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.PointCount>()?.Val, value, diffs, objName, "PointCount");
  }
  
  private static void SetPointCount(DXO13DC.DataLabelsRangeChache openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.PointCount,System.UInt32>(openXmlElement, value);
  }
  
  private static Collection<DMDC.StringPoint>? GetStringPoints(DXO13DC.DataLabelsRangeChache openXmlElement)
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
  
  private static bool CmpStringPoints(DXO13DC.DataLabelsRangeChache openXmlElement, Collection<DMDC.StringPoint>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.StringPoint>();
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
        if (!DMXDC.StringPointConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetStringPoints(DXO13DC.DataLabelsRangeChache openXmlElement, Collection<DMDC.StringPoint>? value)
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
  
  private static DMDC.StrDataExtensionList? GetStrDataExtensionList(DXO13DC.DataLabelsRangeChache openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.StrDataExtensionList>();
    if (element != null)
      return DMXDC.StrDataExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStrDataExtensionList(DXO13DC.DataLabelsRangeChache openXmlElement, DMDC.StrDataExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.StrDataExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.StrDataExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetStrDataExtensionList(DXO13DC.DataLabelsRangeChache openXmlElement, DMDC.StrDataExtensionList? value)
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
  
  public static DMD.Charts.DataLabelsRangeChache? CreateModelElement(DXO13DC.DataLabelsRangeChache? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.DataLabelsRangeChache();
      value.PointCount = GetPointCount(openXmlElement);
      value.StringPoints = GetStringPoints(openXmlElement);
      value.StrDataExtensionList = GetStrDataExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13DC.DataLabelsRangeChache? openXmlElement, DMDC.DataLabelsRangeChache? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPointCount(openXmlElement, value.PointCount, diffs, objName, propName))
        ok = false;
      if (!CmpStringPoints(openXmlElement, value.StringPoints, diffs, objName, propName))
        ok = false;
      if (!CmpStrDataExtensionList(openXmlElement, value.StrDataExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.DataLabelsRangeChache value)
    where OpenXmlElementType: DXO13DC.DataLabelsRangeChache, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DC.DataLabelsRangeChache openXmlElement, DMDC.DataLabelsRangeChache value)
  {
    SetPointCount(openXmlElement, value?.PointCount);
    SetStringPoints(openXmlElement, value?.StringPoints);
    SetStrDataExtensionList(openXmlElement, value?.StrDataExtensionList);
  }
}
