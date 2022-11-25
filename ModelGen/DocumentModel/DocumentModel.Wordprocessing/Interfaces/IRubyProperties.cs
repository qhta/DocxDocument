namespace DocumentModel.Wordprocessing;

/// <summary>
/// Phonetic Guide Properties.
/// </summary>
public interface IRubyProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Phonetic Guide Text Alignment.
  /// </summary>
  public DocumentModel.Wordprocessing.RubyAlignKind? RubyAlign { get ; set; }
  
  /// <summary>
  /// Phonetic Guide Text Font Size.
  /// </summary>
  public System.String? PhoneticGuideTextFontSize { get ; set; }
  
  /// <summary>
  /// Distance Between Phonetic Guide Text and Phonetic Guide Base Text.
  /// </summary>
  public System.Int16? PhoneticGuideRaise { get ; set; }
  
  /// <summary>
  /// Phonetic Guide Base Text Font Size.
  /// </summary>
  public System.String? PhoneticGuideBaseTextSize { get ; set; }
  
  /// <summary>
  /// Language ID for Phonetic Guide.
  /// </summary>
  public System.String? LanguageId { get ; set; }
  
  /// <summary>
  /// Invalidated Field Cache.
  /// </summary>
  public System.Boolean? Dirty { get ; set; }
  
}
