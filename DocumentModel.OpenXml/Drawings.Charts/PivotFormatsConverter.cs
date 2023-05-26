namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// pivot chart format persistence data.
/// </summary>
public static class PivotFormatsConverter
{
  private static Collection<DMDC.PivotFormat>? GetItems(DXDC.PivotFormats openXmlElement)
  {
    var collection = new Collection<DMDC.PivotFormat>();
    foreach (var item in openXmlElement.Elements<DXDC.PivotFormat>())
    {
      var newItem = DMXDC.PivotFormatConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXDC.PivotFormats openXmlElement, Collection<DMDC.PivotFormat>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.PivotFormat>();
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
        if (!DMXDC.PivotFormatConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXDC.PivotFormats openXmlElement, Collection<DMDC.PivotFormat>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.PivotFormat>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.PivotFormatConverter.CreateOpenXmlElement<DXDC.PivotFormat>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.PivotFormats? CreateModelElement(DXDC.PivotFormats? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PivotFormats();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.PivotFormats? openXmlElement, DMDC.PivotFormats? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.PivotFormats value)
    where OpenXmlElementType: DXDC.PivotFormats, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.PivotFormats openXmlElement, DMDC.PivotFormats value)
  {
    SetItems(openXmlElement, value?.Items);
  }
}
