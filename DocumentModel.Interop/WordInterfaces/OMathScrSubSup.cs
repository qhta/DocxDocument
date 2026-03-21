namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an equation with a base that contains a superscript or subscript.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsubsup?view=word-pia"/>
public partial interface OMathScrSubSup : InteropObject
{
  /// <summary>
  /// The e.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsubsup.e?view=word-pia"/>
  public OMath E { get; }

  /// <summary>
  /// The sub.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsubsup.sub?view=word-pia"/>
  public OMath Sub { get; }

  /// <summary>
  /// The sup.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsubsup.sup?view=word-pia"/>
  public OMath Sup { get; }

  /// <summary>
  /// The align scripts.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsubsup.alignscripts?view=word-pia"/>
  public bool AlignScripts { get; set; }
}
