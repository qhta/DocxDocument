namespace DocumentModel.Drawings;

/// <summary>
///   Represents character-level formatting properties for text, including font, style, language, spacing, underline, strike, and outline settings.
/// </summary>
public class TextCharacterPropertiesType: ModelElement
{
  /// <summary>
  ///   Value available for backwards compatibility.
  /// </summary>
  public bool? SmtClean { get; set; }

  /// <summary>
  ///   Value available for backwards compatibility.
  /// </summary>
  public UInt32? SmtId { get; set; }

  /// <summary>
  ///   Indicates kumimoji (grouped characters) usage.
  /// </summary>
  public bool? Kumimoji { get; set; }

  /// <summary>
  ///   Language identifier.
  /// </summary>
  public string? Language { get; set; }

  /// <summary>
  ///   Alternative language identifier.
  /// </summary>
  public string? AlternativeLanguage { get; set; }

  /// <summary>
  ///   Font size.
  /// </summary>
  public Int32? FontSize { get; set; }

  /// <summary>
  ///   Bold style.
  /// </summary>
  public bool? Bold { get; set; }

  /// <summary>
  ///   Italic style.
  /// </summary>
  public bool? Italic { get; set; }

  /// <summary>
  ///   Underline style.
  /// </summary>
  public TextUnderlineKind? Underline { get; set; }

  /// <summary>
  ///   Strike-through style.
  /// </summary>
  public TextStrikeKind? Strike { get; set; }

  /// <summary>
  ///   Kerning value.
  /// </summary>
  public Int32? Kerning { get; set; }

  /// <summary>
  ///   Capitalization style.
  /// </summary>
  public TextCapsKind? Capital { get; set; }

  /// <summary>
  ///   Spacing value.
  /// </summary>
  public Int32? Spacing { get; set; }

  /// <summary>
  ///   Indicates normalization of height.
  /// </summary>
  public bool? NormalizeHeight { get; set; }

  /// <summary>
  ///   Baseline offset.
  /// </summary>
  public Int32? Baseline { get; set; }

  /// <summary>
  ///   Indicates proofing exclusion.
  /// </summary>
  public bool? NoProof { get; set; }

  /// <summary>
  ///   Indicates dirty state.
  /// </summary>
  public bool? Dirty { get; set; }

  /// <summary>
  ///   Indicates spelling error.
  /// </summary>
  public bool? SpellingError { get; set; }

  /// <summary>
  ///   Indicates smart tag clean state.
  /// </summary>
  public bool? SmartTagClean { get; set; }

  /// <summary>
  ///   Smart tag identifier.
  /// </summary>
  public UInt32? SmartTagId { get; set; }

  /// <summary>
  ///   Bookmark name.
  /// </summary>
  public string? Bookmark { get; set; }

  /// <summary>
  ///   Outline properties for the text.
  /// </summary>
  public LineProperties? Outline { get; set; }
}