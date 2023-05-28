namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Future extensions..
/// </summary>
public static class BlipExtensionListConverter
{
  private static Collection<DMD.BlipExtension>? GetBlipExtensions(DXD.BlipExtensionList openXmlElement)
  {
    var collection = new Collection<DMD.BlipExtension>();
    foreach (var item in openXmlElement.Elements<DXD.BlipExtension>())
    {
      var newItem = DMXD.BlipExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpBlipExtensions(DXD.BlipExtensionList openXmlElement, Collection<DMD.BlipExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXD.BlipExtension>();
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
        if (!DMXD.BlipExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetBlipExtensions(DXD.BlipExtensionList openXmlElement, Collection<DMD.BlipExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXD.BlipExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXD.BlipExtensionConverter.CreateOpenXmlElement<DXD.BlipExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMD.BlipExtensionList? CreateModelElement(DXD.BlipExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.BlipExtensionList();
      value.BlipExtensions = GetBlipExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.BlipExtensionList? openXmlElement, DMD.BlipExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBlipExtensions(openXmlElement, value.BlipExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.BlipExtensionList value)
    where OpenXmlElementType: DXD.BlipExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.BlipExtensionList openXmlElement, DMD.BlipExtensionList value)
  {
    SetBlipExtensions(openXmlElement, value?.BlipExtensions);
  }
}
