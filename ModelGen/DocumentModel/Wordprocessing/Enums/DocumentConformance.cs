namespace DXW;


/// <summary>
///   Defines the DocumentConformance enumeration.
/// </summary>
public enum DocumentConformance
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;transitional&quot;.
  /// </summary>
  [EnumString("transitional")]
  transitional,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;strict&quot;.
  /// </summary>
  [EnumString("strict")]
  strict,
  
}
