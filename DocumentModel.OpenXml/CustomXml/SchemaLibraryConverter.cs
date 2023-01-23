namespace DocumentModel.OpenXml.CustomXml;

/// <summary>
/// Embedded Custom XML Schema Supplementary Data.
/// </summary>
public static class SchemaLibraryConverter
{
  private static Collection<DMCustXml.Schema> GetSchemas(DXCustXmlSchRefs.SchemaLibrary openXmlElement)
  {
    var collection = new Collection<DMCustXml.Schema>();
    foreach (var item in openXmlElement.Elements<DXCustXmlSchRefs.Schema>())
    {
      var newItem = DMXCustXml.SchemaConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpSchemas(DXCustXmlSchRefs.SchemaLibrary openXmlElement, Collection<DMCustXml.Schema>? value, DiffList? diffs, string? objName)
  {
    return true;
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
  
  public static DMCustXml.SchemaLibrary? CreateModelElement(DXCustXmlSchRefs.SchemaLibrary? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMCustXml.SchemaLibrary();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMCustXml.SchemaLibrary? value)
    where OpenXmlElementType: DXCustXmlSchRefs.SchemaLibrary, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSchemas(openXmlElement, value?.Schemas);
      return openXmlElement;
    }
    return default;
  }
}
