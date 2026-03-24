namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the shape used with the 3-D bar or column chart.
/// </summary>
public enum XlBarShape
{
  /// <summary>
  /// Box.
  /// </summary>
  Box = unchecked((int)0),
  /// <summary>
  /// Pyramid, coming to point at value.
  /// </summary>
  PyramidToPoint = unchecked((int)1),
  /// <summary>
  /// Pyramid, truncated at value.
  /// </summary>
  PyramidToMax = unchecked((int)2),
  /// <summary>
  /// Cylinder.
  /// </summary>
  Cylinder = unchecked((int)3),
  /// <summary>
  /// Cone, coming to point at value.
  /// </summary>
  ConeToPoint = unchecked((int)4),
  /// <summary>
  /// Cone, truncated at value.
  /// </summary>
  ConeToMax = unchecked((int)5)
}
