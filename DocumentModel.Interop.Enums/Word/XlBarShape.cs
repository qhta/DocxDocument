namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the shape used with the 3-D bar or column chart.
/// </summary>
public enum XlBarShape
{
  /// <summary>
  /// Box.
  /// </summary>
  xlBox = unchecked((int)0),
  /// <summary>
  /// Pyramid, coming to point at value.
  /// </summary>
  xlPyramidToPoint = unchecked((int)1),
  /// <summary>
  /// Pyramid, truncated at value.
  /// </summary>
  xlPyramidToMax = unchecked((int)2),
  /// <summary>
  /// Cylinder.
  /// </summary>
  xlCylinder = unchecked((int)3),
  /// <summary>
  /// Cone, coming to point at value.
  /// </summary>
  xlConeToPoint = unchecked((int)4),
  /// <summary>
  /// Cone, truncated at value.
  /// </summary>
  xlConeToMax = unchecked((int)5)
}
