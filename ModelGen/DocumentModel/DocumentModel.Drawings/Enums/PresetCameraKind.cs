namespace DocumentModel.Drawings;

/// <summary>
/// Preset Camera Type
/// </summary>
public enum PresetCameraKind
{
  /// <summary>
  /// Legacy Oblique Top Left.
  /// </summary>
  [XmlEnum("legacyObliqueTopLeft")]
  LegacyObliqueTopLeft,
  
  /// <summary>
  /// Legacy Oblique Top.
  /// </summary>
  [XmlEnum("legacyObliqueTop")]
  LegacyObliqueTop,
  
  /// <summary>
  /// Legacy Oblique Top Right.
  /// </summary>
  [XmlEnum("legacyObliqueTopRight")]
  LegacyObliqueTopRight,
  
  /// <summary>
  /// Legacy Oblique Left.
  /// </summary>
  [XmlEnum("legacyObliqueLeft")]
  LegacyObliqueLeft,
  
  /// <summary>
  /// Legacy Oblique Front.
  /// </summary>
  [XmlEnum("legacyObliqueFront")]
  LegacyObliqueFront,
  
  /// <summary>
  /// Legacy Oblique Right.
  /// </summary>
  [XmlEnum("legacyObliqueRight")]
  LegacyObliqueRight,
  
  /// <summary>
  /// Legacy Oblique Bottom Left.
  /// </summary>
  [XmlEnum("legacyObliqueBottomLeft")]
  LegacyObliqueBottomLeft,
  
  /// <summary>
  /// Legacy Oblique Bottom.
  /// </summary>
  [XmlEnum("legacyObliqueBottom")]
  LegacyObliqueBottom,
  
  /// <summary>
  /// Legacy Oblique Bottom Right.
  /// </summary>
  [XmlEnum("legacyObliqueBottomRight")]
  LegacyObliqueBottomRight,
  
  /// <summary>
  /// Legacy Perspective Top Left.
  /// </summary>
  [XmlEnum("legacyPerspectiveTopLeft")]
  LegacyPerspectiveTopLeft,
  
  /// <summary>
  /// Legacy Perspective Top.
  /// </summary>
  [XmlEnum("legacyPerspectiveTop")]
  LegacyPerspectiveTop,
  
  /// <summary>
  /// Legacy Perspective Top Right.
  /// </summary>
  [XmlEnum("legacyPerspectiveTopRight")]
  LegacyPerspectiveTopRight,
  
  /// <summary>
  /// Legacy Perspective Left.
  /// </summary>
  [XmlEnum("legacyPerspectiveLeft")]
  LegacyPerspectiveLeft,
  
  /// <summary>
  /// Legacy Perspective Front.
  /// </summary>
  [XmlEnum("legacyPerspectiveFront")]
  LegacyPerspectiveFront,
  
  /// <summary>
  /// Legacy Perspective Right.
  /// </summary>
  [XmlEnum("legacyPerspectiveRight")]
  LegacyPerspectiveRight,
  
  /// <summary>
  /// Legacy Perspective Bottom Left.
  /// </summary>
  [XmlEnum("legacyPerspectiveBottomLeft")]
  LegacyPerspectiveBottomLeft,
  
  /// <summary>
  /// Legacy Perspective Bottom.
  /// </summary>
  [XmlEnum("legacyPerspectiveBottom")]
  LegacyPerspectiveBottom,
  
  /// <summary>
  /// Legacy Perspective Bottom Right.
  /// </summary>
  [XmlEnum("legacyPerspectiveBottomRight")]
  LegacyPerspectiveBottomRight,
  
  /// <summary>
  /// Orthographic Front.
  /// </summary>
  [XmlEnum("orthographicFront")]
  OrthographicFront,
  
  /// <summary>
  /// Isometric Top Up.
  /// </summary>
  [XmlEnum("isometricTopUp")]
  IsometricTopUp,
  
  /// <summary>
  /// Isometric Top Down.
  /// </summary>
  [XmlEnum("isometricTopDown")]
  IsometricTopDown,
  
  /// <summary>
  /// Isometric Bottom Up.
  /// </summary>
  [XmlEnum("isometricBottomUp")]
  IsometricBottomUp,
  
  /// <summary>
  /// Isometric Bottom Down.
  /// </summary>
  [XmlEnum("isometricBottomDown")]
  IsometricBottomDown,
  
  /// <summary>
  /// Isometric Left Up.
  /// </summary>
  [XmlEnum("isometricLeftUp")]
  IsometricLeftUp,
  
  /// <summary>
  /// Isometric Left Down.
  /// </summary>
  [XmlEnum("isometricLeftDown")]
  IsometricLeftDown,
  
  /// <summary>
  /// Isometric Right Up.
  /// </summary>
  [XmlEnum("isometricRightUp")]
  IsometricRightUp,
  
  /// <summary>
  /// Isometric Right Down.
  /// </summary>
  [XmlEnum("isometricRightDown")]
  IsometricRightDown,
  
  /// <summary>
  /// Isometric Off Axis 1 Left.
  /// </summary>
  [XmlEnum("isometricOffAxis1Left")]
  IsometricOffAxis1Left,
  
  /// <summary>
  /// Isometric Off Axis 1 Right.
  /// </summary>
  [XmlEnum("isometricOffAxis1Right")]
  IsometricOffAxis1Right,
  
  /// <summary>
  /// Isometric Off Axis 1 Top.
  /// </summary>
  [XmlEnum("isometricOffAxis1Top")]
  IsometricOffAxis1Top,
  
  /// <summary>
  /// Isometric Off Axis 2 Left.
  /// </summary>
  [XmlEnum("isometricOffAxis2Left")]
  IsometricOffAxis2Left,
  
