namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ClassificationExtensionList Class.
/// </summary>
public static class ClassificationExtensionListConverter
{
  private static Collection<DM.ClassificationExtension> GetClassificationExtensions(DXO2021MipLabelMeta.ClassificationExtensionList openXmlElement)
  {
    var collection = new Collection<DM.ClassificationExtension>();
    foreach (var item in openXmlElement.Elements<DXO2021MipLabelMeta.ClassificationExtension>())
    {
      var newItem = DMX.ClassificationExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpClassificationExtensions(DXO2021MipLabelMeta.ClassificationExtensionList openXmlElement, Collection<DM.ClassificationExtension>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXO2021MipLabelMeta.ClassificationExtension>();
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
        if (!DMX.ClassificationExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetClassificationExtensions(DXO2021MipLabelMeta.ClassificationExtensionList openXmlElement, Collection<DM.ClassificationExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2021MipLabelMeta.ClassificationExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMX.ClassificationExtensionConverter.CreateOpenXmlElement<DXO2021MipLabelMeta.ClassificationExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DM.ClassificationExtensionList? CreateModelElement(DXO2021MipLabelMeta.ClassificationExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.ClassificationExtensionList();
      value.ClassificationExtensions = GetClassificationExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2021MipLabelMeta.ClassificationExtensionList? openXmlElement, DM.ClassificationExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpClassificationExtensions(openXmlElement, value.ClassificationExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.ClassificationExtensionList? value)
    where OpenXmlElementType: DXO2021MipLabelMeta.ClassificationExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetClassificationExtensions(openXmlElement, value?.ClassificationExtensions);
      return openXmlElement;
    }
    return default;
  }
}
