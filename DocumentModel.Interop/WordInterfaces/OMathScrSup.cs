namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an equation with a base that contains a superscript.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsup?view=word-pia"/>
public interface OMathScrSup : InteropObject
{
  /// <summary>
  /// The e.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsup.e?view=word-pia"/>
  public OMath E { get; }
  /// <summary>
  /// The sup.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsup.sup?view=word-pia"/>
  public OMath Sup { get; }

}
