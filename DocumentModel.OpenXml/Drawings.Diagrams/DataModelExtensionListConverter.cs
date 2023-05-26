namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the DataModelExtensionList Class.
/// </summary>
public static class DataModelExtensionListConverter
{
  private static Collection<DMD.DataModelExtension>? GetDataModelExtensions(DXDD.DataModelExtensionList openXmlElement)
  {
    var collection = new Collection<DMD.DataModelExtension>();
    foreach (var item in openXmlElement.Elements<DXD.DataModelExtension>())
    {
      var newItem = DMXD.DataModelExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpDataModelExtensions(DXDD.DataModelExtensionList openXmlElement, Collection<DMD.DataModelExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXD.DataModelExtension>();
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
        if (!DMXD.DataModelExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetDataModelExtensions(DXDD.DataModelExtensionList openXmlElement, Collection<DMD.DataModelExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXD.DataModelExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXD.DataModelExtensionConverter.CreateOpenXmlElement<DXD.DataModelExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.DataModelExtensionList? CreateModelElement(DXDD.DataModelExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.DataModelExtensionList();
      value.DataModelExtensions = GetDataModelExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.DataModelExtensionList? openXmlElement, DMDD.DataModelExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDataModelExtensions(openXmlElement, value.DataModelExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.DataModelExtensionList value)
    where OpenXmlElementType: DXDD.DataModelExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.DataModelExtensionList openXmlElement, DMDD.DataModelExtensionList value)
  {
    SetDataModelExtensions(openXmlElement, value?.DataModelExtensions);
  }
}
