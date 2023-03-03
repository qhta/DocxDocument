namespace DocumentModel.Drawings;

/// <summary>
///   Preset Camera Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PresetCameraKind
{
  /// <summary>
  ///   Legacy Oblique Top Left.
  /// </summary>
  LegacyObliqueTopLeft,

  /// <summary>
  ///   Legacy Oblique Top.
  /// </summary>
  LegacyObliqueTop,

  /// <summary>
  ///   Legacy Oblique Top Right.
  /// </summary>
  LegacyObliqueTopRight,

  /// <summary>
  ///   Legacy Oblique Left.
  /// </summary>
  LegacyObliqueLeft,

  /// <summary>
  ///   Legacy Oblique Front.
  /// </summary>
  LegacyObliqueFront,

  /// <summary>
  ///   Legacy Oblique Right.
  /// </summary>
  LegacyObliqueRight,

  /// <summary>
  ///   Legacy Oblique Bottom Left.
  /// </summary>
  LegacyObliqueBottomLeft,

  /// <summary>
  ///   Legacy Oblique Bottom.
  /// </summary>
  LegacyObliqueBottom,

  /// <summary>
  ///   Legacy Oblique Bottom Right.
  /// </summary>
  LegacyObliqueBottomRight,

  /// <summary>
  ///   Legacy Perspective Top Left.
  /// </summary>
  LegacyPerspectiveTopLeft,

  /// <summary>
  ///   Legacy Perspective Top.
  /// </summary>
  LegacyPerspectiveTop,

  /// <summary>
  ///   Legacy Perspective Top Right.
  /// </summary>
  LegacyPerspectiveTopRight,

  /// <summary>
  ///   Legacy Perspective Left.
  /// </summary>
  LegacyPerspectiveLeft,

  /// <summary>
  ///   Legacy Perspective Front.
  /// </summary>
  LegacyPerspectiveFront,

  /// <summary>
  ///   Legacy Perspective Right.
  /// </summary>
  LegacyPerspectiveRight,

  /// <summary>
  ///   Legacy Perspective Bottom Left.
  /// </summary>
  LegacyPerspectiveBottomLeft,

  /// <summary>
  ///   Legacy Perspective Bottom.
  /// </summary>
  LegacyPerspectiveBottom,

  /// <summary>
  ///   Legacy Perspective Bottom Right.
  /// </summary>
  LegacyPerspectiveBottomRight,

  /// <summary>
  ///   Orthographic Front.
  /// </summary>
  OrthographicFront,

  /// <summary>
  ///   Isometric Top Up.
  /// </summary>
  IsometricTopUp,

  /// <summary>
  ///   Isometric Top Down.
  /// </summary>
  IsometricTopDown,

  /// <summary>
  ///   Isometric Bottom Up.
  /// </summary>
  IsometricBottomUp,

  /// <summary>
  ///   Isometric Bottom Down.
  /// </summary>
  IsometricBottomDown,

  /// <summary>
  ///   Isometric Left Up.
  /// </summary>
  IsometricLeftUp,

  /// <summary>
  ///   Isometric Left Down.
  /// </summary>
  IsometricLeftDown,

  /// <summary>
  ///   Isometric Right Up.
  /// </summary>
  IsometricRightUp,

  /// <summary>
  ///   Isometric Right Down.
  /// </summary>
  IsometricRightDown,

  /// <summary>
  ///   Isometric Off Axis 1 Left.
  /// </summary>
  IsometricOffAxis1Left,

  /// <summary>
  ///   Isometric Off Axis 1 Right.
  /// </summary>
  IsometricOffAxis1Right,

  /// <summary>
  ///   Isometric Off Axis 1 Top.
  /// </summary>
  IsometricOffAxis1Top,

  /// <summary>
  ///   Isometric Off Axis 2 Left.
  /// </summary>
  IsometricOffAxis2Left,

  /// <summary>
  ///   Isometric Off Axis 2 Right.
  /// </summary>
  IsometricOffAxis2Right,

  /// <summary>
  ///   Isometric Off Axis 2 Top.
  /// </summary>
  IsometricOffAxis2Top,

  /// <summary>
  ///   Isometric Off Axis 3 Left.
  /// </summary>
  IsometricOffAxis3Left,

  /// <summary>
  ///   Isometric Off Axis 3 Right.
  /// </summary>
  IsometricOffAxis3Right,

  /// <summary>
  ///   Isometric Off Axis 3 Bottom.
  /// </summary>
  IsometricOffAxis3Bottom,

  /// <summary>
  ///   Isometric Off Axis 4 Left.
  /// </summary>
  IsometricOffAxis4Left,

  /// <summary>
  ///   Isometric Off Axis 4 Right.
  /// </summary>
  IsometricOffAxis4Right,

  /// <summary>
  ///   Isometric Off Axis 4 Bottom.
  /// </summary>
  IsometricOffAxis4Bottom,

  /// <summary>
  ///   Oblique Top Left.
  /// </summary>
  ObliqueTopLeft,

  /// <summary>
  ///   Oblique Top.
  /// </summary>
  ObliqueTop,

  /// <summary>
  ///   Oblique Top Right.
  /// </summary>
  ObliqueTopRight,

  /// <summary>
  ///   Oblique Left.
  /// </summary>
  ObliqueLeft,

  /// <summary>
  ///   Oblique Right.
  /// </summary>
  ObliqueRight,

  /// <summary>
  ///   Oblique Bottom Left.
  /// </summary>
  ObliqueBottomLeft,

  /// <summary>
  ///   Oblique Bottom.
  /// </summary>
  ObliqueBottom,

  /// <summary>
  ///   Oblique Bottom Right.
  /// </summary>
  ObliqueBottomRight,

  /// <summary>
  ///   Perspective Front.
  /// </summary>
  PerspectiveFront,

  /// <summary>
  ///   Perspective Left.
  /// </summary>
  PerspectiveLeft,

  /// <summary>
  ///   Perspective Right.
  /// </summary>
  PerspectiveRight,

  /// <summary>
  ///   Orthographic Above.
  /// </summary>
  PerspectiveAbove,

  /// <summary>
  ///   Perspective Below.
  /// </summary>
  PerspectiveBelow,

  /// <summary>
  ///   Perspective Above Left Facing.
  /// </summary>
  PerspectiveAboveLeftFacing,

  /// <summary>
  ///   Perspective Above Right Facing.
  /// </summary>
  PerspectiveAboveRightFacing,

  /// <summary>
  ///   Perspective Contrasting Left Facing.
  /// </summary>
  PerspectiveContrastingLeftFacing,

  /// <summary>
  ///   Perspective Contrasting Right Facing.
  /// </summary>
  PerspectiveContrastingRightFacing,

  /// <summary>
  ///   Perspective Heroic Left Facing.
  /// </summary>
  PerspectiveHeroicLeftFacing,

  /// <summary>
  ///   Perspective Heroic Right Facing.
  /// </summary>
  PerspectiveHeroicRightFacing,

  /// <summary>
  ///   Perspective Heroic Extreme Left Facing.
  /// </summary>
  PerspectiveHeroicExtremeLeftFacing,

  /// <summary>
  ///   Perspective Heroic Extreme Right Facing.
  /// </summary>
  PerspectiveHeroicExtremeRightFacing,

  /// <summary>
  ///   Perspective Relaxed.
  /// </summary>
  PerspectiveRelaxed,

  /// <summary>
  ///   Perspective Relaxed Moderately.
  /// </summary>
  PerspectiveRelaxedModerately
}