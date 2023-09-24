namespace DocumentModel.UI;


/// <summary>
///   Defines the ItemSizeValues enumeration.
/// </summary>
public enum ItemSizeKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;normal&quot;.
  /// </summary>
  [EnumString("normal")]
  Normal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;large&quot;.
  /// </summary>
  [EnumString("large")]
  Large,
  
}
