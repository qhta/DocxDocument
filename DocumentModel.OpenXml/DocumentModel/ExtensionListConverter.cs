namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public static class ExtensionListConverter
{
  private static Collection<DM.Extension>? GetExtensions(DXO21DT.ExtensionList openXmlElement)
  {
    var collection = new Collection<DM.Extension>();
    foreach (var item in openXmlElement.Elements<DXO21OEL.Extension>())
    {
      var newItem = DMX.ExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpExtensions(DXO21DT.ExtensionList openXmlElement, Collection<DM.Extension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO21OEL.Extension>();
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
        if (!DMX.ExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetExtensions(DXO21DT.ExtensionList openXmlElement, Collection<DM.Extension>? value)
  {
    openXmlElement.RemoveAllChildren<DXO21OEL.Extension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMX.ExtensionConverter.CreateOpenXmlElement<DXO21OEL.Extension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.ExtensionList? CreateModelElement(DXO21DT.ExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.ExtensionList();
      value.Extensions = GetExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO21DT.ExtensionList? openXmlElement, DM.ExtensionList? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.ExtensionList value)
    where OpenXmlElementType: DXO21DT.ExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO21DT.ExtensionList openXmlElement, DM.ExtensionList value)
  {
    SetExtensions(openXmlElement, value?.Extensions);
  }
}
