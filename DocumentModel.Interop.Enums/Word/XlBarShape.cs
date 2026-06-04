namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the shape used with the 3-D bar or column chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.xlbarshape?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("XlBarShape")]
public enum BarShape
{
  /// <summary>
  /// Box.
  /// </summary>
  [WordInteropEnumValue("xlBox")]
  Box = 0,
  /// <summary>
  /// Pyramid, coming to point at value.
  /// </summary>
  [WordInteropEnumValue("xlPyramidToPoint")]
  PyramidToPoint = 1,
  /// <summary>
  /// Pyramid, truncated at value.
  /// </summary>
  [WordInteropEnumValue("xlPyramidToMax")]
  PyramidToMax = 2,
  /// <summary>
  /// Cylinder.
  /// </summary>
  [WordInteropEnumValue("xlCylinder")]
  Cylinder = 3,
  /// <summary>
  /// Cone, coming to point at value.
  /// </summary>
  [WordInteropEnumValue("xlConeToPoint")]
  ConeToPoint = 4,
  /// <summary>
  /// Cone, truncated at value.
  /// </summary>
  [WordInteropEnumValue("xlConeToMax")]
  ConeToMax = 5
}
