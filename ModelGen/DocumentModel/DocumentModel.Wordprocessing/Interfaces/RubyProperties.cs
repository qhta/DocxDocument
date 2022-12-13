namespace DocumentModel.Wordprocessing;

/// <summary>
/// Phonetic Guide Properties.
/// </summary>
public interface RubyProperties
{
  /// <summary>
  /// Phonetic Guide Text Alignment.
  /// </summary>
  public DocumentModel.Wordprocessing.RubyAlignKind? RubyAlign { get ; set; }
  
  /// <summary>
  /// Phonetic Guide Text Font Size.
  /// </summary>
  public String? PhoneticGuideTextFontSize { get ; set; }
  
  /// <summary>
  /// Distance Between Phonetic Guide Text and Phonetic Guide Base Text.
  /// </summary>
  public Int16? PhoneticGuideRaise { get ; set; }
  
  /// <summary>
  /// Phonetic Guide Base Text Font Size.
  /// </summary>
  public String? PhoneticGuideBaseTextSize { get ; set; }
  
  /// <summary>
  /// Language ID for Phonetic Guide.
  /// </summary>
  public String? LanguageId { get ; set; }
  
  /// <summary>
  /// Invalidated Field Cache.
  /// </summary>
  public Boolean? Dirty { get ; set; }
  
}
