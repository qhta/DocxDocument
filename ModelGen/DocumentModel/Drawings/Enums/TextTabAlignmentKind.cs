namespace DocumentModel.Drawings;


/// <summary>
///   Text Tab Alignment Types
/// </summary>
public enum TextTabAlignmentKind
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
  ///   When the item is serialized out as xml, its value is &quot;dec&quot;.
  /// </summary>
  [EnumString("dec")]
  Decimal,
  
}
