namespace DocumentModel.Interop.Core;

/// <summary>
/// This enumeration has been deprecated and should not be used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msomoverow?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoMoveRow")]
public enum MoveRow
{
  /// <summary>
  /// Internal use only.
  /// </summary>
  [InteropEnumValue("msoMoveRowFirst")]
  First = -4,
  /// <summary>
  /// Internal use only.
  /// </summary>
  [InteropEnumValue("msoMoveRowPrev")]
  Prev,
  /// <summary>
  /// Internal use only.
  /// </summary>
  [InteropEnumValue("msoMoveRowNext")]
  Next,
  /// <summary>
  /// Internal use only.
  /// </summary>
  [InteropEnumValue("msoMoveRowNbr")]
  Nbr
}
