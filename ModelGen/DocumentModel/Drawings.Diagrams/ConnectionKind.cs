namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Connection Type
/// </summary>
public enum ConnectionKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;parOf&quot;.
  /// </summary>
  ParentOf,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;presOf&quot;.
  /// </summary>
  PresentationOf,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;presParOf&quot;.
  /// </summary>
  PresentationParentOf,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;unknownRelationship&quot;.
  /// </summary>
  UnknownRelationship,
  
}
