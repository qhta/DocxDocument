namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PenAlignmentValues enumeration.
/// </summary>
public enum PenAlignmentKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ctr&quot;.
  /// </summary>
  [EnumString("ctr")]
  Center,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;in&quot;.
  /// </summary>
  [EnumString("in")]
  Inset,
  
}
