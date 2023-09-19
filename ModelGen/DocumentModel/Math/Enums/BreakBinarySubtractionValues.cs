namespace DXM;


/// <summary>
///   Defines the BreakBinarySubtractionValues enumeration.
/// </summary>
public enum BreakBinarySubtractionValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;--&quot;.
  /// </summary>
  [EnumString("--")]
  MinusMinus,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;-+&quot;.
  /// </summary>
  [EnumString("-+")]
  MinusPlus,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;+-&quot;.
  /// </summary>
  [EnumString("+-")]
  PlusMinus,
  
}
