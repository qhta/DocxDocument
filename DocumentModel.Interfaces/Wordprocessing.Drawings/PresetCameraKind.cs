namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Specifies the preset camera type options for 3D rendering in WordprocessingML drawings.
/// This enumeration provides values for various camera perspectives and projections, supporting advanced 3D visualization and effects for graphical elements within the document.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PresetCameraKind
{
  /// <summary>
  /// Legacy oblique top left camera.
  /// </summary>
  LegacyObliqueTopLeft,
  /// <summary>
  /// Legacy oblique top camera.
  /// </summary>
  LegacyObliqueTop,
  /// <summary>
  /// Legacy oblique top right camera.
  /// </summary>
  LegacyObliqueTopRight,
  /// <summary>
  /// Legacy oblique left camera.
  /// </summary>
  LegacyObliqueLeft,
  /// <summary>
  /// Legacy oblique front camera.
  /// </summary>
  LegacyObliqueFront,
  /// <summary>
  /// Legacy oblique right camera.
  /// </summary>
  LegacyObliqueRight,
  /// <summary>
  /// Legacy oblique bottom left camera.
  /// </summary>
  LegacyObliqueBottomLeft,
  /// <summary>
  /// Legacy oblique bottom camera.
  /// </summary>
  LegacyObliqueBottom,
  /// <summary>
  /// Legacy oblique bottom right camera.
  /// </summary>
  LegacyObliqueBottomRight,
  /// <summary>
  /// Legacy perspective top left camera.
  /// </summary>
  LegacyPerspectiveTopLeft,
  /// <summary>
  /// Legacy perspective top camera.
  /// </summary>
  LegacyPerspectiveTop,
  /// <summary>
  /// Legacy perspective top right camera.
  /// </summary>
  LegacyPerspectiveTopRight,
  /// <summary>
  /// Legacy perspective left camera.
  /// </summary>
  LegacyPerspectiveLeft,
  /// <summary>
  /// Legacy perspective front camera.
  /// </summary>
  LegacyPerspectiveFront,
  /// <summary>
  /// Legacy perspective right camera.
  /// </summary>
  LegacyPerspectiveRight,
  /// <summary>
  /// Legacy perspective bottom left camera.
  /// </summary>
  LegacyPerspectiveBottomLeft,
  /// <summary>
  /// Legacy perspective bottom camera.
  /// </summary>
  LegacyPerspectiveBottom,
  /// <summary>
  /// Legacy perspective bottom right camera.
  /// </summary>
  LegacyPerspectiveBottomRight,
  /// <summary>
  /// Orthographic front camera.
  /// </summary>
  OrthographicFront,
  /// <summary>
  /// Isometric top up camera.
  /// </summary>
  IsometricTopUp,
  /// <summary>
  /// Isometric top down camera.
  /// </summary>
  IsometricTopDown,
  /// <summary>
  /// Isometric bottom up camera.
  /// </summary>
  IsometricBottomUp,
  /// <summary>
  /// Isometric bottom down camera.
  /// </summary>
  IsometricBottomDown,
  /// <summary>
  /// Isometric left up camera.
  /// </summary>
  IsometricLeftUp,
  /// <summary>
  /// Isometric left down camera.
  /// </summary>
  IsometricLeftDown,
  /// <summary>
  /// Isometric right up camera.
  /// </summary>
  IsometricRightUp,
  /// <summary>
  /// Isometric right down camera.
  /// </summary>
  IsometricRightDown,
  /// <summary>
  /// Isometric off-axis 1 left camera.
  /// </summary>
  IsometricOffAxis1Left,
  /// <summary>
  /// Isometric off-axis 1 right camera.
  /// </summary>
  IsometricOffAxis1Right,
  /// <summary>
  /// Isometric off-axis 1 top camera.
  /// </summary>
  IsometricOffAxis1Top,
  /// <summary>
  /// Isometric off-axis 2 left camera.
  /// </summary>
  IsometricOffAxis2Left,
  /// <summary>
  /// Isometric off-axis 2 right camera.
  /// </summary>
  IsometricOffAxis2Right,
  /// <summary>
  /// Isometric off-axis 2 top camera.
  /// </summary>
  IsometricOffAxis2Top,
  /// <summary>
  /// Isometric off-axis 3 left camera.
  /// </summary>
  IsometricOffAxis3Left,
  /// <summary>
  /// Isometric off-axis 3 right camera.
  /// </summary>
  IsometricOffAxis3Right,
  /// <summary>
  /// Isometric off-axis 3 bottom camera.
  /// </summary>
  IsometricOffAxis3Bottom,
  /// <summary>
  /// Isometric off-axis 4 left camera.
  /// </summary>
  IsometricOffAxis4Left,
  /// <summary>
  /// Isometric off-axis 4 right camera.
  /// </summary>
  IsometricOffAxis4Right,
  /// <summary>
  /// Isometric off-axis 4 bottom camera.
  /// </summary>
  IsometricOffAxis4Bottom,
  /// <summary>
  /// Oblique top left camera.
  /// </summary>
  ObliqueTopLeft,
  /// <summary>
  /// Oblique top camera.
  /// </summary>
  ObliqueTop,
  /// <summary>
  /// Oblique top right camera.
  /// </summary>
  ObliqueTopRight,
  /// <summary>
  /// Oblique left camera.
  /// </summary>
  ObliqueLeft,
  /// <summary>
  /// Oblique right camera.
  /// </summary>
  ObliqueRight,
  /// <summary>
  /// Oblique bottom left camera.
  /// </summary>
  ObliqueBottomLeft,
  /// <summary>
  /// Oblique bottom camera.
  /// </summary>
  ObliqueBottom,
  /// <summary>
  /// Oblique bottom right camera.
  /// </summary>
  ObliqueBottomRight,
  /// <summary>
  /// Perspective front camera.
  /// </summary>
  PerspectiveFront,
  /// <summary>
  /// Perspective left camera.
  /// </summary>
  PerspectiveLeft,
  /// <summary>
  /// Perspective right camera.
  /// </summary>
  PerspectiveRight,
  /// <summary>
  /// Perspective above camera.
  /// </summary>
  PerspectiveAbove,
  /// <summary>
  /// Perspective below camera.
  /// </summary>
  PerspectiveBelow,
  /// <summary>
  /// Perspective above left facing camera.
  /// </summary>
  PerspectiveAboveLeftFacing,
  /// <summary>
  /// Perspective above right facing camera.
  /// </summary>
  PerspectiveAboveRightFacing,
  /// <summary>
  /// Perspective contrasting left facing camera.
  /// </summary>
  PerspectiveContrastingLeftFacing,
  /// <summary>
  /// Perspective contrasting right facing camera.
  /// </summary>
  PerspectiveContrastingRightFacing,
  /// <summary>
  /// Perspective heroic left facing camera.
  /// </summary>
  PerspectiveHeroicLeftFacing,
  /// <summary>
  /// Perspective heroic right facing camera.
  /// </summary>
  PerspectiveHeroicRightFacing,
  /// <summary>
  /// Perspective heroic extreme left facing camera.
  /// </summary>
  PerspectiveHeroicExtremeLeftFacing,
  /// <summary>
  /// Perspective heroic extreme right facing camera.
  /// </summary>
  PerspectiveHeroicExtremeRightFacing,
  /// <summary>
  /// Perspective relaxed camera.
  /// </summary>
  PerspectiveRelaxed,
  /// <summary>
  /// Perspective relaxed moderately camera.
  /// </summary>
  PerspectiveRelaxedModerately
}