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
  /// Specifies how the insertion point progresses within bidirectional text.
  /// </summary>
  Logical = 0,
  /// <summary>
  /// Specifies how the insertion point progresses within bidirectional text.
  /// </summary>
  Visual = 1
}
