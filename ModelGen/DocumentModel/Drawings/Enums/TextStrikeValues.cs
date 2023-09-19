namespace DocumentFormat.OpenXml.Drawings;


/// <summary>
///   Text Strike Type
/// </summary>
public enum TextStrikeValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;noStrike&quot;.
  /// </summary>
  [EnumString("noStrike")]
  NoStrike,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sngStrike&quot;.
  /// </summary>
  [EnumString("sngStrike")]
  SingleStrike,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dblStrike&quot;.
  /// </summary>
  [EnumString("dblStrike")]
  DoubleStrike,
  
}
