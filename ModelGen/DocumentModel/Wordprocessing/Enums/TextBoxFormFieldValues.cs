namespace DXW;


/// <summary>
///   Defines the TextBoxFormFieldValues enumeration.
/// </summary>
public enum TextBoxFormFieldValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;regular&quot;.
  /// </summary>
  [EnumString("regular")]
  Regular,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;number&quot;.
  /// </summary>
  [EnumString("number")]
  Number,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;date&quot;.
  /// </summary>
  [EnumString("date")]
  Date,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;currentTime&quot;.
  /// </summary>
  [EnumString("currentTime")]
  CurrentTime,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;currentDate&quot;.
  /// </summary>
  [EnumString("currentDate")]
  CurrentDate,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;calculated&quot;.
  /// </summary>
  [EnumString("calculated")]
  Calculated,
  
}
