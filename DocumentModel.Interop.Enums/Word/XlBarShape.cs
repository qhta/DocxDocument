namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the shape used with the 3-D bar or column chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.xlbarshape?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.XlBarShape")]
public enum BarShape
{
  /// <summary>
  /// Box.
  /// </summary>
  [InteropEnumValue("xlBox")]
  Box = 0,
  /// <summary>
  /// Pyramid, coming to point at value.
  /// </summary>
  [InteropEnumValue("xlPyramidToPoint")]
  PyramidToPoint = 1,
  /// <summary>
  /// Pyramid, truncated at value.
  /// </summary>
  [InteropEnumValue("xlPyramidToMax")]
  PyramidToMax = 2,
  /// <summary>
  /// Cylinder.
  /// </summary>
  [InteropEnumValue("xlCylinder")]
  Cylinder = 3,
  /// <summary>
  /// Cone, coming to point at value.
  /// </summary>
  [InteropEnumValue("xlConeToPoint")]
  ConeToPoint = 4,
  /// <summary>
  /// Cone, truncated at value.
  /// </summary>
  [InteropEnumValue("xlConeToMax")]
  ConeToMax = 5
}
