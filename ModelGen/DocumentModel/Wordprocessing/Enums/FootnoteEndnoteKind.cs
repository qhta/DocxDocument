namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the FootnoteEndnoteValues enumeration.
/// </summary>
public enum FootnoteEndnoteKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;normal&quot;.
  /// </summary>
  [EnumString("normal")]
  Normal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;separator&quot;.
  /// </summary>
  [EnumString("separator")]
  Separator,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;continuationSeparator&quot;.
  /// </summary>
  [EnumString("continuationSeparator")]
  ContinuationSeparator,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;continuationNotice&quot;.
  /// </summary>
  [EnumString("continuationNotice")]
  ContinuationNotice,
  
}
