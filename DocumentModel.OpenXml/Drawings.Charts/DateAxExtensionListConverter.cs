namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DateAxExtensionList Class.
/// </summary>
public static class DateAxExtensionListConverter
{
  private static Collection<DMDC.DateAxExtension>? GetDateAxExtensions(DXDC.DateAxExtensionList openXmlElement)
  {
    var collection = new Collection<DMDC.DateAxExtension>();
    foreach (var item in openXmlElement.Elements<DXDC.DateAxExtension>())
    {
      var newItem = DMXDC.DateAxExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpDateAxExtensions(DXDC.DateAxExtensionList openXmlElement, Collection<DMDC.DateAxExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDC.DateAxExtension>();
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
        if (!DMXDC.DateAxExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetDateAxExtensions(DXDC.DateAxExtensionList openXmlElement, Collection<DMDC.DateAxExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.DateAxExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.DateAxExtensionConverter.CreateOpenXmlElement<DXDC.DateAxExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.DateAxExtensionList? CreateModelElement(DXDC.DateAxExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DateAxExtensionList();
      value.DateAxExtensions = GetDateAxExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.DateAxExtensionList? openXmlElement, DMDC.DateAxExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDateAxExtensions(openXmlElement, value.DateAxExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.DateAxExtensionList value)
    where OpenXmlElementType: DXDC.DateAxExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.DateAxExtensionList openXmlElement, DMDC.DateAxExtensionList value)
  {
    SetDateAxExtensions(openXmlElement, value?.DateAxExtensions);
  }
}
