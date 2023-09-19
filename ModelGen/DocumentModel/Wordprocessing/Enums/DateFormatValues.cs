namespace DXW;


/// <summary>
///   Defines the DateFormatValues enumeration.
/// </summary>
public enum DateFormatValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;text&quot;.
  /// </summary>
  [EnumString("text")]
  Text,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;date&quot;.
  /// </summary>
  [EnumString("date")]
  Date,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dateTime&quot;.
  /// </summary>
  [EnumString("dateTime")]
  DateTime,
  
}
