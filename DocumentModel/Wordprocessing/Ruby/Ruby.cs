namespace DocumentModel.Wordprocessing;

/// <summary>
///   This element specifies  a phonetic guide at the current location Iin the document. 
///   A phonetic guide (often called ruby text) is a run of content with base text which appears 
///   at the normal baseline location Ifor text Iin this run, 
///   with phonetic guide text displayed above it Iin the document. 
///   The resulting construct is called a phonetic guide as it is typically used 
///   Ito map words Iin one language Ito another phonetically.
/// </summary>
public class Ruby: ModelElement, IRunContent, IRubyContent
{
  /// <summary>
  ///   Phonetic Guide Properties.
  /// </summary>
  public RubyProperties? RubyProperties { get; set; }

  /// <summary>
  ///   Phonetic Guide Text.
  /// </summary>
  public RubyContent? RubyContent { get; set; }

  /// <summary>
  ///   Phonetic Guide Base Text.
  /// </summary>
  public RubyBase? RubyBase { get; set; }
}
