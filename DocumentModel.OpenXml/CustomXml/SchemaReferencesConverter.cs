namespace DocumentModel.OpenXml.CustomXml;

/// <summary>
/// Set of Associated XML Schemas.
/// </summary>
public static class SchemaReferencesConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.CustomXml.SchemaReference>? GetItems(DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReferences? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.CustomXml.SchemaReference>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReference>())
      {
        var newItem = DocumentModel.OpenXml.CustomXml.SchemaReferenceConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetItems(DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReferences? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.CustomXml.SchemaReference>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReference>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.CustomXml.SchemaReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReference>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.CustomXml.SchemaReferences? CreateModelElement(DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReferences? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReferences, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
