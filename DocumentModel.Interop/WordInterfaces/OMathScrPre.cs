namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an equation that contains a superscript or subscript to the left of the base.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrpre?view=word-pia"/>
public partial interface OMathScrPre : InteropObject
{
  /// <summary>
  /// The sub.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrpre.sub?view=word-pia"/>
  public OMath Sub { get; }

  /// <summary>
  /// The sup.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrpre.sup?view=word-pia"/>
  public OMath Sup { get; }

  /// <summary>
  /// The e.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrpre.e?view=word-pia"/>
  public OMath E { get; }
}
