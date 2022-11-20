namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FootnoteEndnoteValues enumeration.
/// </summary>
public enum FootnoteEndnoteValues
{
  /// <summary>
  /// Normal Footnote/Endnote.
  /// </summary>
  [XmlEnum("normal")]
  Normal,
  
  /// <summary>
  /// Separator.
  /// </summary>
  [XmlEnum("separator")]
  Separator,
  
  /// <summary>
  /// Continuation Separator.
  /// </summary>
  [XmlEnum("continuationSeparator")]
  ContinuationSeparator,
  
  /// <summary>
  /// Continuation Notice Separator.
  /// </summary>
  [XmlEnum("continuationNotice")]
  ContinuationNotice,
  
}
