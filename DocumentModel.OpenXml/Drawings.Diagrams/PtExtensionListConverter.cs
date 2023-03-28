namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the PtExtensionList Class converter from/to OpenXml.
///</summary>
public static class PtExtensionListConverter
{
  private static Collection<DMDraws.PtExtension>? GetPtExtensions(DXDrawDgms.PtExtensionList openXmlElement)
  {
    var collection = new Collection<DMDraws.PtExtension>();
    foreach (var item in openXmlElement.Elements<DXDraw.PtExtension>())
    {
      var newItem = DMXDraws.PtExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpPtExtensions(DXDrawDgms.PtExtensionList openXmlElement, Collection<DMDraws.PtExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDraw.PtExtension>();
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
        if (!DMXDraws.PtExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetPtExtensions(DXDrawDgms.PtExtensionList openXmlElement, Collection<DMDraws.PtExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.PtExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.PtExtensionConverter.CreateOpenXmlElement<DXDraw.PtExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.PtExtensionList? CreateModelElement(DXDrawDgms.PtExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.PtExtensionList();
      value.PtExtensions = GetPtExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.PtExtensionList? openXmlElement, DMDrawsDgms.PtExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPtExtensions(openXmlElement, value.PtExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.PtExtensionList value)
    where OpenXmlElementType: DXDrawDgms.PtExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.PtExtensionList openXmlElement, DMDrawsDgms.PtExtensionList value)
  {
    SetPtExtensions(openXmlElement, value?.PtExtensions);
  }
}
