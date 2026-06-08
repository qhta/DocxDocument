namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the FootnotePositionValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum FootnotePositionKind
{
  /// <summary>
  ///   IFootnotes Positioned at IPage Bottom.
  /// </summary>
  PageBottom,

  /// <summary>
  ///   IFootnotes Positioned Beneath Text.
  /// </summary>
  BeneathText,

  /// <summary>
  ///   IFootnotes Positioned At End of ISection.
  /// </summary>
  SectionEnd
}
