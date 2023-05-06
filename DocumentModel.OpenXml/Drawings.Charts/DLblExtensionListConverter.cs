namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DLblExtensionList Class.
/// </summary>
public static class DLblExtensionListConverter
{
  private static Collection<DMDC.DLblExtension>? GetDLblExtensions(DXDC.DLblExtensionList openXmlElement)
  {
    var collection = new Collection<DMDC.DLblExtension>();
    foreach (var item in openXmlElement.Elements<DXDC.DLblExtension>())
    {
      var newItem = DMXDC.DLblExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpDLblExtensions(DXDC.DLblExtensionList openXmlElement, Collection<DMDC.DLblExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDC.DLblExtension>();
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
        if (!DMXDC.DLblExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetDLblExtensions(DXDC.DLblExtensionList openXmlElement, Collection<DMDC.DLblExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.DLblExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.DLblExtensionConverter.CreateOpenXmlElement<DXDC.DLblExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.DLblExtensionList? CreateModelElement(DXDC.DLblExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DLblExtensionList();
      value.DLblExtensions = GetDLblExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.DLblExtensionList? openXmlElement, DMDC.DLblExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDLblExtensions(openXmlElement, value.DLblExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.DLblExtensionList value)
    where OpenXmlElementType: DXDC.DLblExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.DLblExtensionList openXmlElement, DMDC.DLblExtensionList value)
  {
    SetDLblExtensions(openXmlElement, value?.DLblExtensions);
  }
}
