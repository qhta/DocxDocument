namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Hierarchy Branch Style Definition
/// </summary>
public enum HierarchyBranchStyleKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;l&quot;.
  /// </summary>
  Left,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;r&quot;.
  /// </summary>
  Right,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hang&quot;.
  /// </summary>
  Hanging,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;std&quot;.
  /// </summary>
  Standard,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;init&quot;.
  /// </summary>
  Initial,
  
}
