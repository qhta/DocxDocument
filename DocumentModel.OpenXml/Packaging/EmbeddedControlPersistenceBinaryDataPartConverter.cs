namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the EmbeddedControlPersistenceBinaryDataPart
/// </summary>
public static class EmbeddedControlPersistenceBinaryDataPartConverter
{
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistenceBinaryDataPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistenceBinaryDataPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistenceBinaryDataPart, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
