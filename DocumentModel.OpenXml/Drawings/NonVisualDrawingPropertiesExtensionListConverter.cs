namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualDrawingPropertiesExtensionList Class.
/// </summary>
public static class NonVisualDrawingPropertiesExtensionListConverter
{
  private static Collection<DMDraws.NonVisualDrawingPropertiesExtension> GetNonVisualDrawingPropertiesExtensions(DXDraw.NonVisualDrawingPropertiesExtensionList openXmlElement)
  {
    var collection = new Collection<DMDraws.NonVisualDrawingPropertiesExtension>();
    foreach (var item in openXmlElement.Elements<DXDraw.NonVisualDrawingPropertiesExtension>())
    {
      var newItem = DMXDraws.NonVisualDrawingPropertiesExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpNonVisualDrawingPropertiesExtensions(DXDraw.NonVisualDrawingPropertiesExtensionList openXmlElement, Collection<DMDraws.NonVisualDrawingPropertiesExtension>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDraw.NonVisualDrawingPropertiesExtension>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
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
        if (!DMXDraws.NonVisualDrawingPropertiesExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetNonVisualDrawingPropertiesExtensions(DXDraw.NonVisualDrawingPropertiesExtensionList openXmlElement, Collection<DMDraws.NonVisualDrawingPropertiesExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.NonVisualDrawingPropertiesExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.NonVisualDrawingPropertiesExtensionConverter.CreateOpenXmlElement<DXDraw.NonVisualDrawingPropertiesExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDraws.NonVisualDrawingPropertiesExtensionList? CreateModelElement(DXDraw.NonVisualDrawingPropertiesExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.NonVisualDrawingPropertiesExtensionList();
      value.NonVisualDrawingPropertiesExtensions = GetNonVisualDrawingPropertiesExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.NonVisualDrawingPropertiesExtensionList? openXmlElement, DMDraws.NonVisualDrawingPropertiesExtensionList? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.NonVisualDrawingPropertiesExtensionList? value)
    where OpenXmlElementType: DXDraw.NonVisualDrawingPropertiesExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNonVisualDrawingPropertiesExtensions(openXmlElement, value?.NonVisualDrawingPropertiesExtensions);
      return openXmlElement;
    }
    return default;
  }
}
