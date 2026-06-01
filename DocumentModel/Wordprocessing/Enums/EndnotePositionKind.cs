namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the EndnotePositionValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum EndnotePositionKind
{
  /// <summary>
  ///   IEndnotes Positioned at End of ISection.
  /// </summary>
  SectionEnd,

  /// <summary>
  ///   IEndnotes Positioned at End of IDocument.
  /// </summary>
  DocumentEnd
}
