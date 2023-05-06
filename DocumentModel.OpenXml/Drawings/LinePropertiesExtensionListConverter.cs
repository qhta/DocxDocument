namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Future extensions..
/// </summary>
public static class LinePropertiesExtensionListConverter
{
  private static Collection<DMD.LinePropertiesExtension>? GetLinePropertiesExtensions(DXD.LinePropertiesExtensionList openXmlElement)
  {
    var collection = new Collection<DMD.LinePropertiesExtension>();
    foreach (var item in openXmlElement.Elements<DXD.LinePropertiesExtension>())
    {
      var newItem = DMXD.LinePropertiesExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpLinePropertiesExtensions(DXD.LinePropertiesExtensionList openXmlElement, Collection<DMD.LinePropertiesExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXD.LinePropertiesExtension>();
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
        if (!DMXD.LinePropertiesExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetLinePropertiesExtensions(DXD.LinePropertiesExtensionList openXmlElement, Collection<DMD.LinePropertiesExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXD.LinePropertiesExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXD.LinePropertiesExtensionConverter.CreateOpenXmlElement<DXD.LinePropertiesExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.LinePropertiesExtensionList? CreateModelElement(DXD.LinePropertiesExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LinePropertiesExtensionList();
      value.LinePropertiesExtensions = GetLinePropertiesExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.LinePropertiesExtensionList? openXmlElement, DMD.LinePropertiesExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLinePropertiesExtensions(openXmlElement, value.LinePropertiesExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.LinePropertiesExtensionList value)
    where OpenXmlElementType: DXD.LinePropertiesExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.LinePropertiesExtensionList openXmlElement, DMD.LinePropertiesExtensionList value)
  {
    SetLinePropertiesExtensions(openXmlElement, value?.LinePropertiesExtensions);
  }
}
