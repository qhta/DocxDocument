namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the EmbeddedControlPersistencePart
/// </summary>
public static class EmbeddedControlPersistencePartConverter
{
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the EmbeddedControlPersistencePart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart>? GetEmbeddedControlPersistenceBinaryDataParts(DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistencePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistenceBinaryDataPart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.EmbeddedControlPersistenceBinaryDataPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistencePart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.EmbeddedControlPersistencePart? CreateModelElement(DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistencePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.EmbeddedControlPersistencePart();
      value.EmbeddedControlPersistenceBinaryDataParts = GetEmbeddedControlPersistenceBinaryDataParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.EmbeddedControlPersistencePart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistencePart, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
