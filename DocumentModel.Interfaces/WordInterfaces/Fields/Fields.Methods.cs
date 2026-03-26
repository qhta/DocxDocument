namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fields?view=word-pia"/>
public partial interface Fields: InteropObject
{
  /// <summary>
  /// Toggles the display of the fields between field codes and field results.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fields.toggleshowcodes?view=word-pia"/>
  public void ToggleShowCodes();
}
