namespace DocumentModel.Wordprocessing;

/// <summary>
/// Phonetic Guide.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRubyContent))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRubyBase))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRubyProperties))]
public class Ruby: IRuby
{
  /// <summary>
  /// Phonetic Guide Properties.
  /// </summary>
  public IRubyProperties? RubyProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Phonetic Guide Text.
  /// </summary>
  public IRubyContent? RubyContent
  {
    get;
    set;
  }
  
  /// <summary>
  /// Phonetic Guide Base Text.
  /// </summary>
  public IRubyBase? RubyBase
  {
    get;
    set;
  }
  
}
