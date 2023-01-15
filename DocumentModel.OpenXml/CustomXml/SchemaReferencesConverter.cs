using DocumentModel.CustomXml;
using SchemaReferences = DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReferences;

namespace DocumentModel.OpenXml.CustomXml;

/// <summary>
///   Set of Associated XML Schemas.
/// </summary>
public static class SchemaReferencesConverter
{
  public static Collection<SchemaReference>? GetItems(SchemaReferences? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<SchemaReference>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReference>())
      {
        var newItem = SchemaReferenceConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(SchemaReferences? openXmlElement, Collection<SchemaReference>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReference>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = SchemaReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReference>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.CustomXml.SchemaReferences? CreateModelElement(SchemaReferences? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.CustomXml.SchemaReferences();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.CustomXml.SchemaReferences? value)
    where OpenXmlElementType : SchemaReferences, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}