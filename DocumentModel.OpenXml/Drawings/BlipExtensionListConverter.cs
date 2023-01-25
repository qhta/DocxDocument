namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Future extensions..
/// </summary>
public static class BlipExtensionListConverter
{
  private static Collection<DMDraws.BlipExtension> GetBlipExtensions(DXDraw.BlipExtensionList openXmlElement)
  {
    var collection = new Collection<DMDraws.BlipExtension>();
    foreach (var item in openXmlElement.Elements<DXDraw.BlipExtension>())
    {
      var newItem = DMXDraws.BlipExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpBlipExtensions(DXDraw.BlipExtensionList openXmlElement, Collection<DMDraws.BlipExtension>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDraw.BlipExtension>();
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
        if (!DMXDraws.BlipExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetBlipExtensions(DXDraw.BlipExtensionList openXmlElement, Collection<DMDraws.BlipExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.BlipExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.BlipExtensionConverter.CreateOpenXmlElement<DXDraw.BlipExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDraws.BlipExtensionList? CreateModelElement(DXDraw.BlipExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.BlipExtensionList();
      value.BlipExtensions = GetBlipExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.BlipExtensionList? openXmlElement, DMDraws.BlipExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBlipExtensions(openXmlElement, value.BlipExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.BlipExtensionList? value)
    where OpenXmlElementType: DXDraw.BlipExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBlipExtensions(openXmlElement, value?.BlipExtensions);
      return openXmlElement;
    }
    return default;
  }
}
