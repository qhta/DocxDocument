namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the PtExtensionList Class.
/// </summary>
public static class PtExtensionListConverter
{
  private static Collection<DMD.PtExtension>? GetPtExtensions(DXDD.PtExtensionList openXmlElement)
  {
    var collection = new Collection<DMD.PtExtension>();
    foreach (var item in openXmlElement.Elements<DXD.PtExtension>())
    {
      var newItem = DMXD.PtExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpPtExtensions(DXDD.PtExtensionList openXmlElement, Collection<DMD.PtExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXD.PtExtension>();
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
        if (!DMXD.PtExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetPtExtensions(DXDD.PtExtensionList openXmlElement, Collection<DMD.PtExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXD.PtExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXD.PtExtensionConverter.CreateOpenXmlElement<DXD.PtExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMDD.PtExtensionList? CreateModelElement(DXDD.PtExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDD.PtExtensionList();
      value.PtExtensions = GetPtExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.PtExtensionList? openXmlElement, DMDD.PtExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPtExtensions(openXmlElement, value.PtExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.PtExtensionList value)
    where OpenXmlElementType: DXDD.PtExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.PtExtensionList openXmlElement, DMDD.PtExtensionList value)
  {
    SetPtExtensions(openXmlElement, value?.PtExtensions);
  }
}
