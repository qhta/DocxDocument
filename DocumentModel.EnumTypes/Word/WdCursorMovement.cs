namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how the insertion point progresses within bidirectional text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcursormovement?view=office-pia` for Office interop details.
/// </remarks>
public enum WdCursorMovement
{
  /// <summary>
  /// Insertion point progresses according to the direction of the language Microsoft Word detects.
  /// </summary>
  Logical = 0,
  /// <summary>
  /// Insertion point progresses to the next visually adjacent character.
  /// </summary>
  Visual = 1
}
