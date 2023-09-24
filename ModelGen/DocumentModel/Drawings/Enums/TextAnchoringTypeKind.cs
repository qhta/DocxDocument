namespace DocumentModel.Drawings;


/// <summary>
///   Text Anchoring Types
/// </summary>
public enum TextAnchoringTypeKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;t&quot;.
  /// </summary>
  [EnumString("t")]
  Top,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ctr&quot;.
  /// </summary>
  [EnumString("ctr")]
  Center,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;b&quot;.
  /// </summary>
  [EnumString("b")]
  Bottom,
  
}
