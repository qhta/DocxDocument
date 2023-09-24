namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the TableOverlapValues enumeration.
/// </summary>
public enum TableOverlapKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;never&quot;.
  /// </summary>
  [EnumString("never")]
  Never,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;overlap&quot;.
  /// </summary>
  [EnumString("overlap")]
  Overlap,
  
}
