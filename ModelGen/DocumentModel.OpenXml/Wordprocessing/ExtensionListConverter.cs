namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public static class ExtensionListConverter
{
  private static Collection<DMW.Extension>? GetExtensions(DXO2021WComtExt.ExtensionList openXmlElement)
  {
    var collection = new Collection<DMW.Extension>();
    foreach (var item in openXmlElement.Elements<DXO2021WExtList.Extension>())
    {
      var newItem = DMXW.ExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpExtensions(DXO2021WComtExt.ExtensionList openXmlElement, Collection<DMW.Extension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO2021WExtList.Extension>();
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
        if (!DMXW.ExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetExtensions(DXO2021WComtExt.ExtensionList openXmlElement, Collection<DMW.Extension>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2021WExtList.Extension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.ExtensionConverter.CreateOpenXmlElement<DXO2021WExtList.Extension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.ExtensionList? CreateModelElement(DXO2021WComtExt.ExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ExtensionList();
      value.Extensions = GetExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2021WComtExt.ExtensionList? openXmlElement, DMW.ExtensionList? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.ExtensionList value)
    where OpenXmlElementType: DXO2021WComtExt.ExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2021WComtExt.ExtensionList openXmlElement, DMW.ExtensionList value)
  {
    SetExtensions(openXmlElement, value?.Extensions);
  }
}
