namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the LineNumberRestartValues enumeration.
/// </summary>
public enum LineNumberRestartKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;newPage&quot;.
  /// </summary>
  NewPage,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;newSection&quot;.
  /// </summary>
  NewSection,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;continuous&quot;.
  /// </summary>
  Continuous,
  
}
