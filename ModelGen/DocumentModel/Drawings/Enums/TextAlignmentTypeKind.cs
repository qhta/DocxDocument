namespace DocumentModel.Drawings;


/// <summary>
///   Text Alignment Types
/// </summary>
public enum TextAlignmentTypeKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;l&quot;.
  /// </summary>
  Left,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ctr&quot;.
  /// </summary>
  Center,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;r&quot;.
  /// </summary>
  Right,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;just&quot;.
  /// </summary>
  Justified,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;justLow&quot;.
  /// </summary>
  JustifiedLow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dist&quot;.
  /// </summary>
  Distributed,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thaiDist&quot;.
  /// </summary>
  ThaiDistributed,
  
}
