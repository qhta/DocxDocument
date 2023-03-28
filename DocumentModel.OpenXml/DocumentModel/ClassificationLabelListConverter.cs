namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ClassificationLabelList Class converter from/to OpenXml.
///</summary>
public static class ClassificationLabelListConverter
{
  private static Collection<DM.ClassificationLabel>? GetClassificationLabels(DXO2021MipLabelMeta.ClassificationLabelList openXmlElement)
  {
    var collection = new Collection<DM.ClassificationLabel>();
    foreach (var item in openXmlElement.Elements<DXO2021MipLabelMeta.ClassificationLabel>())
    {
      var newItem = DMX.ClassificationLabelConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpClassificationLabels(DXO2021MipLabelMeta.ClassificationLabelList openXmlElement, Collection<DM.ClassificationLabel>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO2021MipLabelMeta.ClassificationLabel>();
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
        if (!DMX.ClassificationLabelConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetClassificationLabels(DXO2021MipLabelMeta.ClassificationLabelList openXmlElement, Collection<DM.ClassificationLabel>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2021MipLabelMeta.ClassificationLabel>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMX.ClassificationLabelConverter.CreateOpenXmlElement<DXO2021MipLabelMeta.ClassificationLabel>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DM.ClassificationExtensionList? GetClassificationExtensionList(DXO2021MipLabelMeta.ClassificationLabelList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2021MipLabelMeta.ClassificationExtensionList>();
    if (element != null)
      return DMX.ClassificationExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpClassificationExtensionList(DXO2021MipLabelMeta.ClassificationLabelList openXmlElement, DM.ClassificationExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMX.ClassificationExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2021MipLabelMeta.ClassificationExtensionList>(), value, diffs, objName);
  }
  
  private static void SetClassificationExtensionList(DXO2021MipLabelMeta.ClassificationLabelList openXmlElement, DM.ClassificationExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021MipLabelMeta.ClassificationExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ClassificationExtensionListConverter.CreateOpenXmlElement<DXO2021MipLabelMeta.ClassificationExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.ClassificationLabelList? CreateModelElement(DXO2021MipLabelMeta.ClassificationLabelList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.ClassificationLabelList();
      value.ClassificationLabels = GetClassificationLabels(openXmlElement);
      value.ClassificationExtensionList = GetClassificationExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2021MipLabelMeta.ClassificationLabelList? openXmlElement, DM.ClassificationLabelList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpClassificationLabels(openXmlElement, value.ClassificationLabels, diffs, objName))
        ok = false;
      if (!CmpClassificationExtensionList(openXmlElement, value.ClassificationExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.ClassificationLabelList value)
    where OpenXmlElementType: DXO2021MipLabelMeta.ClassificationLabelList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2021MipLabelMeta.ClassificationLabelList openXmlElement, DM.ClassificationLabelList value)
  {
    SetClassificationLabels(openXmlElement, value?.ClassificationLabels);
    SetClassificationExtensionList(openXmlElement, value?.ClassificationExtensionList);
  }
}
