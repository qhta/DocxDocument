namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the MergedCellValues enumeration.
/// </summary>
public enum MergedCellKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;continue&quot;.
  /// </summary>
  [EnumString("continue")]
  Continue,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;restart&quot;.
  /// </summary>
  [EnumString("restart")]
  Restart,
  
}
