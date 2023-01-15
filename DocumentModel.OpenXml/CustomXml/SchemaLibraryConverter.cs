using DocumentModel.CustomXml;
using SchemaLibrary = DocumentFormat.OpenXml.CustomXmlSchemaReferences.SchemaLibrary;

namespace DocumentModel.OpenXml.CustomXml;

/// <summary>
///   Embedded Custom XML Schema Supplementary Data.
/// </summary>
public static class SchemaLibraryConverter
{
  public static Collection<Schema>? GetSchemas(SchemaLibrary? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Schema>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema>())
      {
        var newItem = SchemaConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetSchemas(SchemaLibrary? openXmlElement, Collection<Schema>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = SchemaConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.CustomXml.SchemaLibrary? CreateModelElement(SchemaLibrary? openXmlElement)
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
    where OpenXmlElementType : SchemaLibrary, new()
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