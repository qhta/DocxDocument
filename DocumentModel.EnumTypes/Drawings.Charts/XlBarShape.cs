
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the shape
/// used with the 3-D bar or column chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlbarshape?view=office-pia` for Office interop details.
/// </remarks>
public enum XlBarShape
{
  /// <summary>
  /// Box.
  /// </summary>
  Box,
  /// <summary>
  /// Pyramid, coming to point at value.
  /// </summary>
  PyramidToPoint,
  /// <summary>
  /// Pyramid, truncated at value.
  /// </summary>
  PyramidToMax,
  /// <summary>
  /// Cylinder.
  /// </summary>
  Cylinder,
  /// <summary>
  /// Cone, coming to point at value.
  /// </summary>
  ConeToPoint,
  /// <summary>
  /// Cone, truncated at value.
  /// </summary>
  ConeToMax
}
