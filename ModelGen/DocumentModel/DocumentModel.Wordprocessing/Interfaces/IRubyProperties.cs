namespace DocumentModel.Wordprocessing;

/// <summary>
/// Phonetic Guide Properties.
/// </summary>
public interface IRubyProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Phonetic Guide Text Alignment.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.RubyAlignValues>? RubyAlign { get ; set; }
  
  /// <summary>
  /// Phonetic Guide Text Font Size.
  /// </summary>
  public IPhoneticGuideTextFontSize? PhoneticGuideTextFontSize { get ; set; }
  
  /// <summary>
  /// Distance Between Phonetic Guide Text and Phonetic Guide Base Text.
  /// </summary>
  public Int16Value? PhoneticGuideRaise { get ; set; }
  
  /// <summary>
  /// Phonetic Guide Base Text Font Size.
  /// </summary>
  public IPhoneticGuideBaseTextSize? PhoneticGuideBaseTextSize { get ; set; }
  
  /// <summary>
  /// Language ID for Phonetic Guide.
  /// </summary>
  public IStringValue? LanguageId { get ; set; }
  
  /// <summary>
  /// Invalidated Field Cache.
  /// </summary>
  public IDirty? Dirty { get ; set; }
  
}
