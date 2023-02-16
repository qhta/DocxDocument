namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ShapePropertiesExtensionList Class.
/// </summary>
public static class ShapePropertiesExtensionListConverter
{
  private static Collection<DMDraws.ShapePropertiesExtension>? GetShapePropertiesExtensions(DXDraw.ShapePropertiesExtensionList openXmlElement)
  {
    var collection = new Collection<DMDraws.ShapePropertiesExtension>();
    foreach (var item in openXmlElement.Elements<DXDraw.ShapePropertiesExtension>())
    {
      var newItem = DMXDraws.ShapePropertiesExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpShapePropertiesExtensions(DXDraw.ShapePropertiesExtensionList openXmlElement, Collection<DMDraws.ShapePropertiesExtension>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDraw.ShapePropertiesExtension>();
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
        if (!DMXDraws.ShapePropertiesExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetShapePropertiesExtensions(DXDraw.ShapePropertiesExtensionList openXmlElement, Collection<DMDraws.ShapePropertiesExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.ShapePropertiesExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.ShapePropertiesExtensionConverter.CreateOpenXmlElement<DXDraw.ShapePropertiesExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.ShapePropertiesExtensionList? CreateModelElement(DXDraw.ShapePropertiesExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ShapePropertiesExtensionList();
      value.ShapePropertiesExtensions = GetShapePropertiesExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.ShapePropertiesExtensionList? openXmlElement, DMDraws.ShapePropertiesExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpShapePropertiesExtensions(openXmlElement, value.ShapePropertiesExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ShapePropertiesExtensionList? value)
    where OpenXmlElementType: DXDraw.ShapePropertiesExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetShapePropertiesExtensions(openXmlElement, value?.ShapePropertiesExtensions);
      return openXmlElement;
    }
    return default;
  }
}
