namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the OfficeArtExtensionList Class.
/// </summary>
public static class OfficeArtExtensionList6Converter
{
  private static Collection<DMD.Extension>? GetExtensions(DXO21DSS.OfficeArtExtensionList openXmlElement)
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
  
  private static bool CmpExtensions(DXO21DSS.OfficeArtExtensionList openXmlElement, Collection<DMD.Extension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXD.Extension>();
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
        if (!DMXD.ExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetExtensions(DXO21DSS.OfficeArtExtensionList openXmlElement, Collection<DMD.Extension>? value)
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
  
  public static DocumentModel.Drawings.OfficeArtExtensionList6? CreateModelElement(DXO21DSS.OfficeArtExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.OfficeArtExtensionList6();
      value.Extensions = GetExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO21DSS.OfficeArtExtensionList? openXmlElement, DMD.OfficeArtExtensionList6? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtensions(openXmlElement, value.Extensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.OfficeArtExtensionList6 value)
    where OpenXmlElementType: DXO21DSS.OfficeArtExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO21DSS.OfficeArtExtensionList openXmlElement, DMD.OfficeArtExtensionList6 value)
  {
    SetExtensions(openXmlElement, value?.Extensions);
  }
}
