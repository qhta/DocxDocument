namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Connection Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ConnectionKind
{
  /// <summary>
  ///   Parent Of.
  /// </summary>
  ParentOf,

  /// <summary>
  ///   Presentation Of.
  /// </summary>
  PresentationOf,

  /// <summary>
  ///   Presentation Parent Of.
  /// </summary>
  PresentationParentOf,

  /// <summary>
  ///   Unknown Relationship.
  /// </summary>
  UnknownRelationship
}