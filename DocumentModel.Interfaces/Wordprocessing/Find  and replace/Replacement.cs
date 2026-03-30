namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the replace criteria for a find-and-replace operation.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.replacement?view=word-pia"/>
public partial interface IReplacement : IModelObject
{
  /// <summary>
  /// Returns or sets a Font object that represents the character formatting of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.replacement.font?view=word-pia"/>
  public IFont Font { get; set; }

  /// <summary>
  /// Returns or sets a ParagraphFormat object that represents the paragraph settings for the specified replacement
  /// operation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.replacement.paragraphformat?view=word-pia"/>
  public IParagraphFormat ParagraphFormat { get; set; }

  /// <summary>
  /// Returns or sets the style for the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.replacement.style?view=word-pia"/>
  public object Style { get; set; }

  /// <summary>
  /// Returns or sets the text to find or replace in the specified range or selection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.replacement.text?view=word-pia"/>
  public string Text { get; set; }

  /// <summary>
  /// Returns or sets the language for the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.replacement.languageid?view=word-pia"/>
  public LanguageID LanguageID { get; set; }

  /// <summary>
  /// True if highlight formatting is applied to the replacement text. Can return or be set to True, False, or
  /// wdUndefined.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.replacement.highlight?view=word-pia"/>
  public int Highlight { get; set; }

  /// <summary>
  /// Returns a Frame object that represents the frame formatting for the specified style or find-and- replace
  /// operation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.replacement.frame?view=word-pia"/>
  public IFrame Frame { get; }

  /// <summary>
  /// Returns or sets an East Asian language for the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.replacement.languageidfareast?view=word-pia"/>
  public LanguageID LanguageIDFarEast { get; set; }

  /// <summary>
  /// True if Microsoft Word finds or replaces text that the spelling and grammar checker ignores.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.replacement.noproofing?view=word-pia"/>
  public int NoProofing { get; set; }
}
