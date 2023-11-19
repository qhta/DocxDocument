using DocumentFormat.OpenXml.Packaging;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Represents a (RelationshipId, OpenXmlPart) pair.
/// </summary>
public static class IdPartPairConverter
{
  /// <summary>
  ///   Gets or sets the relationship ID in the pair.
  /// </summary>
  public static String? GetRelationshipId(IdPartPair? openXmlElement)
  {
    return openXmlElement?.RelationshipId;
  }

  public static DocumentModel.Packaging.IdPartPair? CreateModelElement(IdPartPair? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.IdPartPair();
      value.RelationshipId = GetRelationshipId(openXmlElement);
      value.OpenXmlPart = openXmlElement.OpenXmlPart;
      return value;
    }
    return null;
  }

  public static IdPartPair? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.IdPartPair? value)
  {
    if (value != null && value.RelationshipId!=null && value.OpenXmlPart!=null)
    {
      return new IdPartPair(value.RelationshipId, value.OpenXmlPart);
    }
    return default;
  }
}