namespace DocumentModel.OpenXml.CustomXml;

/// <summary>
/// Embedded Custom XML Schema Supplementary Data.
/// </summary>
public static class SchemaLibraryConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.CustomXml.Schema>? GetSchemas(DocumentFormat.OpenXml.CustomXmlSchemaReferences.SchemaLibrary? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.CustomXml.Schema>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema>())
      {
        var newItem = DocumentModel.OpenXml.CustomXml.SchemaConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetSchemas(DocumentFormat.OpenXml.CustomXmlSchemaReferences.SchemaLibrary? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.CustomXml.Schema>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.CustomXml.SchemaConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.CustomXml.SchemaLibrary? CreateModelElement(DocumentFormat.OpenXml.CustomXmlSchemaReferences.SchemaLibrary? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.CustomXml.SchemaLibrary();
      value.Schemas = GetSchemas(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.CustomXml.SchemaLibrary? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.CustomXmlSchemaReferences.SchemaLibrary, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
