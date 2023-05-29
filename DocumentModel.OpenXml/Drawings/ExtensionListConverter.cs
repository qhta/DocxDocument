namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public static class ExtensionListConverter
{
  private static Collection<DMD.Extension>? GetExtensions(DXD.ExtensionList openXmlElement)
  {
    var collection = new Collection<DMD.Extension>();
    foreach (var item in openXmlElement.Elements<DXD.Extension>())
    {
      var newItem = DMXD.ExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpExtensions(DXD.ExtensionList openXmlElement, Collection<DMD.Extension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXD.Extension>();
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
        if (!DMXD.ExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetExtensions(DXD.ExtensionList openXmlElement, Collection<DMD.Extension>? value)
  {
    openXmlElement.RemoveAllChildren<DXD.Extension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXD.ExtensionConverter.CreateOpenXmlElement<DXD.Extension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMD.ExtensionList? CreateModelElement(DXD.ExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.ExtensionList();
      value.Extensions = GetExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.ExtensionList? openXmlElement, DMD.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtensions(openXmlElement, value.Extensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static DXD.ExtensionList CreateOpenXmlElement(DMD.ExtensionList value)
  {
    var openXmlElement = new DXD.ExtensionList();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.ExtensionList openXmlElement, DMD.ExtensionList value)
  {
    SetExtensions(openXmlElement, value?.Extensions);
  }
}
