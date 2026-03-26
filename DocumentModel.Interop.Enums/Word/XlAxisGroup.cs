namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of axis group.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.xlaxisgroup?view=office-pia` for Office interop details.
/// </remarks>
public enum AxisGroup
{
  /// <summary>
  /// Primary axis group.
  /// </summary>
  Primary = 1,
  /// <summary>
  /// Secondary axis group.
  /// </summary>
  Secondary = 2
}
