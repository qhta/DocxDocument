namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ChapterSeparatorValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum ChapterSeparatorKind
{
  /// <summary>
  ///   Hyphen Chapter Separator.
  /// </summary>
  Hyphen,

  /// <summary>
  ///   Period Chapter Separator.
  /// </summary>
  Period,

  /// <summary>
  ///   Colon Chapter Separator.
  /// </summary>
  Colon,

  /// <summary>
  ///   Em Dash Chapter Separator.
  /// </summary>
  EmDash,

  /// <summary>
  ///   En Dash Chapter Separator.
  /// </summary>
  EnDash
}