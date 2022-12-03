namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PresetCameraTypeValues enumeration.
/// </summary>
public enum PresetCameraKind
{
  /// <summary>
  /// legacyObliqueTopLeft.
  /// </summary>
  [XmlEnum("legacyObliqueTopLeft")]
  LegacyObliqueTopLeft,
  
  /// <summary>
  /// legacyObliqueTop.
  /// </summary>
  [XmlEnum("legacyObliqueTop")]
  LegacyObliqueTop,
  
  /// <summary>
  /// legacyObliqueTopRight.
  /// </summary>
  [XmlEnum("legacyObliqueTopRight")]
  LegacyObliqueTopRight,
  
  /// <summary>
  /// legacyObliqueLeft.
  /// </summary>
  [XmlEnum("legacyObliqueLeft")]
  LegacyObliqueLeft,
  
  /// <summary>
  /// legacyObliqueFront.
  /// </summary>
  [XmlEnum("legacyObliqueFront")]
  LegacyObliqueFront,
  
  /// <summary>
  /// legacyObliqueRight.
  /// </summary>
  [XmlEnum("legacyObliqueRight")]
  LegacyObliqueRight,
  
  /// <summary>
  /// legacyObliqueBottomLeft.
  /// </summary>
  [XmlEnum("legacyObliqueBottomLeft")]
  LegacyObliqueBottomLeft,
  
  /// <summary>
  /// legacyObliqueBottom.
  /// </summary>
  [XmlEnum("legacyObliqueBottom")]
  LegacyObliqueBottom,
  
  /// <summary>
  /// legacyObliqueBottomRight.
  /// </summary>
  [XmlEnum("legacyObliqueBottomRight")]
  LegacyObliqueBottomRight,
  
  /// <summary>
  /// legacyPerspectiveTopLeft.
  /// </summary>
  [XmlEnum("legacyPerspectiveTopLeft")]
  LegacyPerspectiveTopLeft,
  
  /// <summary>
  /// legacyPerspectiveTop.
  /// </summary>
  [XmlEnum("legacyPerspectiveTop")]
  LegacyPerspectiveTop,
  
  /// <summary>
  /// legacyPerspectiveTopRight.
  /// </summary>
  [XmlEnum("legacyPerspectiveTopRight")]
  LegacyPerspectiveTopRight,
  
  /// <summary>
  /// legacyPerspectiveLeft.
  /// </summary>
  [XmlEnum("legacyPerspectiveLeft")]
  LegacyPerspectiveLeft,
  
  /// <summary>
  /// legacyPerspectiveFront.
  /// </summary>
  [XmlEnum("legacyPerspectiveFront")]
  LegacyPerspectiveFront,
  
  /// <summary>
  /// legacyPerspectiveRight.
  /// </summary>
  [XmlEnum("legacyPerspectiveRight")]
  LegacyPerspectiveRight,
  
  /// <summary>
  /// legacyPerspectiveBottomLeft.
  /// </summary>
  [XmlEnum("legacyPerspectiveBottomLeft")]
  LegacyPerspectiveBottomLeft,
  
  /// <summary>
  /// legacyPerspectiveBottom.
  /// </summary>
  [XmlEnum("legacyPerspectiveBottom")]
  LegacyPerspectiveBottom,
  
  /// <summary>
  /// legacyPerspectiveBottomRight.
  /// </summary>
  [XmlEnum("legacyPerspectiveBottomRight")]
  LegacyPerspectiveBottomRight,
  
  /// <summary>
  /// orthographicFront.
  /// </summary>
  [XmlEnum("orthographicFront")]
  OrthographicFront,
  
  /// <summary>
  /// isometricTopUp.
  /// </summary>
  [XmlEnum("isometricTopUp")]
  IsometricTopUp,
  
  /// <summary>
  /// isometricTopDown.
  /// </summary>
  [XmlEnum("isometricTopDown")]
  IsometricTopDown,
  
  /// <summary>
  /// isometricBottomUp.
  /// </summary>
  [XmlEnum("isometricBottomUp")]
  IsometricBottomUp,
  
  /// <summary>
  /// isometricBottomDown.
  /// </summary>
  [XmlEnum("isometricBottomDown")]
  IsometricBottomDown,
  
  /// <summary>
  /// isometricLeftUp.
  /// </summary>
  [XmlEnum("isometricLeftUp")]
  IsometricLeftUp,
  
  /// <summary>
  /// isometricLeftDown.
  /// </summary>
  [XmlEnum("isometricLeftDown")]
  IsometricLeftDown,
  
  /// <summary>
  /// isometricRightUp.
  /// </summary>
  [XmlEnum("isometricRightUp")]
  IsometricRightUp,
  
  /// <summary>
  /// isometricRightDown.
  /// </summary>
  [XmlEnum("isometricRightDown")]
  IsometricRightDown,
  
  /// <summary>
  /// isometricOffAxis1Left.
  /// </summary>
  [XmlEnum("isometricOffAxis1Left")]
  IsometricOffAxis1Left,
  
  /// <summary>
  /// isometricOffAxis1Right.
  /// </summary>
  [XmlEnum("isometricOffAxis1Right")]
  IsometricOffAxis1Right,
  
  /// <summary>
  /// isometricOffAxis1Top.
  /// </summary>
  [XmlEnum("isometricOffAxis1Top")]
  IsometricOffAxis1Top,
  
  /// <summary>
  /// isometricOffAxis2Left.
  /// </summary>
  [XmlEnum("isometricOffAxis2Left")]
  IsometricOffAxis2Left,
  
