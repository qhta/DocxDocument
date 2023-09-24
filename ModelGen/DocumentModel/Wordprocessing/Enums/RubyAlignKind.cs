namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the RubyAlignValues enumeration.
/// </summary>
public enum RubyAlignKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;center&quot;.
  /// </summary>
  [EnumString("center")]
  Center,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;distributeLetter&quot;.
  /// </summary>
  [EnumString("distributeLetter")]
  DistributeLetter,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;distributeSpace&quot;.
  /// </summary>
  [EnumString("distributeSpace")]
  DistributeSpace,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;left&quot;.
  /// </summary>
  [EnumString("left")]
  Left,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;right&quot;.
  /// </summary>
  [EnumString("right")]
  Right,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rightVertical&quot;.
  /// </summary>
  [EnumString("rightVertical")]
  RightVertical,
  
}
