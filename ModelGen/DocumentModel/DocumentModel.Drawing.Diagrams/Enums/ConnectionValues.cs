namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Connection Type
/// </summary>
public enum ConnectionValues
{
  /// <summary>
  /// Parent Of.
  /// </summary>
  [XmlEnum("parOf")]
  ParentOf,
  
  /// <summary>
  /// Presentation Of.
  /// </summary>
  [XmlEnum("presOf")]
  PresentationOf,
  
  /// <summary>
  /// Presentation Parent Of.
  /// </summary>
  [XmlEnum("presParOf")]
  PresentationParentOf,
  
  /// <summary>
  /// Unknown Relationship.
  /// </summary>
  [XmlEnum("unknownRelationship")]
  UnknownRelationship,
  
}
