namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keysboundto?view=word-pia"/>
public partial interface IKeysBoundTo
{
  /// <summary>
  /// Returns the key binding for the specified key combination.
  /// </summary>
  /// <param name="KeyCode">The primary key code.</param>
  /// <param name="KeyCode2">The secondary key code.</param>
  /// <returns>The <see cref="KeyBinding"/> object for the specified keys.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keysboundto.key?view=word-pia"/>
  public KeyBinding Key(int KeyCode, int KeyCode2);
}
