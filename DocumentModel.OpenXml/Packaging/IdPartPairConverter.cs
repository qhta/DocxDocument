namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Represents a (RelationshipId, OpenXmlPart) pair.
/// </summary>
public static class IdPartPairConverter
{
  /// <summary>
  /// Gets or sets the relationship ID in the pair.
  /// </summary>
  public static String? GetRelationshipId(DocumentFormat.OpenXml.Packaging.IdPartPair? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static void SetRelationshipId(DocumentFormat.OpenXml.Packaging.IdPartPair? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.IdPartPair? CreateModelElement(DocumentFormat.OpenXml.Packaging.IdPartPair? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.IdPartPair();
      value.RelationshipId = GetRelationshipId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.IdPartPair? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.IdPartPair, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRelationshipId(openXmlElement, value?.RelationshipId);
      return openXmlElement;
    }
    return default;
  }
}
