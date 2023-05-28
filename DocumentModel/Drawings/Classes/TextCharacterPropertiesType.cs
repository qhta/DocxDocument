namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TextCharacterPropertiesType Class.
/// </summary>
public class TextCharacterPropertiesType: ModelElement
{
  /// <summary>
  ///   Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public bool? SmtClean { get; set; }

  /// <summary>
  ///   Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public UInt32? SmtId { get; set; }

  /// <summary>
  ///   kumimoji
  /// </summary>
  public bool? Kumimoji { get; set; }

  /// <summary>
  ///   lang
  /// </summary>
  public string? Language { get; set; }

  /// <summary>
  ///   altLang
  /// </summary>
  public string? AlternativeLanguage { get; set; }

  /// <summary>
  ///   sz
  /// </summary>
  public Int32? FontSize { get; set; }

  /// <summary>
  ///   b
  /// </summary>
  public bool? Bold { get; set; }

  /// <summary>
  ///   i
  /// </summary>
  public bool? Italic { get; set; }

  /// <summary>
  ///   u
  /// </summary>
  public TextUnderlineKind? Underline { get; set; }

  /// <summary>
  ///   strike
  /// </summary>
  public TextStrikeKind? Strike { get; set; }

  /// <summary>
  ///   kern
  /// </summary>
  public Int32? Kerning { get; set; }

  /// <summary>
  ///   cap
  /// </summary>
  public TextCapsKind? Capital { get; set; }

  /// <summary>
  ///   spc
  /// </summary>
  public Int32? Spacing { get; set; }

  /// <summary>
  ///   normalizeH
  /// </summary>
  public bool? NormalizeHeight { get; set; }

  /// <summary>
  ///   baseline
  /// </summary>
  public Int32? Baseline { get; set; }

  /// <summary>
  ///   noProof
  /// </summary>
  public bool? NoProof { get; set; }

  /// <summary>
  ///   dirty
  /// </summary>
  public bool? Dirty { get; set; }

  /// <summary>
  ///   err
  /// </summary>
  public bool? SpellingError { get; set; }

  /// <summary>
  ///   smtClean
  /// </summary>
  public bool? SmartTagClean { get; set; }

  /// <summary>
  ///   smtId
  /// </summary>
  public UInt32? SmartTagId { get; set; }

  /// <summary>
  ///   bmk
  /// </summary>
  public string? Bookmark { get; set; }

  /// <summary>
  ///   Outline.
  /// </summary>
  public LineProperties? Outline { get; set; }
}