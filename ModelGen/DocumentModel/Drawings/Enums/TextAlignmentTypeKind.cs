namespace DocumentModel.Drawings;


/// <summary>
///   Text Alignment Types
/// </summary>
public enum TextAlignmentTypeKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;l&quot;.
  /// </summary>
  [EnumString("l")]
  Left,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ctr&quot;.
  /// </summary>
  [EnumString("ctr")]
  Center,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;r&quot;.
  /// </summary>
  [EnumString("r")]
  Right,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;just&quot;.
  /// </summary>
  [EnumString("just")]
  Justified,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;justLow&quot;.
  /// </summary>
  [EnumString("justLow")]
  JustifiedLow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dist&quot;.
  /// </summary>
  [EnumString("dist")]
  Distributed,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thaiDist&quot;.
  /// </summary>
  [EnumString("thaiDist")]
  ThaiDistributed,
  
}
