namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an equation that has an accent mark above the base.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathacc?view=word-pia"/>
public interface OMathAcc : InteropObject
{
  /// <summary>
  /// Returns the e.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathacc.e?view=word-pia"/>
  public OMath E { get; }
  /// <summary>
  /// Returns or sets the char.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathacc.char?view=word-pia"/>
  public short Char { get; set; }

}
