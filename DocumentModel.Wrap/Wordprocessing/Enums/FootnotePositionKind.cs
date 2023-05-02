namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the FootnotePositionValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum FootnotePositionKind
{
  /// <summary>
  ///   Footnotes Positioned at Page Bottom.
  /// </summary>
  PageBottom,

  /// <summary>
  ///   Footnotes Positioned Beneath Text.
  /// </summary>
  BeneathText,

  /// <summary>
  ///   Footnotes Positioned At End of Section.
  /// </summary>
  SectionEnd
}