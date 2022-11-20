namespace DocumentModel.Wordprocessing;

/// <summary>
/// Phonetic Guide Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPhoneticGuideTextFontSize))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPhoneticGuideBaseTextSize))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPhoneticGuideRaise))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ILanguageId))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDirty))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRubyAlign))]
public class RubyProperties: IRubyProperties
{
  /// <summary>
  /// Phonetic Guide Text Alignment.
  /// </summary>
  public IRubyAlign? RubyAlign
  {
    get;
    set;
  }
  
  /// <summary>
  /// Phonetic Guide Text Font Size.
  /// </summary>
  public IPhoneticGuideTextFontSize? PhoneticGuideTextFontSize
  {
    get;
    set;
  }
  
  /// <summary>
  /// Distance Between Phonetic Guide Text and Phonetic Guide Base Text.
  /// </summary>
  public IPhoneticGuideRaise? PhoneticGuideRaise
  {
    get;
    set;
  }
  
  /// <summary>
  /// Phonetic Guide Base Text Font Size.
  /// </summary>
  public IPhoneticGuideBaseTextSize? PhoneticGuideBaseTextSize
  {
    get;
    set;
  }
  
  /// <summary>
  /// Language ID for Phonetic Guide.
  /// </summary>
  public ILanguageId? LanguageId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Invalidated Field Cache.
  /// </summary>
  public IDirty? Dirty
  {
    get;
    set;
  }
  
}
