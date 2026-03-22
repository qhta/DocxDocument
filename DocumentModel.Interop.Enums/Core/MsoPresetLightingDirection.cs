namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the location of lighting on an extruded (three-dimensional) shape relative to the shape.
/// </summary>
public enum MsoPresetLightingDirection
{
  /// <summary>
  /// Specifies the location of lighting on an extruded (three-dimensional) shape relative to the shape.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// Lighting comes from the top left.
  /// </summary>
  TopLeft = 1,
  /// <summary>
  /// Lighting comes from the top.
  /// </summary>
  Top = 2,
  /// <summary>
  /// Lighting comes from the top right.
  /// </summary>
  TopRight = 3,
  /// <summary>
  /// Lighting comes from the left.
  /// </summary>
  Left = 4,
  /// <summary>
  /// No lighting.
  /// </summary>
  None = 5,
  /// <summary>
  /// Lighting comes from the right.
  /// </summary>
  Right = 6,
  /// <summary>
  /// Lighting comes from the bottom left.
  /// </summary>
  BottomLeft = 7,
  /// <summary>
  /// Lighting comes from the bottom.
  /// </summary>
  Bottom = 8,
  /// <summary>
  /// Lighting comes from the bottom right.
  /// </summary>
  BottomRight = 9
}
