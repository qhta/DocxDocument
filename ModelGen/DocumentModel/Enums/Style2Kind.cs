namespace DocumentModel;


/// <summary>
///   Defines the Style2Values enumeration.
/// </summary>
public enum Style2Kind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;normal&quot;.
  /// </summary>
  [EnumString("normal")]
  Normal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;borderless&quot;.
  /// </summary>
  [EnumString("borderless")]
  Borderless,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;large&quot;.
  /// </summary>
  [EnumString("large")]
  Large,
  
}
