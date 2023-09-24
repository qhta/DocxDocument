namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the FieldCharValues enumeration.
/// </summary>
public enum FieldCharKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;begin&quot;.
  /// </summary>
  [EnumString("begin")]
  Begin,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;separate&quot;.
  /// </summary>
  [EnumString("separate")]
  Separate,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;end&quot;.
  /// </summary>
  [EnumString("end")]
  End,
  
}
