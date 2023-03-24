namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the EndnotePositionValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum EndnotePositionKind
{
  /// <summary>
  ///   Endnotes Positioned at End of Section.
  /// </summary>
  SectionEnd,

  /// <summary>
  ///   Endnotes Positioned at End of Document.
  /// </summary>
  DocumentEnd
}