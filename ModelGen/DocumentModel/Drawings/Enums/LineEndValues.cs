namespace DocumentFormat.OpenXml.Drawings;


/// <summary>
///   Line End Type
/// </summary>
public enum LineEndValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  [EnumString("none")]
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;triangle&quot;.
  /// </summary>
  [EnumString("triangle")]
  Triangle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;stealth&quot;.
  /// </summary>
  [EnumString("stealth")]
  Stealth,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;diamond&quot;.
  /// </summary>
  [EnumString("diamond")]
  Diamond,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;oval&quot;.
  /// </summary>
  [EnumString("oval")]
  Oval,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;arrow&quot;.
  /// </summary>
  [EnumString("arrow")]
  Arrow,
  
}
