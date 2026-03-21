namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an equation that contains a superscript or subscript to the left of the base.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrpre?view=word-pia"/>
public partial interface OMathScrPre : InteropObject
{
  /// <summary>
  /// Returns the sub.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrpre.sub?view=word-pia"/>
  public OMath Sub { get; }

  /// <summary>
  /// Returns the sup.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrpre.sup?view=word-pia"/>
  public OMath Sup { get; }

  /// <summary>
  /// Returns the e.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrpre.e?view=word-pia"/>
  public OMath E { get; }
}
