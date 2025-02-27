namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualPicturePropertiesExtensionList Class.
/// </summary>
public static class NonVisualPicturePropertiesExtensionListConverter
{
  private static Collection<DMD.NonVisualPicturePropertiesExtension>? GetNonVisualPicturePropertiesExtensions(DXD.NonVisualPicturePropertiesExtensionList openXmlElement)
  {
    var collection = new Collection<DMD.NonVisualPicturePropertiesExtension>();
    foreach (var item in openXmlElement.Elements<DXD.NonVisualPicturePropertiesExtension>())
    {
      var newItem = DMXD.NonVisualPicturePropertiesExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpNonVisualPicturePropertiesExtensions(DXD.NonVisualPicturePropertiesExtensionList openXmlElement, Collection<DMD.NonVisualPicturePropertiesExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXD.NonVisualPicturePropertiesExtension>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, propName ?? openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXD.NonVisualPicturePropertiesExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetNonVisualPicturePropertiesExtensions(DXD.NonVisualPicturePropertiesExtensionList openXmlElement, Collection<DMD.NonVisualPicturePropertiesExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXD.NonVisualPicturePropertiesExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXD.NonVisualPicturePropertiesExtensionConverter.CreateOpenXmlElement<DXD.NonVisualPicturePropertiesExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMD.NonVisualPicturePropertiesExtensionList? CreateModelElement(DXD.NonVisualPicturePropertiesExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.NonVisualPicturePropertiesExtensionList();
      value.NonVisualPicturePropertiesExtensions = GetNonVisualPicturePropertiesExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.NonVisualPicturePropertiesExtensionList? openXmlElement, DMD.NonVisualPicturePropertiesExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNonVisualPicturePropertiesExtensions(openXmlElement, value.NonVisualPicturePropertiesExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.NonVisualPicturePropertiesExtensionList value)
    where OpenXmlElementType: DXD.NonVisualPicturePropertiesExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.NonVisualPicturePropertiesExtensionList openXmlElement, DMD.NonVisualPicturePropertiesExtensionList value)
  {
    SetNonVisualPicturePropertiesExtensions(openXmlElement, value?.NonVisualPicturePropertiesExtensions);
  }
}
