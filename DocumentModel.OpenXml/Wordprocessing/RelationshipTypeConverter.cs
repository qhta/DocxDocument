namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the RelationshipType Class.
/// </summary>
public static class RelationshipTypeConverter
{
  /// <summary>
  /// Relationship to Part
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Wordprocessing.RelationshipType openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Wordprocessing.RelationshipType openXmlElement, String? value)
  {
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}
