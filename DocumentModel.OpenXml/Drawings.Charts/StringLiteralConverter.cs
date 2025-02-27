namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// String Literal.
/// </summary>
public static class StringLiteralConverter
{
  private static UInt32? GetPointCount(DXDC.StringLiteral openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.PointCount>()?.Val);
  }
  
  private static bool CmpPointCount(DXDC.StringLiteral openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.PointCount>()?.Val, value, diffs, objName, "PointCount");
  }
  
  private static void SetPointCount(DXDC.StringLiteral openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.PointCount,System.UInt32>(openXmlElement, value);
  }
  
  private static Collection<DMDC.StringPoint>? GetStringPoints(DXDC.StringLiteral openXmlElement)
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
  
  private static bool CmpStringPoints(DXDC.StringLiteral openXmlElement, Collection<DMDC.StringPoint>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  private static void SetStringPoints(DXDC.StringLiteral openXmlElement, Collection<DMDC.StringPoint>? value)
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
  
  private static DMDC.StrDataExtensionList? GetStrDataExtensionList(DXDC.StringLiteral openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.StrDataExtensionList>();
    if (element != null)
      return DMXDC.StrDataExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStrDataExtensionList(DXDC.StringLiteral openXmlElement, DMDC.StrDataExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.StrDataExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.StrDataExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetStrDataExtensionList(DXDC.StringLiteral openXmlElement, DMDC.StrDataExtensionList? value)
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
  
  public static DMD.Charts.StringLiteral? CreateModelElement(DXDC.StringLiteral? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.StringLiteral();
      value.PointCount = GetPointCount(openXmlElement);
      value.StringPoints = GetStringPoints(openXmlElement);
      value.StrDataExtensionList = GetStrDataExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.StringLiteral? openXmlElement, DMDC.StringLiteral? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.StringLiteral value)
    where OpenXmlElementType: DXDC.StringLiteral, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.StringLiteral openXmlElement, DMDC.StringLiteral value)
  {
    SetPointCount(openXmlElement, value?.PointCount);
    SetStringPoints(openXmlElement, value?.StringPoints);
    SetStrDataExtensionList(openXmlElement, value?.StrDataExtensionList);
  }
}
