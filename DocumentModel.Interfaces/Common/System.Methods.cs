namespace DocumentModel;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system?view=word-pia"/>
public partial interface ISystem: InteropObject
{
  /// <summary>
  /// Returns the profile string.
  /// </summary>
  /// <param name="Section">Specifies the section.</param>
  /// <param name="Key">Specifies the key.</param>
  /// <returns>The resulting string value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.profilestring?view=word-pia"/>
  public string ProfileString(string Section, string Key);

  /// <summary>
  /// Starts the Microsoft System Information application if it's not running, or switches to it if it's already
  /// running.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.msinfo?view=word-pia"/>
  public void MSInfo();
}
