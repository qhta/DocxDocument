namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the EndnotePositionValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum EndnotePositionKind
{
  /// <summary>
  ///   Endnotes Positioned at End of ISection.
  /// </summary>
  SectionEnd,
  /// <summary>
  ///   Endnotes Positioned at End of Document.
  /// </summary>
  DocumentEnd
}