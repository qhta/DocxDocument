namespace DocumentModel.Wordprocessing;

/// <summary>
/// Contains font attributes (font name, font size, color, and so on) for an object.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.font?view=word-pia"/>
public partial interface ITextFormat
{
  /// <summary>
  /// Gets or sets the ligature setting for the font.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.ligatures?view=word-pia"/>
  public Ligatures? Ligatures { get; set; }

  /// <summary>
  /// Gets or sets the number form for the font.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.numberform?view=word-pia"/>
  public NumberForm? NumberForm { get; set; }

  /// <summary>
  /// Gets or sets the number spacing for the font.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.numberspacing?view=word-pia"/>
  public NumberSpacing? NumberSpacing { get; set; }

  /// <summary>
  /// Gets or sets whether contextual alternates are enabled.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.contextualalternates?view=word-pia"/>
  public int? ContextualAlternates { get; set; }

  /// <summary>
  /// Gets or sets the stylistic set for the font.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.stylisticset?view=word-pia"/>
  public StylisticSet? StylisticSet { get; set; }

}
