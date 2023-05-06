namespace DocumentModel.OpenXml.CustomXml;

/// <summary>
/// Embedded Custom XML Schema Supplementary Data.
/// </summary>
public static class SchemaLibraryConverter
{
  private static Collection<DMCX.Schema>? GetSchemas(DXCXSR.SchemaLibrary openXmlElement)
  {
    var collection = new Collection<DMCX.Schema>();
    foreach (var item in openXmlElement.Elements<DXCXSR.Schema>())
    {
      var newItem = DMXCX.SchemaConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpSchemas(DXCXSR.SchemaLibrary openXmlElement, Collection<DMCX.Schema>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXCXSR.Schema>();
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
        if (!DMXCX.SchemaConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetSchemas(DXCXSR.SchemaLibrary openXmlElement, Collection<DMCX.Schema>? value)
  {
    openXmlElement.RemoveAllChildren<DXCXSR.Schema>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXCX.SchemaConverter.CreateOpenXmlElement<DXCXSR.Schema>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.CustomXml.SchemaLibrary? CreateModelElement(DXCXSR.SchemaLibrary? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.CustomXml.SchemaLibrary();
      value.Schemas = GetSchemas(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXCXSR.SchemaLibrary? openXmlElement, DMCX.SchemaLibrary? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSchemas(openXmlElement, value.Schemas, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMCX.SchemaLibrary value)
    where OpenXmlElementType: DXCXSR.SchemaLibrary, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXCXSR.SchemaLibrary openXmlElement, DMCX.SchemaLibrary value)
  {
    SetSchemas(openXmlElement, value?.Schemas);
  }
}
