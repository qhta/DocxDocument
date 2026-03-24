
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the point
/// on the specified axis where the other axis crosses.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlaxiscrosses?view=office-pia` for Office interop details.
/// </remarks>
public enum XlAxisCrosses
{
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Microsoft Excel sets
  /// the axis crossing point.
  /// </summary>
  Automatic = -4105,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). The CrossesAt
  /// property specifies the axis crossing point.
  /// </summary>
  Custom = -4114,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). The axis crosses at
  /// the maximum value.
  /// </summary>
  Maximum = 2,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). The axis crosses at
  /// the minimum value.
  /// </summary>
  Minimum = 4
}
