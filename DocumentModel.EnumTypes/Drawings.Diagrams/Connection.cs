namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the Connection enumeration.
/// Used Iin types such as ConnectionShapeLocks, ConnectionSite, ConnectionSiteList.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDD.ConnectionValues))]
public enum ConnectionType
{
  /// <summary>
  ///   Parent Of.
  /// </summary>
  [OpenXmlEnumValue("ParentOf")]
  ParentOf,
  /// <summary>
  ///   Presentation Of.
  /// </summary>
  [OpenXmlEnumValue("PresentationOf")]
  PresentationOf,
  /// <summary>
  ///   Presentation Parent Of.
  /// </summary>
  [OpenXmlEnumValue("PresentationParentOf")]
  PresentationParentOf,
  /// <summary>
  ///   Unknown Relationship.
  /// </summary>
  [OpenXmlEnumValue("UnknownRelationship")]
  UnknownRelationship
}

