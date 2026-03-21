namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an equation with a base that contains a superscript or subscript.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsubsup?view=word-pia"/>
public partial interface OMathScrSubSup : InteropObject
{
  /// <summary>
  /// The e.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsubsup.e?view=word-pia"/>
  public OMath E { get; }

  /// <summary>
  /// The sub.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsubsup.sub?view=word-pia"/>
  public OMath Sub { get; }

  /// <summary>
  /// The sup.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsubsup.sup?view=word-pia"/>
  public OMath Sup { get; }

  /// <summary>
  /// The align scripts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsubsup.alignscripts?view=word-pia"/>
  public bool AlignScripts { get; set; }
}
