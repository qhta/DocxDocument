namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StrDataExtensionList Class.
/// </summary>
public static class StrDataExtensionListConverter
{
  private static Collection<DMDC.StrDataExtension>? GetStrDataExtensions(DXDC.StrDataExtensionList openXmlElement)
  {
    var collection = new Collection<DMDC.StrDataExtension>();
    foreach (var item in openXmlElement.Elements<DXDC.StrDataExtension>())
    {
      var newItem = DMXDC.StrDataExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpStrDataExtensions(DXDC.StrDataExtensionList openXmlElement, Collection<DMDC.StrDataExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.StrDataExtension>();
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
        if (!DMXDC.StrDataExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetStrDataExtensions(DXDC.StrDataExtensionList openXmlElement, Collection<DMDC.StrDataExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.StrDataExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.StrDataExtensionConverter.CreateOpenXmlElement<DXDC.StrDataExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.StrDataExtensionList? CreateModelElement(DXDC.StrDataExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StrDataExtensionList();
      value.StrDataExtensions = GetStrDataExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.StrDataExtensionList? openXmlElement, DMDC.StrDataExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpStrDataExtensions(openXmlElement, value.StrDataExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.StrDataExtensionList value)
    where OpenXmlElementType: DXDC.StrDataExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.StrDataExtensionList openXmlElement, DMDC.StrDataExtensionList value)
  {
    SetStrDataExtensions(openXmlElement, value?.StrDataExtensions);
  }
}
