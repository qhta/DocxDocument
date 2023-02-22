namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the DataModelExtensionList Class.
/// </summary>
public static class DataModelExtensionListConverter
{
  private static Collection<DMDraws.DataModelExtension>? GetDataModelExtensions(DXDrawDgms.DataModelExtensionList openXmlElement)
  {
    var collection = new Collection<DMDraws.DataModelExtension>();
    foreach (var item in openXmlElement.Elements<DXDraw.DataModelExtension>())
    {
      var newItem = DMXDraws.DataModelExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpDataModelExtensions(DXDrawDgms.DataModelExtensionList openXmlElement, Collection<DMDraws.DataModelExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDraw.DataModelExtension>();
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
        if (!DMXDraws.DataModelExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetDataModelExtensions(DXDrawDgms.DataModelExtensionList openXmlElement, Collection<DMDraws.DataModelExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.DataModelExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.DataModelExtensionConverter.CreateOpenXmlElement<DXDraw.DataModelExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.DataModelExtensionList? CreateModelElement(DXDrawDgms.DataModelExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.DataModelExtensionList();
      value.DataModelExtensions = GetDataModelExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.DataModelExtensionList? openXmlElement, DMDrawsDgms.DataModelExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDataModelExtensions(openXmlElement, value.DataModelExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.DataModelExtensionList value)
    where OpenXmlElementType: DXDrawDgms.DataModelExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.DataModelExtensionList openXmlElement, DMDrawsDgms.DataModelExtensionList value)
  {
    SetDataModelExtensions(openXmlElement, value?.DataModelExtensions);
  }
}
