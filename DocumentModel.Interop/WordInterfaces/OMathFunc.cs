namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the application of a function or an argument in an equation that consists of a function name, such as sin or cos, and an argument.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunc?view=word-pia"/>
public interface OMathFunc : InteropObject
{
  /// <summary>
  /// The fname.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunc.fname?view=word-pia"/>
  public OMath FName { get; }
  /// <summary>
  /// The e.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunc.e?view=word-pia"/>
  public OMath E { get; }

}
