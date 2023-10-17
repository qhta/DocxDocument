namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a set of properties which determine the behavior and appearance of a phonetic guide within the document.
/// </summary>
public partial class RubyProperties
{
  
  /// <summary>
  ///   Phonetic Guide Text Alignment.
  /// </summary>
  public DocumentModel.Wordprocessing.RubyAlignKind? RubyAlign { get; set; }
  
  
  /// <summary>
  ///   Phonetic Guide Text Font Size.
  /// </summary>
  public DocumentModel.Wordprocessing.PhoneticGuideTextFontSize? PhoneticGuideTextFontSize { get; set; }
  
  
  /// <summary>
  ///   Distance Between Phonetic Guide Text and Phonetic Guide Base Text.
  /// </summary>
  public Int16? PhoneticGuideRaise { get; set; }
  
  
  /// <summary>
  ///   Phonetic Guide Base Text Font Size.
  /// </summary>
  public DocumentModel.Wordprocessing.PhoneticGuideBaseTextSize? PhoneticGuideBaseTextSize { get; set; }
  
  
  /// <summary>
  ///   Language ID for Phonetic Guide.
  /// </summary>
  public String? LanguageId { get; set; }
  
  
  /// <summary>
  ///   Invalidated Field Cache.
  /// </summary>
  public DocumentModel.Wordprocessing.Dirty? Dirty { get; set; }
  
}
