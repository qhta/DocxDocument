namespace DXW;


/// <summary>
///   Defines the RestartNumberValues enumeration.
/// </summary>
public enum RestartNumberValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;continuous&quot;.
  /// </summary>
  [EnumString("continuous")]
  Continuous,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;eachSect&quot;.
  /// </summary>
  [EnumString("eachSect")]
  EachSection,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;eachPage&quot;.
  /// </summary>
  [EnumString("eachPage")]
  EachPage,
  
}
