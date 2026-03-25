
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the
/// position of major and minor tick marks for an axis.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xltickmark?view=office-pia` for Office interop details.
/// </remarks>
public enum XlTickMark
{
  /// <summary>
  /// Crosses the axis.
  /// </summary>
  Cross = 4,
  /// <summary>
  /// Inside the axis.
  /// </summary>
  Inside = 2,
  /// <summary>
  /// No mark.
  /// </summary>
  None = -4142,
  /// <summary>
  /// Outside the axis.
  /// </summary>
  Outside = 3
}
