namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the LineSerExtensionList Class.
/// </summary>
public static class LineSerExtensionListConverter
{
  private static Collection<DMDC.LineSerExtension>? GetLineSerExtensions(DXDC.LineSerExtensionList openXmlElement)
  {
    var collection = new Collection<DMDC.LineSerExtension>();
    foreach (var item in openXmlElement.Elements<DXDC.LineSerExtension>())
    {
      var newItem = DMXDC.LineSerExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpLineSerExtensions(DXDC.LineSerExtensionList openXmlElement, Collection<DMDC.LineSerExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.LineSerExtension>();
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
        if (!DMXDC.LineSerExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetLineSerExtensions(DXDC.LineSerExtensionList openXmlElement, Collection<DMDC.LineSerExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.LineSerExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.LineSerExtensionConverter.CreateOpenXmlElement<DXDC.LineSerExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMD.Charts.LineSerExtensionList? CreateModelElement(DXDC.LineSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.LineSerExtensionList();
      value.LineSerExtensions = GetLineSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.LineSerExtensionList? openXmlElement, DMDC.LineSerExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLineSerExtensions(openXmlElement, value.LineSerExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.LineSerExtensionList value)
    where OpenXmlElementType: DXDC.LineSerExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.LineSerExtensionList openXmlElement, DMDC.LineSerExtensionList value)
  {
    SetLineSerExtensions(openXmlElement, value?.LineSerExtensions);
  }
}
