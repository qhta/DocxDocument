
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the shape
/// used with the 3-D bar or column chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlbarshape?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.XlBarShape))]
public enum BarShape
{
  /// <summary>
  /// Box.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlBarShape.xlBox))]
  Box,
  /// <summary>
  /// Pyramid, coming to point at value.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlBarShape.xlPyramidToPoint))]
  PyramidToPoint,
  /// <summary>
  /// Pyramid, truncated at value.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlBarShape.xlPyramidToMax))]
  PyramidToMax,
  /// <summary>
  /// Cylinder.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlBarShape.xlCylinder))]
  Cylinder,
  /// <summary>
  /// Cone, coming to point at value.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlBarShape.xlConeToPoint))]
  ConeToPoint,
  /// <summary>
  /// Cone, truncated at value.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlBarShape.xlConeToMax))]
  ConeToMax
}
