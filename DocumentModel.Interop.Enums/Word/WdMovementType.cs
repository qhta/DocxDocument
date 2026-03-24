namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the way the selection is moved.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmovementtype?view=office-pia` for Office interop details.
/// </remarks>
public enum WdMovementType
{
  /// <summary>
  /// Specifies the way the selection is moved.
  /// </summary>
  Move = 0,
  /// <summary>
  /// Specifies the way the selection is moved.
  /// </summary>
  Extend = 1
}
