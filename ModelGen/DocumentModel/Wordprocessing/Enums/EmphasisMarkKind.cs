namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the EmphasisMarkValues enumeration.
/// </summary>
public enum EmphasisMarkKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  [EnumString("none")]
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dot&quot;.
  /// </summary>
  [EnumString("dot")]
  Dot,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;comma&quot;.
  /// </summary>
  [EnumString("comma")]
  Comma,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;circle&quot;.
  /// </summary>
  [EnumString("circle")]
  Circle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;underDot&quot;.
  /// </summary>
  [EnumString("underDot")]
  UnderDot,
  
}
