namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualPicturePropertiesExtensionList Class.
/// </summary>
public static class NonVisualPicturePropertiesExtensionListConverter
{
  private static Collection<DMDraws.NonVisualPicturePropertiesExtension>? GetNonVisualPicturePropertiesExtensions(DXDraw.NonVisualPicturePropertiesExtensionList openXmlElement)
  {
    var collection = new Collection<DMDraws.NonVisualPicturePropertiesExtension>();
    foreach (var item in openXmlElement.Elements<DXDraw.NonVisualPicturePropertiesExtension>())
    {
      var newItem = DMXDraws.NonVisualPicturePropertiesExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpNonVisualPicturePropertiesExtensions(DXDraw.NonVisualPicturePropertiesExtensionList openXmlElement, Collection<DMDraws.NonVisualPicturePropertiesExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDraw.NonVisualPicturePropertiesExtension>();
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
        if (!DMXDraws.NonVisualPicturePropertiesExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
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
  
  public static DocumentModel.Drawings.NonVisualPicturePropertiesExtensionList? CreateModelElement(DXDraw.NonVisualPicturePropertiesExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.NonVisualPicturePropertiesExtensionList();
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
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.NonVisualPicturePropertiesExtensionList value)
    where OpenXmlElementType: DXDraw.NonVisualPicturePropertiesExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.NonVisualPicturePropertiesExtensionList openXmlElement, DMDraws.NonVisualPicturePropertiesExtensionList value)
  {
    SetNonVisualPicturePropertiesExtensions(openXmlElement, value?.NonVisualPicturePropertiesExtensions);
    }
  }
