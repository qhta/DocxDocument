namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DLblsExtensionList Class.
/// </summary>
public static class DLblsExtensionListConverter
{
  private static Collection<DMDC.DLblsExtension>? GetDLblsExtensions(DXDC.DLblsExtensionList openXmlElement)
  {
    var collection = new Collection<DMDC.DLblsExtension>();
    foreach (var item in openXmlElement.Elements<DXDC.DLblsExtension>())
    {
      var newItem = DMXDC.DLblsExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpDLblsExtensions(DXDC.DLblsExtensionList openXmlElement, Collection<DMDC.DLblsExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.DLblsExtension>();
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
        if (!DMXDC.DLblsExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetDLblsExtensions(DXDC.DLblsExtensionList openXmlElement, Collection<DMDC.DLblsExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.DLblsExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.DLblsExtensionConverter.CreateOpenXmlElement<DXDC.DLblsExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.DLblsExtensionList? CreateModelElement(DXDC.DLblsExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DLblsExtensionList();
      value.DLblsExtensions = GetDLblsExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.DLblsExtensionList? openXmlElement, DMDC.DLblsExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDLblsExtensions(openXmlElement, value.DLblsExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.DLblsExtensionList value)
    where OpenXmlElementType: DXDC.DLblsExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.DLblsExtensionList openXmlElement, DMDC.DLblsExtensionList value)
  {
    SetDLblsExtensions(openXmlElement, value?.DLblsExtensions);
  }
}
