namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the OfficeStyleSheetExtensionList Class.
/// </summary>
public static class OfficeStyleSheetExtensionListConverter
{
  private static Collection<DMD.OfficeStyleSheetExtension>? GetOfficeStyleSheetExtensions(DXD.OfficeStyleSheetExtensionList openXmlElement)
  {
    var collection = new Collection<DMD.OfficeStyleSheetExtension>();
    foreach (var item in openXmlElement.Elements<DXD.OfficeStyleSheetExtension>())
    {
      var newItem = DMXD.OfficeStyleSheetExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpOfficeStyleSheetExtensions(DXD.OfficeStyleSheetExtensionList openXmlElement, Collection<DMD.OfficeStyleSheetExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXD.OfficeStyleSheetExtension>();
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
        if (!DMXD.OfficeStyleSheetExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetOfficeStyleSheetExtensions(DXD.OfficeStyleSheetExtensionList openXmlElement, Collection<DMD.OfficeStyleSheetExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXD.OfficeStyleSheetExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXD.OfficeStyleSheetExtensionConverter.CreateOpenXmlElement<DXD.OfficeStyleSheetExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.OfficeStyleSheetExtensionList? CreateModelElement(DXD.OfficeStyleSheetExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.OfficeStyleSheetExtensionList();
      value.OfficeStyleSheetExtensions = GetOfficeStyleSheetExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.OfficeStyleSheetExtensionList? openXmlElement, DMD.OfficeStyleSheetExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpOfficeStyleSheetExtensions(openXmlElement, value.OfficeStyleSheetExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.OfficeStyleSheetExtensionList value)
    where OpenXmlElementType: DXD.OfficeStyleSheetExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.OfficeStyleSheetExtensionList openXmlElement, DMD.OfficeStyleSheetExtensionList value)
  {
    SetOfficeStyleSheetExtensions(openXmlElement, value?.OfficeStyleSheetExtensions);
  }
}
