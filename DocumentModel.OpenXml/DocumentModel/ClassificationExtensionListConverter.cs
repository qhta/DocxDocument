namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ClassificationExtensionList Class.
/// </summary>
public static class ClassificationExtensionListConverter
{
  private static Collection<DM.ClassificationExtension>? GetClassificationExtensions(DXO21MLMD.ClassificationExtensionList openXmlElement)
  {
    var collection = new Collection<DM.ClassificationExtension>();
    foreach (var item in openXmlElement.Elements<DXO21MLMD.ClassificationExtension>())
    {
      var newItem = DMX.ClassificationExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpClassificationExtensions(DXO21MLMD.ClassificationExtensionList openXmlElement, Collection<DM.ClassificationExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXO21MLMD.ClassificationExtension>();
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
        if (!DMX.ClassificationExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetClassificationExtensions(DXO21MLMD.ClassificationExtensionList openXmlElement, Collection<DM.ClassificationExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXO21MLMD.ClassificationExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMX.ClassificationExtensionConverter.CreateOpenXmlElement<DXO21MLMD.ClassificationExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.ClassificationExtensionList? CreateModelElement(DXO21MLMD.ClassificationExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.ClassificationExtensionList();
      value.ClassificationExtensions = GetClassificationExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO21MLMD.ClassificationExtensionList? openXmlElement, DM.ClassificationExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpClassificationExtensions(openXmlElement, value.ClassificationExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.ClassificationExtensionList value)
    where OpenXmlElementType: DXO21MLMD.ClassificationExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO21MLMD.ClassificationExtensionList openXmlElement, DM.ClassificationExtensionList value)
  {
    SetClassificationExtensions(openXmlElement, value?.ClassificationExtensions);
  }
}
