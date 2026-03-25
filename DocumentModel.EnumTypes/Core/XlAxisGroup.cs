
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the type
/// of axis group.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlaxisgroup?view=office-pia` for Office interop details.
/// </remarks>
public enum XlAxisGroup
{
  /// <summary>
  /// Primary axis group.
  /// </summary>
  Primary = 1,
  /// <summary>
  /// Secondary axis group.
  /// </summary>
  Secondary
}
