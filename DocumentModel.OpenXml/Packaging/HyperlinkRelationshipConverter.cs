namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Represents a hyperlink relationship.
/// </summary>
public static class HyperlinkRelationshipConverter
{
  /// <summary>
  /// Gets the relationship type.
  /// </summary>
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.HyperlinkRelationship? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.HyperlinkRelationship? CreateModelElement(DocumentFormat.OpenXml.Packaging.HyperlinkRelationship? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.HyperlinkRelationship();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.HyperlinkRelationship? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.HyperlinkRelationship, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
