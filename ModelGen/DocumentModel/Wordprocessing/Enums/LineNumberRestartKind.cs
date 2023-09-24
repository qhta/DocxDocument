namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the LineNumberRestartValues enumeration.
/// </summary>
public enum LineNumberRestartKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;newPage&quot;.
  /// </summary>
  [EnumString("newPage")]
  NewPage,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;newSection&quot;.
  /// </summary>
  [EnumString("newSection")]
  NewSection,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;continuous&quot;.
  /// </summary>
  [EnumString("continuous")]
  Continuous,
  
}
