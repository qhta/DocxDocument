namespace DocumentModel.OpenXml.CustomXml;

/// <summary>
/// Embedded Custom XML Schema Supplementary Data.
/// </summary>
public static class SchemaLibraryConverter
{
  private static Collection<DMCustXml.Schema>? GetSchemas(DXCustXmlSchRefs.SchemaLibrary openXmlElement)
  {
    var collection = new Collection<DMCustXml.Schema>();
    foreach (var item in openXmlElement.Elements<DXCustXmlSchRefs.Schema>())
    {
      var newItem = DMXCustXml.SchemaConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpSchemas(DXCustXmlSchRefs.SchemaLibrary openXmlElement, Collection<DMCustXml.Schema>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXCustXmlSchRefs.Schema>();
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
        if (!DMXCustXml.SchemaConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetSchemas(DXCustXmlSchRefs.SchemaLibrary openXmlElement, Collection<DMCustXml.Schema>? value)
  {
    openXmlElement.RemoveAllChildren<DXCustXmlSchRefs.Schema>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXCustXml.SchemaConverter.CreateOpenXmlElement<DXCustXmlSchRefs.Schema>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.CustomXml.SchemaLibrary? CreateModelElement(DXCustXmlSchRefs.SchemaLibrary? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.CustomXml.SchemaLibrary();
      value.Schemas = GetSchemas(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXCustXmlSchRefs.SchemaLibrary? openXmlElement, DMCustXml.SchemaLibrary? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMCustXml.SchemaLibrary value)
    where OpenXmlElementType: DXCustXmlSchRefs.SchemaLibrary, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXCustXmlSchRefs.SchemaLibrary openXmlElement, DMCustXml.SchemaLibrary value)
  {
    SetSchemas(openXmlElement, value?.Schemas);
    }
  }
