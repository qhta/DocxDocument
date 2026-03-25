namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Specifies the preset camera type options for 3D rendering in WordprocessingML drawings.
/// This enumeration provides values for various camera perspectives and projections, supporting advanced 3D visualization and effects for graphical elements within the document.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.PresetCameraValues))]
public enum PresetCamera
{
  /// <summary>
  /// Used only for detection.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// Legacy oblique top left camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyObliqueTopLeft))]
  LegacyObliqueTopLeft = 1,
  /// <summary>
  /// Legacy oblique top camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyObliqueTop))]
  LegacyObliqueTop,
  /// <summary>
  /// Legacy oblique top right camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyObliqueTopRight))]
  LegacyObliqueTopRight,
  /// <summary>
  /// Legacy oblique left camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyObliqueLeft))]
  LegacyObliqueLeft,
  /// <summary>
  /// Legacy oblique front camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyObliqueFront))]
  LegacyObliqueFront,
  /// <summary>
  /// Legacy oblique right camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyObliqueRight))]
  LegacyObliqueRight,
  /// <summary>
  /// Legacy oblique bottom left camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyObliqueBottomLeft))]
  LegacyObliqueBottomLeft,
  /// <summary>
  /// Legacy oblique bottom camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyObliqueBottom))]
  LegacyObliqueBottom,
  /// <summary>
  /// Legacy oblique bottom right camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyObliqueBottomRight))]
  LegacyObliqueBottomRight,
  /// <summary>
  /// Legacy perspective top left camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyPerspectiveTopLeft))]
  LegacyPerspectiveTopLeft,
  /// <summary>
  /// Legacy perspective top camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyPerspectiveTop))]
  LegacyPerspectiveTop,
  /// <summary>
  /// Legacy perspective top right camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyPerspectiveTopRight))]
  LegacyPerspectiveTopRight,
  /// <summary>
  /// Legacy perspective left camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyPerspectiveLeft))]
  LegacyPerspectiveLeft,
  /// <summary>
  /// Legacy perspective front camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyPerspectiveFront))]
  LegacyPerspectiveFront,
  /// <summary>
  /// Legacy perspective right camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyPerspectiveRight))]
  LegacyPerspectiveRight,
  /// <summary>
  /// Legacy perspective bottom left camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyPerspectiveBottomLeft))]
  LegacyPerspectiveBottomLeft,
  /// <summary>
  /// Legacy perspective bottom camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyPerspectiveBottom))]
  LegacyPerspectiveBottom,
  /// <summary>
  /// Legacy perspective bottom right camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.LegacyPerspectiveBottomRight))]
  LegacyPerspectiveBottomRight,
  /// <summary>
  /// Orthographic front camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.OrthographicFront))]
  OrthographicFront,
  /// <summary>
  /// Isometric top up camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricTopUp))]
  IsometricTopUp,
  /// <summary>
  /// Isometric top down camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricTopDown))]
  IsometricTopDown,
  /// <summary>
  /// Isometric bottom up camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricBottomUp))]
  IsometricBottomUp,
  /// <summary>
  /// Isometric bottom down camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricBottomDown))]
  IsometricBottomDown,
  /// <summary>
  /// Isometric left up camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricLeftUp))]
  IsometricLeftUp,
  /// <summary>
  /// Isometric left down camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricLeftDown))]
  IsometricLeftDown,
  /// <summary>
  /// Isometric right up camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricRightUp))]
  IsometricRightUp,
  /// <summary>
  /// Isometric right down camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricRightDown))]
  IsometricRightDown,
  /// <summary>
  /// Isometric off-axis 1 left camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricOffAxis1Left))]
  IsometricOffAxis1Left,
  /// <summary>
  /// Isometric off-axis 1 right camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricOffAxis1Right))]
  IsometricOffAxis1Right,
  /// <summary>
  /// Isometric off-axis 1 top camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricOffAxis1Top))]
  IsometricOffAxis1Top,
  /// <summary>
  /// Isometric off-axis 2 left camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricOffAxis2Left))]
  IsometricOffAxis2Left,
  /// <summary>
  /// Isometric off-axis 2 right camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricOffAxis2Right))]
  IsometricOffAxis2Right,
  /// <summary>
  /// Isometric off-axis 2 top camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricOffAxis2Top))]
  IsometricOffAxis2Top,
  /// <summary>
  /// Isometric off-axis 3 left camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricOffAxis3Left))]
  IsometricOffAxis3Left,
  /// <summary>
  /// Isometric off-axis 3 right camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricOffAxis3Right))]
  IsometricOffAxis3Right,
  /// <summary>
  /// Isometric off-axis 3 bottom camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricOffAxis3Bottom))]
  IsometricOffAxis3Bottom,
  /// <summary>
  /// Isometric off-axis 4 left camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricOffAxis4Left))]
  IsometricOffAxis4Left,
  /// <summary>
  /// Isometric off-axis 4 right camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricOffAxis4Right))]
  IsometricOffAxis4Right,
  /// <summary>
  /// Isometric off-axis 4 bottom camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.IsometricOffAxis4Bottom))]
  IsometricOffAxis4Bottom,
  /// <summary>
  /// Oblique top left camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.ObliqueTopLeft))]
  ObliqueTopLeft,
  /// <summary>
  /// Oblique top camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.ObliqueTop))]
  ObliqueTop,
  /// <summary>
  /// Oblique top right camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.ObliqueTopRight))]
  ObliqueTopRight,
  /// <summary>
  /// Oblique left camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.ObliqueLeft))]
  ObliqueLeft,
  /// <summary>
  /// Oblique right camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.ObliqueRight))]
  ObliqueRight,
  /// <summary>
  /// Oblique bottom left camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.ObliqueBottomLeft))]
  ObliqueBottomLeft,
  /// <summary>
  /// Oblique bottom camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.ObliqueBottom))]
  ObliqueBottom,
  /// <summary>
  /// Oblique bottom right camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.ObliqueBottomRight))]
  ObliqueBottomRight,
  /// <summary>
  /// Perspective front camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveFront))]
  PerspectiveFront,
  /// <summary>
  /// Perspective left camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveLeft))]
  PerspectiveLeft,
  /// <summary>
  /// Perspective right camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveRight))]
  PerspectiveRight,
  /// <summary>
  /// Perspective above camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveAbove))]
  PerspectiveAbove,
  /// <summary>
  /// Perspective below camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveBelow))]
  PerspectiveBelow,
  /// <summary>
  /// Perspective above left facing camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveAboveLeftFacing))]
  PerspectiveAboveLeftFacing,
  /// <summary>
  /// Perspective above right facing camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveAboveRightFacing))]
  PerspectiveAboveRightFacing,
  /// <summary>
  /// Perspective contrasting left facing camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveContrastingLeftFacing))]
  PerspectiveContrastingLeftFacing,
  /// <summary>
  /// Perspective contrasting right facing camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveContrastingRightFacing))]
  PerspectiveContrastingRightFacing,
  /// <summary>
  /// Perspective heroic left facing camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveHeroicLeftFacing))]
  PerspectiveHeroicLeftFacing,
  /// <summary>
  /// Perspective heroic right facing camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveHeroicRightFacing))]
  PerspectiveHeroicRightFacing,
  /// <summary>
  /// Perspective heroic extreme left facing camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveHeroicExtremeLeftFacing))]
  PerspectiveHeroicExtremeLeftFacing,
  /// <summary>
  /// Perspective heroic extreme right facing camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveHeroicExtremeRightFacing))]
  PerspectiveHeroicExtremeRightFacing,
  /// <summary>
  /// Perspective relaxed camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveRelaxed))]
  PerspectiveRelaxed,
  /// <summary>
  /// Perspective relaxed moderately camera.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetCameraValues.PerspectiveRelaxedModerately))]
  PerspectiveRelaxedModerately
}