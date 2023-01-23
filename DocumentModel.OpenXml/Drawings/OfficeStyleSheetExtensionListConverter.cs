namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the OfficeStyleSheetExtensionList Class.
/// </summary>
public static class OfficeStyleSheetExtensionListConverter
{
  private static Collection<DMDraws.OfficeStyleSheetExtension> GetOfficeStyleSheetExtensions(DXDraw.OfficeStyleSheetExtensionList openXmlElement)
  {
    var collection = new Collection<DMDraws.OfficeStyleSheetExtension>();
    foreach (var item in openXmlElement.Elements<DXDraw.OfficeStyleSheetExtension>())
    {
      var newItem = DMXDraws.OfficeStyleSheetExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpOfficeStyleSheetExtensions(DXDraw.OfficeStyleSheetExtensionList openXmlElement, Collection<DMDraws.OfficeStyleSheetExtension>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDraw.OfficeStyleSheetExtension>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().ToString()+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDraws.OfficeStyleSheetExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  private static void SetOfficeStyleSheetExtensions(DXDraw.OfficeStyleSheetExtensionList openXmlElement, Collection<DMDraws.OfficeStyleSheetExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.OfficeStyleSheetExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.OfficeStyleSheetExtensionConverter.CreateOpenXmlElement<DXDraw.OfficeStyleSheetExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDraws.OfficeStyleSheetExtensionList? CreateModelElement(DXDraw.OfficeStyleSheetExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.OfficeStyleSheetExtensionList();
      value.OfficeStyleSheetExtensions = GetOfficeStyleSheetExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.OfficeStyleSheetExtensionList? openXmlElement, DMDraws.OfficeStyleSheetExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpOfficeStyleSheetExtensions(openXmlElement, value.OfficeStyleSheetExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.OfficeStyleSheetExtensionList? value)
    where OpenXmlElementType: DXDraw.OfficeStyleSheetExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetOfficeStyleSheetExtensions(openXmlElement, value?.OfficeStyleSheetExtensions);
      return openXmlElement;
    }
    return default;
  }
}
