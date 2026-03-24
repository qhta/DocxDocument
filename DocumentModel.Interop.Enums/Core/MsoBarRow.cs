namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies whether a command bar is in the first row or last row relative to other command bars in the same
/// docking area.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobarrow?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoBarRow
{
  /// <summary>
  /// First row of docking area.
  /// </summary>
  First = 0,
  /// <summary>
  /// Specifies whether a command bar is in the first row or last row relative to other command bars in the same
  /// docking area.
  /// </summary>
  Last = -1
}
