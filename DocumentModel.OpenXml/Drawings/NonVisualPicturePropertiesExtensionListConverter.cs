namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualPicturePropertiesExtensionList Class.
/// </summary>
public static class NonVisualPicturePropertiesExtensionListConverter
{
  private static Collection<DMDraws.NonVisualPicturePropertiesExtension> GetNonVisualPicturePropertiesExtensions(DXDraw.NonVisualPicturePropertiesExtensionList openXmlElement)
  {
    var collection = new Collection<DMDraws.NonVisualPicturePropertiesExtension>();
    foreach (var item in openXmlElement.Elements<DXDraw.NonVisualPicturePropertiesExtension>())
    {
      var newItem = DMXDraws.NonVisualPicturePropertiesExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpNonVisualPicturePropertiesExtensions(DXDraw.NonVisualPicturePropertiesExtensionList openXmlElement, Collection<DMDraws.NonVisualPicturePropertiesExtension>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDraw.NonVisualPicturePropertiesExtension>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().ToString()+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDraws.NonVisualPicturePropertiesExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  private static void SetNonVisualPicturePropertiesExtensions(DXDraw.NonVisualPicturePropertiesExtensionList openXmlElement, Collection<DMDraws.NonVisualPicturePropertiesExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.NonVisualPicturePropertiesExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.NonVisualPicturePropertiesExtensionConverter.CreateOpenXmlElement<DXDraw.NonVisualPicturePropertiesExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDraws.NonVisualPicturePropertiesExtensionList? CreateModelElement(DXDraw.NonVisualPicturePropertiesExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.NonVisualPicturePropertiesExtensionList();
      value.NonVisualPicturePropertiesExtensions = GetNonVisualPicturePropertiesExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.NonVisualPicturePropertiesExtensionList? openXmlElement, DMDraws.NonVisualPicturePropertiesExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNonVisualPicturePropertiesExtensions(openXmlElement, value.NonVisualPicturePropertiesExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.NonVisualPicturePropertiesExtensionList? value)
    where OpenXmlElementType: DXDraw.NonVisualPicturePropertiesExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNonVisualPicturePropertiesExtensions(openXmlElement, value?.NonVisualPicturePropertiesExtensions);
      return openXmlElement;
    }
    return default;
  }
}
