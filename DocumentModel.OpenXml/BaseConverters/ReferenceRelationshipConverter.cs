using DocumentFormat.OpenXml.Packaging;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines a reference relationship. A reference relationship can be internal or external.
/// </summary>
public static class ReferenceRelationshipConverter
{
  /// <summary>
  ///   Gets the relationship type.
  /// </summary>
  public static String? GetRelationshipType(ReferenceRelationship? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  /// <summary>
  ///   Gets a value indicating whether the target of the relationship is Internal or External to the .
  /// </summary>
  public static Boolean? GetIsExternal(ReferenceRelationship? openXmlElement)
  {
    return openXmlElement?.IsExternal;
  }

  /// <summary>
  ///   Gets the relationship ID.
  /// </summary>
  public static String? GetId(ReferenceRelationship? openXmlElement)
  {
    return openXmlElement?.Id;
  }

  /// <summary>
  ///   Gets the target URI of the relationship.
  /// </summary>
  public static Uri? GetUri(ReferenceRelationship? openXmlElement)
  {
    return openXmlElement?.Uri;
  }

  public static DocumentModel.Packaging.ReferenceRelationship? CreateModelElement(ReferenceRelationship? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.ReferenceRelationship();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.IsExternal = GetIsExternal(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.Uri = GetUri(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.ReferenceRelationship? value)
    where OpenXmlElementType : ReferenceRelationship, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      //SetId(openXmlElement, value?.Id);
      //SetIsExternal(openXmlElement, value?.IsExternal);
      //SetUri(openXmlElement, value?.Uri);
      return openXmlElement;
    }
    return default;
  }
}