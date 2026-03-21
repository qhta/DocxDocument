namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an equation that has an accent mark above the base.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathacc?view=word-pia"/>
public interface OMathAcc : InteropObject
{
  /// <summary>
  /// The e.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathacc.e?view=word-pia"/>
  public OMath E { get; }
  /// <summary>
  /// The char.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathacc.char?view=word-pia"/>
  public short Char { get; set; }

}
