namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the character width of the specified range.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcharacterwidth?view=office-pia` for Office interop details.
/// </remarks>
public enum CharacterWidth
{
  /// <summary>
  /// Characters are displayed in half the character width.
  /// </summary>
  HalfWidth = 6,
  /// <summary>
  /// Characters are displayed in full character width.
  /// </summary>
  FullWidth = 7
}