  /// <summary>
  /// isometricOffAxis2Right.
  /// </summary>
  [XmlEnum("isometricOffAxis2Right")]
  IsometricOffAxis2Right,
  
  /// <summary>
  /// isometricOffAxis2Top.
  /// </summary>
  [XmlEnum("isometricOffAxis2Top")]
  IsometricOffAxis2Top,
  
  /// <summary>
  /// isometricOffAxis3Left.
  /// </summary>
  [XmlEnum("isometricOffAxis3Left")]
  IsometricOffAxis3Left,
  
  /// <summary>
  /// isometricOffAxis3Right.
  /// </summary>
  [XmlEnum("isometricOffAxis3Right")]
  IsometricOffAxis3Right,
  
  /// <summary>
  /// isometricOffAxis3Bottom.
  /// </summary>
  [XmlEnum("isometricOffAxis3Bottom")]
  IsometricOffAxis3Bottom,
  
  /// <summary>
  /// isometricOffAxis4Left.
  /// </summary>
  [XmlEnum("isometricOffAxis4Left")]
  IsometricOffAxis4Left,
  
  /// <summary>
  /// isometricOffAxis4Right.
  /// </summary>
  [XmlEnum("isometricOffAxis4Right")]
  IsometricOffAxis4Right,
  
  /// <summary>
  /// isometricOffAxis4Bottom.
  /// </summary>
  [XmlEnum("isometricOffAxis4Bottom")]
  IsometricOffAxis4Bottom,
  
  /// <summary>
  /// obliqueTopLeft.
  /// </summary>
  [XmlEnum("obliqueTopLeft")]
  ObliqueTopLeft,
  
  /// <summary>
  /// obliqueTop.
  /// </summary>
  [XmlEnum("obliqueTop")]
  ObliqueTop,
  
  /// <summary>
  /// obliqueTopRight.
  /// </summary>
  [XmlEnum("obliqueTopRight")]
  ObliqueTopRight,
  
  /// <summary>
  /// obliqueLeft.
  /// </summary>
  [XmlEnum("obliqueLeft")]
  ObliqueLeft,
  
  /// <summary>
  /// obliqueRight.
  /// </summary>
  [XmlEnum("obliqueRight")]
  ObliqueRight,
  
  /// <summary>
  /// obliqueBottomLeft.
  /// </summary>
  [XmlEnum("obliqueBottomLeft")]
  ObliqueBottomLeft,
  
  /// <summary>
  /// obliqueBottom.
  /// </summary>
  [XmlEnum("obliqueBottom")]
  ObliqueBottom,
  
  /// <summary>
  /// obliqueBottomRight.
  /// </summary>
  [XmlEnum("obliqueBottomRight")]
  ObliqueBottomRight,
  
  /// <summary>
  /// perspectiveFront.
  /// </summary>
  [XmlEnum("perspectiveFront")]
  PerspectiveFront,
  
  /// <summary>
  /// perspectiveLeft.
  /// </summary>
  [XmlEnum("perspectiveLeft")]
  PerspectiveLeft,
  
  /// <summary>
  /// perspectiveRight.
  /// </summary>
  [XmlEnum("perspectiveRight")]
  PerspectiveRight,
  
  /// <summary>
  /// perspectiveAbove.
  /// </summary>
  [XmlEnum("perspectiveAbove")]
  PerspectiveAbove,
  
  /// <summary>
  /// perspectiveBelow.
  /// </summary>
  [XmlEnum("perspectiveBelow")]
  PerspectiveBelow,
  
  /// <summary>
  /// perspectiveAboveLeftFacing.
  /// </summary>
  [XmlEnum("perspectiveAboveLeftFacing")]
  PerspectiveAboveLeftFacing,
  
  /// <summary>
  /// perspectiveAboveRightFacing.
  /// </summary>
  [XmlEnum("perspectiveAboveRightFacing")]
  PerspectiveAboveRightFacing,
  
  /// <summary>
  /// perspectiveContrastingLeftFacing.
  /// </summary>
  [XmlEnum("perspectiveContrastingLeftFacing")]
  PerspectiveContrastingLeftFacing,
  
  /// <summary>
  /// perspectiveContrastingRightFacing.
  /// </summary>
  [XmlEnum("perspectiveContrastingRightFacing")]
  PerspectiveContrastingRightFacing,
  
  /// <summary>
  /// perspectiveHeroicLeftFacing.
  /// </summary>
  [XmlEnum("perspectiveHeroicLeftFacing")]
  PerspectiveHeroicLeftFacing,
  
  /// <summary>
  /// perspectiveHeroicRightFacing.
  /// </summary>
  [XmlEnum("perspectiveHeroicRightFacing")]
  PerspectiveHeroicRightFacing,
  
  /// <summary>
  /// perspectiveHeroicExtremeLeftFacing.
  /// </summary>
  [XmlEnum("perspectiveHeroicExtremeLeftFacing")]
  PerspectiveHeroicExtremeLeftFacing,
  
  /// <summary>
  /// perspectiveHeroicExtremeRightFacing.
  /// </summary>
  [XmlEnum("perspectiveHeroicExtremeRightFacing")]
  PerspectiveHeroicExtremeRightFacing,
  
  /// <summary>
  /// perspectiveRelaxed.
  /// </summary>
  [XmlEnum("perspectiveRelaxed")]
  PerspectiveRelaxed,
  
  /// <summary>
  /// perspectiveRelaxedModerately.
  /// </summary>
  [XmlEnum("perspectiveRelaxedModerately")]
  PerspectiveRelaxedModerately,
  
}
