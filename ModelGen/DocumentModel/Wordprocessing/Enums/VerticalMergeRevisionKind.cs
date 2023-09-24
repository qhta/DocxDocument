namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the VerticalMergeRevisionValues enumeration.
/// </summary>
public enum VerticalMergeRevisionKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;cont&quot;.
  /// </summary>
  [EnumString("cont")]
  Continue,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rest&quot;.
  /// </summary>
  [EnumString("rest")]
  Restart,
  
}
