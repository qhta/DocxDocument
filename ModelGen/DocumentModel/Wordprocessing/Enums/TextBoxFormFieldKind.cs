namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the TextBoxFormFieldValues enumeration.
/// </summary>
public enum TextBoxFormFieldKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;regular&quot;.
  /// </summary>
  Regular,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;number&quot;.
  /// </summary>
  Number,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;date&quot;.
  /// </summary>
  Date,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;currentTime&quot;.
  /// </summary>
  CurrentTime,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;currentDate&quot;.
  /// </summary>
  CurrentDate,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;calculated&quot;.
  /// </summary>
  Calculated,
  
}
