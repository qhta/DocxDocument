namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the FootnoteEndnoteValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum FootnoteEndnoteKind
{
  /// <summary>
  ///   Normal Footnote/Endnote.
  /// </summary>
  Normal,

  /// <summary>
  ///   Separator.
  /// </summary>
  Separator,

  /// <summary>
  ///   Continuation Separator.
  /// </summary>
  ContinuationSeparator,

  /// <summary>
  ///   Continuation Notice Separator.
  /// </summary>
  ContinuationNotice
}