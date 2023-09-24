namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the TableWidthValues enumeration.
/// </summary>
public enum TableWidthKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;nil&quot;.
  /// </summary>
  [EnumString("nil")]
  Nil,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dxa&quot;.
  /// </summary>
  [EnumString("dxa")]
  Dxa,
  
}
