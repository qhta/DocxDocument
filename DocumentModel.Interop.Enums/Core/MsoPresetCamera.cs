namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the effects camera type used by the specified object.
/// </summary>
public enum MsoPresetCamera
{
  /// <summary>
  /// Indicates the effects camera type used by the specified object.
  /// </summary>
  msoPresetCameraMixed = -2,
  /// <summary>
  /// Specifies Legacy Oblique Upper Left.
  /// </summary>
  msoCameraLegacyObliqueTopLeft = 1,
  /// <summary>
  /// Specifies Legacy Oblique Top.
  /// </summary>
  msoCameraLegacyObliqueTop = 2,
  /// <summary>
  /// Specifies Legacy Oblique Upper Right.
  /// </summary>
  msoCameraLegacyObliqueTopRight = 3,
  /// <summary>
  /// Specifies Legacy Oblique Left.
  /// </summary>
  msoCameraLegacyObliqueLeft = 4,
  /// <summary>
  /// Specifies Legacy Oblique Front.
  /// </summary>
  msoCameraLegacyObliqueFront = 5,
  /// <summary>
  /// Specifies Legacy Oblique Right.
  /// </summary>
  msoCameraLegacyObliqueRight = 6,
  /// <summary>
  /// Specifies Legacy Oblique Lower Left.
  /// </summary>
  msoCameraLegacyObliqueBottomLeft = 7,
  /// <summary>
  /// Specifies Legacy Oblique Bottom. msoCameraLegacyObliqueBottomRight9 Specifies Legacy Oblique Lower Right.
  /// </summary>
  msoCameraLegacyObliqueBottom = 8,
  /// <summary>
  /// Indicates the effects camera type used by the specified object.
  /// </summary>
  msoCameraLegacyObliqueBottomRight = 9,
  /// <summary>
  /// Specifies Legacy Perspective Upper Left.
  /// </summary>
  msoCameraLegacyPerspectiveTopLeft = 10,
  /// <summary>
  /// Specifies Legacy Perspective Top.
  /// </summary>
  msoCameraLegacyPerspectiveTop = 11,
  /// <summary>
  /// Specifies Legacy Perspective Upper Right. public enum class MsoPresetCamera ﾉ Expand table
  /// </summary>
  msoCameraLegacyPerspectiveTopRight = 12,
  /// <summary>
  /// Specifies Legacy Perspective Left.
  /// </summary>
  msoCameraLegacyPerspectiveLeft = 13,
  /// <summary>
  /// Specifies Legacy Perspective Front.
  /// </summary>
  msoCameraLegacyPerspectiveFront = 14,
  /// <summary>
  /// Specifies Legacy Perspective Right.
  /// </summary>
  msoCameraLegacyPerspectiveRight = 15,
  /// <summary>
  /// Specifies Legacy Perspective Lower Left.
  /// </summary>
  msoCameraLegacyPerspectiveBottomLeft = 16,
  /// <summary>
  /// Specifies Legacy Perspective Bottom.
  /// </summary>
  msoCameraLegacyPerspectiveBottom = 17,
  /// <summary>
  /// Specifies Legacy Perspective Lower Right.
  /// </summary>
  msoCameraLegacyPerspectiveBottomRight = 18,
  /// <summary>
  /// Specifies Orthographic Front.
  /// </summary>
  msoCameraOrthographicFront = 19,
  /// <summary>
  /// Specifies Isometric Top Up.
  /// </summary>
  msoCameraIsometricTopUp = 20,
  /// <summary>
  /// Specifies Isometric Top Down.
  /// </summary>
  msoCameraIsometricTopDown = 21,
  /// <summary>
  /// Specifies Isometric Bottom Up.
  /// </summary>
  msoCameraIsometricBottomUp = 22,
  /// <summary>
  /// Specifies Isometric Bottom Down.
  /// </summary>
  msoCameraIsometricBottomDown = 23,
  /// <summary>
  /// Specifies Isometric Left Up.
  /// </summary>
  msoCameraIsometricLeftUp = 24,
  /// <summary>
  /// Specifies Isometric Left Down.
  /// </summary>
  msoCameraIsometricLeftDown = 25,
  /// <summary>
  /// Specifies Isometric Right Up.
  /// </summary>
  msoCameraIsometricRightUp = 26,
  /// <summary>
  /// Specifies Isometric Right Down.
  /// </summary>
  msoCameraIsometricRightDown = 27,
  /// <summary>
  /// Specifies Isometric OffAxis1 Left.
  /// </summary>
  msoCameraIsometricOffAxis1Left = 28,
  /// <summary>
  /// Specifies Isometric OffAxis1 Right.
  /// </summary>
  msoCameraIsometricOffAxis1Right = 29,
  /// <summary>
  /// Specifies Isometric OffAxis1 Top.
  /// </summary>
  msoCameraIsometricOffAxis1Top = 30,
  /// <summary>
  /// Specifies Isometric OffAxis2 Left.
  /// </summary>
  msoCameraIsometricOffAxis2Left = 31,
  /// <summary>
  /// Specifies Isometric OffAxis2 Right.
  /// </summary>
  msoCameraIsometricOffAxis2Right = 32,
  /// <summary>
  /// Specifies Isometric OffAxis2 Top.
  /// </summary>
  msoCameraIsometricOffAxis2Top = 33,
  /// <summary>
  /// Specifies Isometric OffAxis3 Left.
  /// </summary>
  msoCameraIsometricOffAxis3Left = 34,
  /// <summary>
  /// Specifies Isometric OffAxis3 Right.
  /// </summary>
  msoCameraIsometricOffAxis3Right = 35,
  /// <summary>
  /// Specifies Isometric OffAxis3 Bottom.
  /// </summary>
  msoCameraIsometricOffAxis3Bottom = 36,
  /// <summary>
  /// Specifies Isometric OffAxis4 Left.
  /// </summary>
  msoCameraIsometricOffAxis4Left = 37,
  /// <summary>
  /// Specifies Isometric OffAxis4 Right.
  /// </summary>
  msoCameraIsometricOffAxis4Right = 38,
  /// <summary>
  /// Specifies Isometric OffAxis4 Bottom.
  /// </summary>
  msoCameraIsometricOffAxis4Bottom = 39,
  /// <summary>
  /// Specifies Oblique Upper Left.
  /// </summary>
  msoCameraObliqueTopLeft = 40,
  /// <summary>
  /// Specifies Oblique Top.
  /// </summary>
  msoCameraObliqueTop = 41,
  /// <summary>
  /// Specifies Oblique Upper Right.
  /// </summary>
  msoCameraObliqueTopRight = 42,
  /// <summary>
  /// Specifies Oblique Left.
  /// </summary>
  msoCameraObliqueLeft = 43,
  /// <summary>
  /// Specifies Oblique Right.
  /// </summary>
  msoCameraObliqueRight = 44,
  /// <summary>
  /// Specifies Oblique Lower Left.
  /// </summary>
  msoCameraObliqueBottomLeft = 45,
  /// <summary>
  /// Specifies Oblique Bottom.
  /// </summary>
  msoCameraObliqueBottom = 46,
  /// <summary>
  /// Specifies Oblique Lower Right.
  /// </summary>
  msoCameraObliqueBottomRight = 47,
  /// <summary>
  /// Specifies Perspective Front.
  /// </summary>
  msoCameraPerspectiveFront = 48,
  /// <summary>
  /// Specifies Perspective Left.
  /// </summary>
  msoCameraPerspectiveLeft = 49,
  /// <summary>
  /// Specifies Perspective Right.
  /// </summary>
  msoCameraPerspectiveRight = 50,
  /// <summary>
  /// Specifies Perspective Above.
  /// </summary>
  msoCameraPerspectiveAbove = 51,
  /// <summary>
  /// Specifies Perspective Below.
  /// </summary>
  msoCameraPerspectiveBelow = 52,
  /// <summary>
  /// Specifies Perspective Above Left Facing.
  /// </summary>
  msoCameraPerspectiveAboveLeftFacing = 53,
  /// <summary>
  /// Specifies Perspective Above Right Facing.
  /// </summary>
  msoCameraPerspectiveAboveRightFacing = 54,
  /// <summary>
  /// Specifies Perspective Contrasting Left Facing.
  /// </summary>
  msoCameraPerspectiveContrastingLeftFacing = 55,
  /// <summary>
  /// Specifies Perspective Contrasting Right Facing.
  /// </summary>
  msoCameraPerspectiveContrastingRightFacing = 56,
  /// <summary>
  /// Specifies Perspective Heroic Left Facing.
  /// </summary>
  msoCameraPerspectiveHeroicLeftFacing = 57,
  /// <summary>
  /// Specifies Perspective Heroic Right Facing.
  /// </summary>
  msoCameraPerspectiveHeroicRightFacing = 58,
  /// <summary>
  /// Specifies Perspective Heroic Extreme Left Facing.
  /// </summary>
  msoCameraPerspectiveHeroicExtremeLeftFacing = 59,
  /// <summary>
  /// Specifies Perspective Heroic Extreme Right Facing.
  /// </summary>
  msoCameraPerspectiveHeroicExtremeRightFacing = 60,
  /// <summary>
  /// Specifies Perspective Relaxed.
  /// </summary>
  msoCameraPerspectiveRelaxed = 61,
  /// <summary>
  /// Specifies Perspective Relaxed Moderately.
  /// </summary>
  msoCameraPerspectiveRelaxedModerately = 62
}
