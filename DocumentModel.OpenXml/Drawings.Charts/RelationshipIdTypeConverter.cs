namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the RelationshipIdType Class.
/// </summary>
public static class RelationshipIdTypeConverter
{
  /// <summary>
  /// Relationship Reference
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Drawing.Charts.RelationshipIdType? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Drawing.Charts.RelationshipIdType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  public static DocumentModel.Drawings.Charts.RelationshipIdType? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.RelationshipIdType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.RelationshipIdType();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.RelationshipIdType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.RelationshipIdType, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
