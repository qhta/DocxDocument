namespace DocumentModel.Wordprocessing;
/// <summary>
///   Phonetic Guide Properties.
/// </summary>
public class RubyProperties: ModelElement
{
  /// <summary>
  ///   Phonetic Guide Text Alignment.
  /// </summary>
  public RubyAlignKind? RubyAlign { get; set; }
  /// <summary>
  ///   Phonetic Guide Text Font Size.
  /// </summary>
  public Hps? PhoneticGuideTextFontSize { get; set; }
  /// <summary>
  ///   Distance Between Phonetic Guide Text and Phonetic Guide Base Text.
  /// </summary>
  public Int16? PhoneticGuideRaise { get; set; }
  /// <summary>
  ///   Phonetic Guide Base Text Font Size.
  /// </summary>
  public Hps? PhoneticGuideBaseTextSize { get; set; }
  /// <summary>
  ///   Language ID for Phonetic Guide.
  /// </summary>
  public string? LanguageId { get; set; }
  /// <summary>
  ///   Invalidated Field Cache.
  /// </summary>
  public bool? Dirty { get; set; }
}