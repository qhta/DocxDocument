namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the replace criteria for a find-and-replace operation.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.replacement?view=word-pia"/>
public partial interface Replacement : InteropObject
{
  /// <summary>
  /// Returns or sets the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.replacement.font?view=word-pia"/>
  public Font Font { get; set; }

  /// <summary>
  /// Returns or sets the paragraph format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.replacement.paragraphformat?view=word-pia"/>
  public ParagraphFormat ParagraphFormat { get; set; }

  /// <summary>
  /// Returns or sets the style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.replacement.style?view=word-pia"/>
  public object Style { get; set; }

  /// <summary>
  /// Returns or sets the text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.replacement.text?view=word-pia"/>
  public string Text { get; set; }

  /// <summary>
  /// Returns or sets the language i d.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.replacement.languageid?view=word-pia"/>
  public WdLanguageID LanguageID { get; set; }

  /// <summary>
  /// Returns or sets the highlight.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.replacement.highlight?view=word-pia"/>
  public int Highlight { get; set; }

  /// <summary>
  /// Returns the frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.replacement.frame?view=word-pia"/>
  public Frame Frame { get; }

  /// <summary>
  /// Returns or sets the language i d far east.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.replacement.languageidfareast?view=word-pia"/>
  public WdLanguageID LanguageIDFarEast { get; set; }

  /// <summary>
  /// Returns or sets the no proofing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.replacement.noproofing?view=word-pia"/>
  public int NoProofing { get; set; }
}
