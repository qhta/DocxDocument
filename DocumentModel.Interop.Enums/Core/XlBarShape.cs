
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the shape
/// used with the 3-D bar or column chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlbarshape?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("XlBarShape")]
public enum BarShape
{
  /// <summary>
  /// Box.
  /// </summary>
  [OfficeInteropEnumValue("xlBox")]
  Box,
  /// <summary>
  /// Pyramid, coming to point at value.
  /// </summary>
  [OfficeInteropEnumValue("xlPyramidToPoint")]
  PyramidToPoint,
  /// <summary>
  /// Pyramid, truncated at value.
  /// </summary>
  [OfficeInteropEnumValue("xlPyramidToMax")]
  PyramidToMax,
  /// <summary>
  /// Cylinder.
  /// </summary>
  [OfficeInteropEnumValue("xlCylinder")]
  Cylinder,
  /// <summary>
  /// Cone, coming to point at value.
  /// </summary>
  [OfficeInteropEnumValue("xlConeToPoint")]
  ConeToPoint,
  /// <summary>
  /// Cone, truncated at value.
  /// </summary>
  [OfficeInteropEnumValue("xlConeToMax")]
  ConeToMax
}
