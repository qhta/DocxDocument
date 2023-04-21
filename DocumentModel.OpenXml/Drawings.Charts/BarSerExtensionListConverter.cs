namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BarSerExtensionList Class.
/// </summary>
public static class BarSerExtensionListConverter
{
  private static Collection<DMDC.BarSerExtension>? GetBarSerExtensions(DXDC.BarSerExtensionList openXmlElement)
  {
    var collection = new Collection<DMDC.BarSerExtension>();
    foreach (var item in openXmlElement.Elements<DXDC.BarSerExtension>())
    {
      var newItem = DMXDC.BarSerExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpBarSerExtensions(DXDC.BarSerExtensionList openXmlElement, Collection<DMDC.BarSerExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDC.BarSerExtension>();
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
        if (!DMXDC.BarSerExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetBarSerExtensions(DXDC.BarSerExtensionList openXmlElement, Collection<DMDC.BarSerExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.BarSerExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.BarSerExtensionConverter.CreateOpenXmlElement<DXDC.BarSerExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.BarSerExtensionList? CreateModelElement(DXDC.BarSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BarSerExtensionList();
      value.BarSerExtensions = GetBarSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.BarSerExtensionList? openXmlElement, DMDC.BarSerExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBarSerExtensions(openXmlElement, value.BarSerExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.BarSerExtensionList value)
    where OpenXmlElementType: DXDC.BarSerExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.BarSerExtensionList openXmlElement, DMDC.BarSerExtensionList value)
  {
    SetBarSerExtensions(openXmlElement, value?.BarSerExtensions);
  }
}
