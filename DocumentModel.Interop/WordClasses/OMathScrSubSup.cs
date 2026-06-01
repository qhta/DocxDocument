namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an equation with a base that contains a superscript or subscript.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsubsup?view=word-pia"/>
public partial class OMathScrSubSup : InteropObject
{
  /// <summary>
  /// Returns the base expression.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsubsup.e?view=word-pia"/>
  public OMath E { get; }

  /// <summary>
  /// Returns the subscript expression.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsubsup.sub?view=word-pia"/>
  public OMath Sub { get; }

  /// <summary>
  /// Returns the superscript expression.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsubsup.sup?view=word-pia"/>
  public OMath Sup { get; }

  /// <summary>
  /// Returns or sets whether the scripts are aligned.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsubsup.alignscripts?view=word-pia"/>
  public bool AlignScripts { get; set; }
}
