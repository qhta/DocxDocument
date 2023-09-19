namespace DXVO;


/// <summary>
///   Rule Type
/// </summary>
public enum RuleValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;arc&quot;.
  /// </summary>
  [EnumString("arc")]
  Arc,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;callout&quot;.
  /// </summary>
  [EnumString("callout")]
  Callout,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;connector&quot;.
  /// </summary>
  [EnumString("connector")]
  Connector,
  
}
