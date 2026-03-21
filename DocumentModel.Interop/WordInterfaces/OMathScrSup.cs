namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an equation with a base that contains a superscript.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsup?view=word-pia"/>
public interface OMathScrSup : InteropObject
{
  /// <summary>
  /// The e.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsup.e?view=word-pia"/>
  public OMath E { get; }
  /// <summary>
  /// The sup.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsup.sup?view=word-pia"/>
  public OMath Sup { get; }

}
