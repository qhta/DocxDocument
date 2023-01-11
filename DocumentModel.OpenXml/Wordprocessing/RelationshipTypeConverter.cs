namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the RelationshipType Class.
/// </summary>
public static class RelationshipTypeConverter
{
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Wordprocessing.RelationshipType? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Wordprocessing.RelationshipType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  public static DocumentModel.Wordprocessing.RelationshipType? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.RelationshipType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.RelationshipType();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.RelationshipType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.RelationshipType, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
