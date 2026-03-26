namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the way the selection is moved.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmovementtype?view=office-pia` for Office interop details.
/// </remarks>
public enum MovementType
{
  /// <summary>
  /// The selection is collapsed to an insertion point and moved to the end of the specified unit. Default.
  /// </summary>
  Move = 0,
  /// <summary>
  /// The end of the selection is extended to the end of the specified unit.
  /// </summary>
  Extend = 1
}
