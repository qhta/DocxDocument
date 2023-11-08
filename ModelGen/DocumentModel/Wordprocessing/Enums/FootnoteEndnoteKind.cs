namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the FootnoteEndnoteValues enumeration.
/// </summary>
public enum FootnoteEndnoteKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;normal&quot;.
  /// </summary>
  Normal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;separator&quot;.
  /// </summary>
  Separator,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;continuationSeparator&quot;.
  /// </summary>
  ContinuationSeparator,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;continuationNotice&quot;.
  /// </summary>
  ContinuationNotice,
  
}
