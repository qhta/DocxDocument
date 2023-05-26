namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the AreaSerExtensionList Class.
/// </summary>
public static class AreaSerExtensionListConverter
{
  private static Collection<DMDC.AreaSerExtension>? GetAreaSerExtensions(DXDC.AreaSerExtensionList openXmlElement)
  {
    var collection = new Collection<DMDC.AreaSerExtension>();
    foreach (var item in openXmlElement.Elements<DXDC.AreaSerExtension>())
    {
      var newItem = DMXDC.AreaSerExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpAreaSerExtensions(DXDC.AreaSerExtensionList openXmlElement, Collection<DMDC.AreaSerExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.AreaSerExtension>();
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
        if (!DMXDC.AreaSerExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetAreaSerExtensions(DXDC.AreaSerExtensionList openXmlElement, Collection<DMDC.AreaSerExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.AreaSerExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.AreaSerExtensionConverter.CreateOpenXmlElement<DXDC.AreaSerExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.AreaSerExtensionList? CreateModelElement(DXDC.AreaSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.AreaSerExtensionList();
      value.AreaSerExtensions = GetAreaSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.AreaSerExtensionList? openXmlElement, DMDC.AreaSerExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAreaSerExtensions(openXmlElement, value.AreaSerExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.AreaSerExtensionList value)
    where OpenXmlElementType: DXDC.AreaSerExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.AreaSerExtensionList openXmlElement, DMDC.AreaSerExtensionList value)
  {
    SetAreaSerExtensions(openXmlElement, value?.AreaSerExtensions);
  }
}
