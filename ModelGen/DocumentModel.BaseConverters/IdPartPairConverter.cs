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

  public static void SetRelationshipId(IdPartPair? openXmlElement, String? value)
  {
    if (openXmlElement != null && value != null)
      openXmlElement.RelationshipId = value;
  }

  public static DocumentModel.Packaging.IdPartPair? CreateModelElement(IdPartPair? openXmlElement)
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
    where OpenXmlElementType : IdPartPair, new()
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