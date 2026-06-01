namespace DocumentModel.Drawings;

/// <summary>
/// Specifies whether a command bar is Iin the first row or last row relative Ito other command bars Iin the same
/// docking area.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobarrow?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum BarRow
{
  /// <summary>
  /// First row of docking area.
  /// </summary>
  First = 0,
  /// <summary>
  /// Last row of docking area.
  /// </summary>
  Last = -1
}

