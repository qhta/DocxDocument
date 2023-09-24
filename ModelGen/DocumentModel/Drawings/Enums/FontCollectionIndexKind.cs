namespace DocumentModel.Drawings;


/// <summary>
///   Font Collection Index
/// </summary>
public enum FontCollectionIndexKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;major&quot;.
  /// </summary>
  [EnumString("major")]
  Major,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;minor&quot;.
  /// </summary>
  [EnumString("minor")]
  Minor,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  [EnumString("none")]
  None,
  
}
