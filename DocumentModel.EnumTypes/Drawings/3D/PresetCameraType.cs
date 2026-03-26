namespace DocumentModel.Drawings;
/// <summary>
///   Preset Camera Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.PresetCameraValues))]
public enum PresetCameraType
{
  /// <summary>
  ///   Used only for detection.
  /// </summary>
  /// <summary>
  ///   Legacy Oblique Top Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyObliqueTopLeft))]
  LegacyObliqueTopLeft = 1,

  /// <summary>
  ///   Legacy Oblique Top.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyObliqueTop))]
  LegacyObliqueTop,
  /// <summary>
  ///   Legacy Oblique Top Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyObliqueTopRight))]
  LegacyObliqueTopRight,
  /// <summary>
  ///   Legacy Oblique Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyObliqueLeft))]
  LegacyObliqueLeft,
  /// <summary>
  ///   Legacy Oblique Front.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyObliqueFront))]
  LegacyObliqueFront,
  /// <summary>
  ///   Legacy Oblique Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyObliqueRight))]
  LegacyObliqueRight,
  /// <summary>
  ///   Legacy Oblique Bottom Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyObliqueBottomLeft))]
  LegacyObliqueBottomLeft,
  /// <summary>
  ///   Legacy Oblique Bottom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyObliqueBottom))]
  LegacyObliqueBottom,
  /// <summary>
  ///   Legacy Oblique Bottom Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyObliqueBottomRight))]
  LegacyObliqueBottomRight,
  /// <summary>
  ///   Legacy Perspective Top Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyPerspectiveTopLeft))]
  LegacyPerspectiveTopLeft,
  /// <summary>
  ///   Legacy Perspective Top.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyPerspectiveTop))]
  LegacyPerspectiveTop,
  /// <summary>
  ///   Legacy Perspective Top Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyPerspectiveTopRight))]
  LegacyPerspectiveTopRight,
  /// <summary>
  ///   Legacy Perspective Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyPerspectiveLeft))]
  LegacyPerspectiveLeft,
  /// <summary>
  ///   Legacy Perspective Front.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyPerspectiveFront))]
  LegacyPerspectiveFront,
  /// <summary>
  ///   Legacy Perspective Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyPerspectiveRight))]
  LegacyPerspectiveRight,
  /// <summary>
  ///   Legacy Perspective Bottom Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyPerspectiveBottomLeft))]
  LegacyPerspectiveBottomLeft,
  /// <summary>
  ///   Legacy Perspective Bottom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyPerspectiveBottom))]
  LegacyPerspectiveBottom,
  /// <summary>
  ///   Legacy Perspective Bottom Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyPerspectiveBottomRight))]
  LegacyPerspectiveBottomRight,
  /// <summary>
  ///   Orthographic Front.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.OrthographicFront))]
  OrthographicFront,
  /// <summary>
  ///   Isometric Top Up.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricTopUp))]
  IsometricTopUp,
  /// <summary>
  ///   Isometric Top Down.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricTopDown))]
  IsometricTopDown,
  /// <summary>
  ///   Isometric Bottom Up.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricBottomUp))]
  IsometricBottomUp,
  /// <summary>
  ///   Isometric Bottom Down.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricBottomDown))]
  IsometricBottomDown,
  /// <summary>
  ///   Isometric Left Up.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricLeftUp))]
  IsometricLeftUp,
  /// <summary>
  ///   Isometric Left Down.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricLeftDown))]
  IsometricLeftDown,
  /// <summary>
  ///   Isometric Right Up.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricRightUp))]
  IsometricRightUp,
  /// <summary>
  ///   Isometric Right Down.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricRightDown))]
  IsometricRightDown,
  /// <summary>
  ///   Isometric Off Axis 1 Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricOffAxis1Left))]
  IsometricOffAxis1Left,
  /// <summary>
  ///   Isometric Off Axis 1 Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricOffAxis1Right))]
  IsometricOffAxis1Right,
  /// <summary>
  ///   Isometric Off Axis 1 Top.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricOffAxis1Top))]
  IsometricOffAxis1Top,
  /// <summary>
  ///   Isometric Off Axis 2 Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricOffAxis2Left))]
  IsometricOffAxis2Left,
  /// <summary>
  ///   Isometric Off Axis 2 Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricOffAxis2Right))]
  IsometricOffAxis2Right,
  /// <summary>
  ///   Isometric Off Axis 2 Top.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricOffAxis2Top))]
  IsometricOffAxis2Top,
  /// <summary>
  ///   Isometric Off Axis 3 Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricOffAxis3Left))]
  IsometricOffAxis3Left,
  /// <summary>
  ///   Isometric Off Axis 3 Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricOffAxis3Right))]
  IsometricOffAxis3Right,
  /// <summary>
  ///   Isometric Off Axis 3 Bottom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricOffAxis3Bottom))]
  IsometricOffAxis3Bottom,
  /// <summary>
  ///   Isometric Off Axis 4 Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricOffAxis4Left))]
  IsometricOffAxis4Left,
  /// <summary>
  ///   Isometric Off Axis 4 Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricOffAxis4Right))]
  IsometricOffAxis4Right,
  /// <summary>
  ///   Isometric Off Axis 4 Bottom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricOffAxis4Bottom))]
  IsometricOffAxis4Bottom,
  /// <summary>
  ///   Oblique Top Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.ObliqueTopLeft))]
  ObliqueTopLeft,
  /// <summary>
  ///   Oblique Top.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.ObliqueTop))]
  ObliqueTop,
  /// <summary>
  ///   Oblique Top Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.ObliqueTopRight))]
  ObliqueTopRight,
  /// <summary>
  ///   Oblique Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.ObliqueLeft))]
  ObliqueLeft,
  /// <summary>
  ///   Oblique Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.ObliqueRight))]
  ObliqueRight,
  /// <summary>
  ///   Oblique Bottom Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.ObliqueBottomLeft))]
  ObliqueBottomLeft,
  /// <summary>
  ///   Oblique Bottom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.ObliqueBottom))]
  ObliqueBottom,
  /// <summary>
  ///   Oblique Bottom Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.ObliqueBottomRight))]
  ObliqueBottomRight,
  /// <summary>
  ///   Perspective Front.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveFront))]
  PerspectiveFront,
  /// <summary>
  ///   Perspective Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveLeft))]
  PerspectiveLeft,
  /// <summary>
  ///   Perspective Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveRight))]
  PerspectiveRight,
  /// <summary>
  ///   Orthographic Above.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveAbove))]
  PerspectiveAbove,
  /// <summary>
  ///   Perspective Below.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveBelow))]
  PerspectiveBelow,
  /// <summary>
  ///   Perspective Above Left Facing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveAboveLeftFacing))]
  PerspectiveAboveLeftFacing,
  /// <summary>
  ///   Perspective Above Right Facing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveAboveRightFacing))]
  PerspectiveAboveRightFacing,
  /// <summary>
  ///   Perspective Contrasting Left Facing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveContrastingLeftFacing))]
  PerspectiveContrastingLeftFacing,
  /// <summary>
  ///   Perspective Contrasting Right Facing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveContrastingRightFacing))]
  PerspectiveContrastingRightFacing,
  /// <summary>
  ///   Perspective Heroic Left Facing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveHeroicLeftFacing))]
  PerspectiveHeroicLeftFacing,
  /// <summary>
  ///   Perspective Heroic Right Facing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveHeroicRightFacing))]
  PerspectiveHeroicRightFacing,
  /// <summary>
  ///   Perspective Heroic Extreme Left Facing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveHeroicExtremeLeftFacing))]
  PerspectiveHeroicExtremeLeftFacing,
  /// <summary>
  ///   Perspective Heroic Extreme Right Facing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveHeroicExtremeRightFacing))]
  PerspectiveHeroicExtremeRightFacing,
  /// <summary>
  ///   Perspective Relaxed.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveRelaxed))]
  PerspectiveRelaxed,
  /// <summary>
  ///   Perspective Relaxed Moderately.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveRelaxedModerately))]
  PerspectiveRelaxedModerately
}