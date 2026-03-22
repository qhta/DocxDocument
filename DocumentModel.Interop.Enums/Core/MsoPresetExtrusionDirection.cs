namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the direction that the extrusion's sweep path takes away from the extruded shape (the front face of
/// the extrusion).
/// </summary>
public enum MsoPresetExtrusionDirection
{
  /// <summary>
  /// Specifies the direction that the extrusion's sweep path takes away from the extruded shape (the front face of
  /// the extrusion).
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// Bottom right.
  /// </summary>
  BottomRight = 1,
  /// <summary>
  /// Bottom.
  /// </summary>
  Bottom = 2,
  /// <summary>
  /// Bottom left.
  /// </summary>
  BottomLeft = 3,
  /// <summary>
  /// Right.
  /// </summary>
  Right = 4,
  /// <summary>
  /// No extrusion.
  /// </summary>
  None = 5,
  /// <summary>
  /// Left.
  /// </summary>
  Left = 6,
  /// <summary>
  /// Top right.
  /// </summary>
  TopRight = 7,
  /// <summary>
  /// Top.
  /// </summary>
  Top = 8,
  /// <summary>
  /// Top left.
  /// </summary>
  TopLeft = 9
}
