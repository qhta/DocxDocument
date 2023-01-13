namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the EmbeddedControlPersistenceBinaryDataPart
/// </summary>
public static class EmbeddedControlPersistenceBinaryDataPartConverter
{
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistenceBinaryDataPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
