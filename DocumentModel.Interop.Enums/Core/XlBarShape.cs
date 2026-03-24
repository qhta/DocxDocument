
namespace DocumentModel.Interop.Core;

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
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Box.
  /// </summary>
  Box,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Pyramid, coming to
  /// point at value.
  /// </summary>
  PyramidToPoint,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Pyramid, truncated
  /// at value.
  /// </summary>
  PyramidToMax,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Cylinder.
  /// </summary>
  Cylinder,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Cone, coming to
  /// point at value.
  /// </summary>
  ConeToPoint,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Cone, truncated at
  /// value.
  /// </summary>
  ConeToMax
}
