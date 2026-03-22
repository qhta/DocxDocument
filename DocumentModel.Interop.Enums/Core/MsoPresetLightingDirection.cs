namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the location of lighting on an extruded (three-dimensional) shape relative to the shape.
/// </summary>
public enum MsoPresetLightingDirection
{
  /// <summary>
  /// Specifies the location of lighting on an extruded (three-dimensional) shape relative to the shape.
  /// </summary>
  msoPresetLightingDirectionMixed = -2,
  /// <summary>
  /// Lighting comes from the top left.
  /// </summary>
  msoLightingTopLeft = 1,
  /// <summary>
  /// Lighting comes from the top.
  /// </summary>
  msoLightingTop = 2,
  /// <summary>
  /// Lighting comes from the top right.
  /// </summary>
  msoLightingTopRight = 3,
  /// <summary>
  /// Lighting comes from the left.
  /// </summary>
  msoLightingLeft = 4,
  /// <summary>
  /// No lighting.
  /// </summary>
  msoLightingNone = 5,
  /// <summary>
  /// Lighting comes from the right.
  /// </summary>
  msoLightingRight = 6,
  /// <summary>
  /// Lighting comes from the bottom left.
  /// </summary>
  msoLightingBottomLeft = 7,
  /// <summary>
  /// Lighting comes from the bottom.
  /// </summary>
  msoLightingBottom = 8,
  /// <summary>
  /// Lighting comes from the bottom right.
  /// </summary>
  msoLightingBottomRight = 9
}
