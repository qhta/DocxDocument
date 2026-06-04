namespace DocumentModel.Drawings;
/// <summary>
///   Preset Camera Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.PresetCameraValues))]
public enum PresetCamera
{
  /// <summary>
  ///   Legacy Oblique Top Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.LegacyObliqueTopLeft))]
  LegacyObliqueTopLeft = 1,

  /// <summary>
  ///   Legacy Oblique Top.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.LegacyObliqueTop))]
  LegacyObliqueTop,
  /// <summary>
  ///   Legacy Oblique Top Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.LegacyObliqueTopRight))]
  LegacyObliqueTopRight,
  /// <summary>
  ///   Legacy Oblique Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.LegacyObliqueLeft))]
  LegacyObliqueLeft,
  /// <summary>
  ///   Legacy Oblique Front.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.LegacyObliqueFront))]
  LegacyObliqueFront,
  /// <summary>
  ///   Legacy Oblique Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.LegacyObliqueRight))]
  LegacyObliqueRight,
  /// <summary>
  ///   Legacy Oblique Bottom Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.LegacyObliqueBottomLeft))]
  LegacyObliqueBottomLeft,
  /// <summary>
  ///   Legacy Oblique Bottom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.LegacyObliqueBottom))]
  LegacyObliqueBottom,
  /// <summary>
  ///   Legacy Oblique Bottom Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.LegacyObliqueBottomRight))]
  LegacyObliqueBottomRight,
  /// <summary>
  ///   Legacy Perspective Top Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.LegacyPerspectiveTopLeft))]
  LegacyPerspectiveTopLeft,
  /// <summary>
  ///   Legacy Perspective Top.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.LegacyPerspectiveTop))]
  LegacyPerspectiveTop,
  /// <summary>
  ///   Legacy Perspective Top Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.LegacyPerspectiveTopRight))]
  LegacyPerspectiveTopRight,
  /// <summary>
  ///   Legacy Perspective Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.LegacyPerspectiveLeft))]
  LegacyPerspectiveLeft,
  /// <summary>
  ///   Legacy Perspective Front.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.LegacyPerspectiveFront))]
  LegacyPerspectiveFront,
  /// <summary>
  ///   Legacy Perspective Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.LegacyPerspectiveRight))]
  LegacyPerspectiveRight,
  /// <summary>
  ///   Legacy Perspective Bottom Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.LegacyPerspectiveBottomLeft))]
  LegacyPerspectiveBottomLeft,
  /// <summary>
  ///   Legacy Perspective Bottom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.LegacyPerspectiveBottom))]
  LegacyPerspectiveBottom,
  /// <summary>
  ///   Legacy Perspective Bottom Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.LegacyPerspectiveBottomRight))]
  LegacyPerspectiveBottomRight,
  /// <summary>
  ///   Orthographic Front.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.OrthographicFront))]
  OrthographicFront,
  /// <summary>
  ///   Isometric Top Up.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.IsometricTopUp))]
  IsometricTopUp,
  /// <summary>
  ///   Isometric Top Down.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.IsometricTopDown))]
  IsometricTopDown,
  /// <summary>
  ///   Isometric Bottom Up.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.IsometricBottomUp))]
  IsometricBottomUp,
  /// <summary>
  ///   Isometric Bottom Down.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.IsometricBottomDown))]
  IsometricBottomDown,
  /// <summary>
  ///   Isometric Left Up.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.IsometricLeftUp))]
  IsometricLeftUp,
  /// <summary>
  ///   Isometric Left Down.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.IsometricLeftDown))]
  IsometricLeftDown,
  /// <summary>
  ///   Isometric Right Up.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.IsometricRightUp))]
  IsometricRightUp,
  /// <summary>
  ///   Isometric Right Down.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.IsometricRightDown))]
  IsometricRightDown,
  /// <summary>
  ///   Isometric Off IAxis 1 Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.IsometricOffAxis1Left))]
  IsometricOffAxis1Left,
  /// <summary>
  ///   Isometric Off IAxis 1 Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.IsometricOffAxis1Right))]
  IsometricOffAxis1Right,
  /// <summary>
  ///   Isometric Off IAxis 1 Top.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.IsometricOffAxis1Top))]
  IsometricOffAxis1Top,
  /// <summary>
  ///   Isometric Off IAxis 2 Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.IsometricOffAxis2Left))]
  IsometricOffAxis2Left,
  /// <summary>
  ///   Isometric Off IAxis 2 Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.IsometricOffAxis2Right))]
  IsometricOffAxis2Right,
  /// <summary>
  ///   Isometric Off IAxis 2 Top.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.IsometricOffAxis2Top))]
  IsometricOffAxis2Top,
  /// <summary>
  ///   Isometric Off IAxis 3 Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.IsometricOffAxis3Left))]
  IsometricOffAxis3Left,
  /// <summary>
  ///   Isometric Off IAxis 3 Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.IsometricOffAxis3Right))]
  IsometricOffAxis3Right,
  /// <summary>
  ///   Isometric Off IAxis 3 Bottom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.IsometricOffAxis3Bottom))]
  IsometricOffAxis3Bottom,
  /// <summary>
  ///   Isometric Off IAxis 4 Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.IsometricOffAxis4Left))]
  IsometricOffAxis4Left,
  /// <summary>
  ///   Isometric Off IAxis 4 Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.IsometricOffAxis4Right))]
  IsometricOffAxis4Right,
  /// <summary>
  ///   Isometric Off IAxis 4 Bottom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.IsometricOffAxis4Bottom))]
  IsometricOffAxis4Bottom,
  /// <summary>
  ///   Oblique Top Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.ObliqueTopLeft))]
  ObliqueTopLeft,
  /// <summary>
  ///   Oblique Top.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.ObliqueTop))]
  ObliqueTop,
  /// <summary>
  ///   Oblique Top Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.ObliqueTopRight))]
  ObliqueTopRight,
  /// <summary>
  ///   Oblique Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.ObliqueLeft))]
  ObliqueLeft,
  /// <summary>
  ///   Oblique Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.ObliqueRight))]
  ObliqueRight,
  /// <summary>
  ///   Oblique Bottom Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.ObliqueBottomLeft))]
  ObliqueBottomLeft,
  /// <summary>
  ///   Oblique Bottom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.ObliqueBottom))]
  ObliqueBottom,
  /// <summary>
  ///   Oblique Bottom Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.ObliqueBottomRight))]
  ObliqueBottomRight,
  /// <summary>
  ///   Perspective Front.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.PerspectiveFront))]
  PerspectiveFront,
  /// <summary>
  ///   Perspective Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.PerspectiveLeft))]
  PerspectiveLeft,
  /// <summary>
  ///   Perspective Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.PerspectiveRight))]
  PerspectiveRight,
  /// <summary>
  ///   Orthographic Above.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.PerspectiveAbove))]
  PerspectiveAbove,
  /// <summary>
  ///   Perspective Below.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.PerspectiveBelow))]
  PerspectiveBelow,
  /// <summary>
  ///   Perspective Above Left Facing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.PerspectiveAboveLeftFacing))]
  PerspectiveAboveLeftFacing,
  /// <summary>
  ///   Perspective Above Right Facing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.PerspectiveAboveRightFacing))]
  PerspectiveAboveRightFacing,
  /// <summary>
  ///   Perspective Contrasting Left Facing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.PerspectiveContrastingLeftFacing))]
  PerspectiveContrastingLeftFacing,
  /// <summary>
  ///   Perspective Contrasting Right Facing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.PerspectiveContrastingRightFacing))]
  PerspectiveContrastingRightFacing,
  /// <summary>
  ///   Perspective Heroic Left Facing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.PerspectiveHeroicLeftFacing))]
  PerspectiveHeroicLeftFacing,
  /// <summary>
  ///   Perspective Heroic Right Facing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.PerspectiveHeroicRightFacing))]
  PerspectiveHeroicRightFacing,
  /// <summary>
  ///   Perspective Heroic Extreme Left Facing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.PerspectiveHeroicExtremeLeftFacing))]
  PerspectiveHeroicExtremeLeftFacing,
  /// <summary>
  ///   Perspective Heroic Extreme Right Facing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.PerspectiveHeroicExtremeRightFacing))]
  PerspectiveHeroicExtremeRightFacing,
  /// <summary>
  ///   Perspective Relaxed.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.PerspectiveRelaxed))]
  PerspectiveRelaxed,
  /// <summary>
  ///   Perspective Relaxed Moderately.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetCameraValues.PerspectiveRelaxedModerately))]
  PerspectiveRelaxedModerately
}
