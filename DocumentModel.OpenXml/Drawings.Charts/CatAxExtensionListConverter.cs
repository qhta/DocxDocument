namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the CatAxExtensionList Class.
/// </summary>
public static class CatAxExtensionListConverter
{
  private static Collection<DMDC.CatAxExtension>? GetCatAxExtensions(DXDC.CatAxExtensionList openXmlElement)
  {
    var collection = new Collection<DMDC.CatAxExtension>();
    foreach (var item in openXmlElement.Elements<DXDC.CatAxExtension>())
    {
      var newItem = DMXDC.CatAxExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpCatAxExtensions(DXDC.CatAxExtensionList openXmlElement, Collection<DMDC.CatAxExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.CatAxExtension>();
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
        if (!DMXDC.CatAxExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetCatAxExtensions(DXDC.CatAxExtensionList openXmlElement, Collection<DMDC.CatAxExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.CatAxExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.CatAxExtensionConverter.CreateOpenXmlElement<DXDC.CatAxExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.CatAxExtensionList? CreateModelElement(DXDC.CatAxExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.CatAxExtensionList();
      value.CatAxExtensions = GetCatAxExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.CatAxExtensionList? openXmlElement, DMDC.CatAxExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCatAxExtensions(openXmlElement, value.CatAxExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.CatAxExtensionList value)
    where OpenXmlElementType: DXDC.CatAxExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.CatAxExtensionList openXmlElement, DMDC.CatAxExtensionList value)
  {
    SetCatAxExtensions(openXmlElement, value?.CatAxExtensions);
  }
}
