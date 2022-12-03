namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ChapterSeparatorValues enumeration.
/// </summary>
public enum ChapterSeparatorKind
{
  /// <summary>
  /// Hyphen Chapter Separator.
  /// </summary>
  [XmlEnum("hyphen")]
  Hyphen,
  
  /// <summary>
  /// Period Chapter Separator.
  /// </summary>
  [XmlEnum("period")]
  Period,
  
  /// <summary>
  /// Colon Chapter Separator.
  /// </summary>
  [XmlEnum("colon")]
  Colon,
  
  /// <summary>
  /// Em Dash Chapter Separator.
  /// </summary>
  [XmlEnum("emDash")]
  EmDash,
  
  /// <summary>
  /// En Dash Chapter Separator.
  /// </summary>
  [XmlEnum("enDash")]
  EnDash,
  
}
