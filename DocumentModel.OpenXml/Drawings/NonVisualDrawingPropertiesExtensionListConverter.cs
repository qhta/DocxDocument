namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualDrawingPropertiesExtensionList Class.
/// </summary>
public static class NonVisualDrawingPropertiesExtensionListConverter
{
  private static Collection<DMD.NonVisualDrawingPropertiesExtension>? GetNonVisualDrawingPropertiesExtensions(DXD.NonVisualDrawingPropertiesExtensionList openXmlElement)
  {
    var collection = new Collection<DMD.NonVisualDrawingPropertiesExtension>();
    foreach (var item in openXmlElement.Elements<DXD.NonVisualDrawingPropertiesExtension>())
    {
      var newItem = DMXD.NonVisualDrawingPropertiesExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpNonVisualDrawingPropertiesExtensions(DXD.NonVisualDrawingPropertiesExtensionList openXmlElement, Collection<DMD.NonVisualDrawingPropertiesExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXD.NonVisualDrawingPropertiesExtension>();
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
        if (!DMXD.NonVisualDrawingPropertiesExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetNonVisualDrawingPropertiesExtensions(DXD.NonVisualDrawingPropertiesExtensionList openXmlElement, Collection<DMD.NonVisualDrawingPropertiesExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXD.NonVisualDrawingPropertiesExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXD.NonVisualDrawingPropertiesExtensionConverter.CreateOpenXmlElement<DXD.NonVisualDrawingPropertiesExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.NonVisualDrawingPropertiesExtensionList? CreateModelElement(DXD.NonVisualDrawingPropertiesExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.NonVisualDrawingPropertiesExtensionList();
      value.NonVisualDrawingPropertiesExtensions = GetNonVisualDrawingPropertiesExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.NonVisualDrawingPropertiesExtensionList? openXmlElement, DMD.NonVisualDrawingPropertiesExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNonVisualDrawingPropertiesExtensions(openXmlElement, value.NonVisualDrawingPropertiesExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.NonVisualDrawingPropertiesExtensionList value)
    where OpenXmlElementType: DXD.NonVisualDrawingPropertiesExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.NonVisualDrawingPropertiesExtensionList openXmlElement, DMD.NonVisualDrawingPropertiesExtensionList value)
  {
    SetNonVisualDrawingPropertiesExtensions(openXmlElement, value?.NonVisualDrawingPropertiesExtensions);
  }
}
