namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Future extensions..
/// </summary>
public static class LinePropertiesExtensionListConverter
{
  private static Collection<DMDraws.LinePropertiesExtension>? GetLinePropertiesExtensions(DXDraw.LinePropertiesExtensionList openXmlElement)
  {
    var collection = new Collection<DMDraws.LinePropertiesExtension>();
    foreach (var item in openXmlElement.Elements<DXDraw.LinePropertiesExtension>())
    {
      var newItem = DMXDraws.LinePropertiesExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpLinePropertiesExtensions(DXDraw.LinePropertiesExtensionList openXmlElement, Collection<DMDraws.LinePropertiesExtension>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDraw.LinePropertiesExtension>();
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
        if (!DMXDraws.LinePropertiesExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetLinePropertiesExtensions(DXDraw.LinePropertiesExtensionList openXmlElement, Collection<DMDraws.LinePropertiesExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.LinePropertiesExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.LinePropertiesExtensionConverter.CreateOpenXmlElement<DXDraw.LinePropertiesExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.LinePropertiesExtensionList? CreateModelElement(DXDraw.LinePropertiesExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LinePropertiesExtensionList();
      value.LinePropertiesExtensions = GetLinePropertiesExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.LinePropertiesExtensionList? openXmlElement, DMDraws.LinePropertiesExtensionList? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.LinePropertiesExtensionList? value)
    where OpenXmlElementType: DXDraw.LinePropertiesExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLinePropertiesExtensions(openXmlElement, value?.LinePropertiesExtensions);
      return openXmlElement;
    }
    return default;
  }
}
