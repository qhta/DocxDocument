namespace DocumentModel.OpenXml.Drawings.Office.OEmbed;

/// <summary>
/// Defines the OfficeArtExtensionList Class.
/// </summary>
public static class OfficeArtExtensionListConverter
{
  private static Collection<DMD.Extension>? GetExtensions(DXODY21OE.OfficeArtExtensionList openXmlElement)
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
  
  private static bool CmpExtensions(DXODY21OE.OfficeArtExtensionList openXmlElement, Collection<DMD.Extension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  private static void SetExtensions(DXODY21OE.OfficeArtExtensionList openXmlElement, Collection<DMD.Extension>? value)
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
  
  public static DMDO.OEmbed.OfficeArtExtensionList? CreateModelElement(DXODY21OE.OfficeArtExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDO.OEmbed.OfficeArtExtensionList();
      value.Extensions = GetExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXODY21OE.OfficeArtExtensionList? openXmlElement, DMDOOE.OfficeArtExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDOOE.OfficeArtExtensionList value)
    where OpenXmlElementType: DXODY21OE.OfficeArtExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXODY21OE.OfficeArtExtensionList openXmlElement, DMDOOE.OfficeArtExtensionList value)
  {
    SetExtensions(openXmlElement, value?.Extensions);
  }
}