  /// <summary>
  /// Isometric Off Axis 2 Right.
  /// </summary>
  [XmlEnum("isometricOffAxis2Right")]
  IsometricOffAxis2Right,
  
  /// <summary>
  /// Isometric Off Axis 2 Top.
  /// </summary>
  [XmlEnum("isometricOffAxis2Top")]
  IsometricOffAxis2Top,
  
  /// <summary>
  /// Isometric Off Axis 3 Left.
  /// </summary>
  [XmlEnum("isometricOffAxis3Left")]
  IsometricOffAxis3Left,
  
  /// <summary>
  /// Isometric Off Axis 3 Right.
  /// </summary>
  [XmlEnum("isometricOffAxis3Right")]
  IsometricOffAxis3Right,
  
  /// <summary>
  /// Isometric Off Axis 3 Bottom.
  /// </summary>
  [XmlEnum("isometricOffAxis3Bottom")]
  IsometricOffAxis3Bottom,
  
  /// <summary>
  /// Isometric Off Axis 4 Left.
  /// </summary>
  [XmlEnum("isometricOffAxis4Left")]
  IsometricOffAxis4Left,
  
  /// <summary>
  /// Isometric Off Axis 4 Right.
  /// </summary>
  [XmlEnum("isometricOffAxis4Right")]
  IsometricOffAxis4Right,
  
  /// <summary>
  /// Isometric Off Axis 4 Bottom.
  /// </summary>
  [XmlEnum("isometricOffAxis4Bottom")]
  IsometricOffAxis4Bottom,
  
  /// <summary>
  /// Oblique Top Left.
  /// </summary>
  [XmlEnum("obliqueTopLeft")]
  ObliqueTopLeft,
  
  /// <summary>
  /// Oblique Top.
  /// </summary>
  [XmlEnum("obliqueTop")]
  ObliqueTop,
  
  /// <summary>
  /// Oblique Top Right.
  /// </summary>
  [XmlEnum("obliqueTopRight")]
  ObliqueTopRight,
  
  /// <summary>
  /// Oblique Left.
  /// </summary>
  [XmlEnum("obliqueLeft")]
  ObliqueLeft,
  
  /// <summary>
  /// Oblique Right.
  /// </summary>
  [XmlEnum("obliqueRight")]
  ObliqueRight,
  
  /// <summary>
  /// Oblique Bottom Left.
  /// </summary>
  [XmlEnum("obliqueBottomLeft")]
  ObliqueBottomLeft,
  
  /// <summary>
  /// Oblique Bottom.
  /// </summary>
  [XmlEnum("obliqueBottom")]
  ObliqueBottom,
  
  /// <summary>
  /// Oblique Bottom Right.
  /// </summary>
  [XmlEnum("obliqueBottomRight")]
  ObliqueBottomRight,
  
  /// <summary>
  /// Perspective Front.
  /// </summary>
  [XmlEnum("perspectiveFront")]
  PerspectiveFront,
  
  /// <summary>
  /// Perspective Left.
  /// </summary>
  [XmlEnum("perspectiveLeft")]
  PerspectiveLeft,
  
  /// <summary>
  /// Perspective Right.
  /// </summary>
  [XmlEnum("perspectiveRight")]
  PerspectiveRight,
  
  /// <summary>
  /// Orthographic Above.
  /// </summary>
  [XmlEnum("perspectiveAbove")]
  PerspectiveAbove,
  
  /// <summary>
  /// Perspective Below.
  /// </summary>
  [XmlEnum("perspectiveBelow")]
  PerspectiveBelow,
  
  /// <summary>
  /// Perspective Above Left Facing.
  /// </summary>
  [XmlEnum("perspectiveAboveLeftFacing")]
  PerspectiveAboveLeftFacing,
  
  /// <summary>
  /// Perspective Above Right Facing.
  /// </summary>
  [XmlEnum("perspectiveAboveRightFacing")]
  PerspectiveAboveRightFacing,
  
  /// <summary>
  /// Perspective Contrasting Left Facing.
  /// </summary>
  [XmlEnum("perspectiveContrastingLeftFacing")]
  PerspectiveContrastingLeftFacing,
  
  /// <summary>
  /// Perspective Contrasting Right Facing.
  /// </summary>
  [XmlEnum("perspectiveContrastingRightFacing")]
  PerspectiveContrastingRightFacing,
  
  /// <summary>
  /// Perspective Heroic Left Facing.
  /// </summary>
  [XmlEnum("perspectiveHeroicLeftFacing")]
  PerspectiveHeroicLeftFacing,
  
  /// <summary>
  /// Perspective Heroic Right Facing.
  /// </summary>
  [XmlEnum("perspectiveHeroicRightFacing")]
  PerspectiveHeroicRightFacing,
  
  /// <summary>
  /// Perspective Heroic Extreme Left Facing.
  /// </summary>
  [XmlEnum("perspectiveHeroicExtremeLeftFacing")]
  PerspectiveHeroicExtremeLeftFacing,
  
  /// <summary>
  /// Perspective Heroic Extreme Right Facing.
  /// </summary>
  [XmlEnum("perspectiveHeroicExtremeRightFacing")]
  PerspectiveHeroicExtremeRightFacing,
  
  /// <summary>
  /// Perspective Relaxed.
  /// </summary>
  [XmlEnum("perspectiveRelaxed")]
  PerspectiveRelaxed,
  
  /// <summary>
  /// Perspective Relaxed Moderately.
  /// </summary>
  [XmlEnum("perspectiveRelaxedModerately")]
  PerspectiveRelaxedModerately,
  
}
