namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the effects camera type used by the specified object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresetcamera?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoPresetCamera")]
public enum PresetCamera
{
  /// <summary>
  /// Used only for detection.
  /// </summary>
  [InteropEnumValue("msoPresetCameraMixed")]
  Mixed = -2,
  /// <summary>
  /// Specifies Legacy Oblique Upper Left.
  /// </summary>
  [InteropEnumValue("msoCameraLegacyObliqueTopLeft")]
  LegacyObliqueTopLeft = 1,
  /// <summary>
  /// Specifies Legacy Oblique Top.
  /// </summary>
  [InteropEnumValue("msoCameraLegacyObliqueTop")]
  LegacyObliqueTop = 2,
  /// <summary>
  /// Specifies Legacy Oblique Upper Right.
  /// </summary>
  [InteropEnumValue("msoCameraLegacyObliqueTopRight")]
  LegacyObliqueTopRight = 3,
  /// <summary>
  /// Specifies Legacy Oblique Left.
  /// </summary>
  [InteropEnumValue("msoCameraLegacyObliqueLeft")]
  LegacyObliqueLeft = 4,
  /// <summary>
  /// Specifies Legacy Oblique Front.
  /// </summary>
  [InteropEnumValue("msoCameraLegacyObliqueFront")]
  LegacyObliqueFront = 5,
  /// <summary>
  /// Specifies Legacy Oblique Right.
  /// </summary>
  [InteropEnumValue("msoCameraLegacyObliqueRight")]
  LegacyObliqueRight = 6,
  /// <summary>
  /// Specifies Legacy Oblique Lower Left.
  /// </summary>
  [InteropEnumValue("msoCameraLegacyObliqueBottomLeft")]
  LegacyObliqueBottomLeft = 7,
  /// <summary>
  /// Specifies Legacy Oblique Bottom.
  /// </summary>
  [InteropEnumValue("msoCameraLegacyObliqueBottom")]
  LegacyObliqueBottom = 8,
  /// <summary>
  /// Specifies Legacy Oblique Lower Right.
  /// </summary>
  [InteropEnumValue("msoCameraLegacyObliqueBottomRight")]
  LegacyObliqueBottomRight = 9,
  /// <summary>
  /// Specifies Legacy Perspective Upper Left.
  /// </summary>
  [InteropEnumValue("msoCameraLegacyPerspectiveTopLeft")]
  LegacyPerspectiveTopLeft = 10,
  /// <summary>
  /// Specifies Legacy Perspective Top.
  /// </summary>
  [InteropEnumValue("msoCameraLegacyPerspectiveTop")]
  LegacyPerspectiveTop = 11,
  /// <summary>
  /// Specifies Legacy Perspective Upper Right.
  /// </summary>
  [InteropEnumValue("msoCameraLegacyPerspectiveTopRight")]
  LegacyPerspectiveTopRight = 12,
  /// <summary>
  /// Specifies Legacy Perspective Left.
  /// </summary>
  [InteropEnumValue("msoCameraLegacyPerspectiveLeft")]
  LegacyPerspectiveLeft = 13,
  /// <summary>
  /// Specifies Legacy Perspective Front.
  /// </summary>
  [InteropEnumValue("msoCameraLegacyPerspectiveFront")]
  LegacyPerspectiveFront = 14,
  /// <summary>
  /// Specifies Legacy Perspective Right.
  /// </summary>
  [InteropEnumValue("msoCameraLegacyPerspectiveRight")]
  LegacyPerspectiveRight = 15,
  /// <summary>
  /// Specifies Legacy Perspective Lower Left.
  /// </summary>
  [InteropEnumValue("msoCameraLegacyPerspectiveBottomLeft")]
  LegacyPerspectiveBottomLeft = 16,
  /// <summary>
  /// Specifies Legacy Perspective Bottom.
  /// </summary>
  [InteropEnumValue("msoCameraLegacyPerspectiveBottom")]
  LegacyPerspectiveBottom = 17,
  /// <summary>
  /// Specifies Legacy Perspective Lower Right.
  /// </summary>
  [InteropEnumValue("msoCameraLegacyPerspectiveBottomRight")]
  LegacyPerspectiveBottomRight = 18,
  /// <summary>
  /// Specifies Orthographic Front.
  /// </summary>
  [InteropEnumValue("msoCameraOrthographicFront")]
  OrthographicFront = 19,
  /// <summary>
  /// Specifies Isometric Top Up.
  /// </summary>
  [InteropEnumValue("msoCameraIsometricTopUp")]
  IsometricTopUp = 20,
  /// <summary>
  /// Specifies Isometric Top Down.
  /// </summary>
  [InteropEnumValue("msoCameraIsometricTopDown")]
  IsometricTopDown = 21,
  /// <summary>
  /// Specifies Isometric Bottom Up.
  /// </summary>
  [InteropEnumValue("msoCameraIsometricBottomUp")]
  IsometricBottomUp = 22,
  /// <summary>
  /// Specifies Isometric Bottom Down.
  /// </summary>
  [InteropEnumValue("msoCameraIsometricBottomDown")]
  IsometricBottomDown = 23,
  /// <summary>
  /// Specifies Isometric Left Up.
  /// </summary>
  [InteropEnumValue("msoCameraIsometricLeftUp")]
  IsometricLeftUp = 24,
  /// <summary>
  /// Specifies Isometric Left Down.
  /// </summary>
  [InteropEnumValue("msoCameraIsometricLeftDown")]
  IsometricLeftDown = 25,
  /// <summary>
  /// Specifies Isometric Right Up.
  /// </summary>
  [InteropEnumValue("msoCameraIsometricRightUp")]
  IsometricRightUp = 26,
  /// <summary>
  /// Specifies Isometric Right Down.
  /// </summary>
  [InteropEnumValue("msoCameraIsometricRightDown")]
  IsometricRightDown = 27,
  /// <summary>
  /// Specifies Isometric OffAxis1 Left.
  /// </summary>
  [InteropEnumValue("msoCameraIsometricOffAxis1Left")]
  IsometricOffAxis1Left = 28,
  /// <summary>
  /// Specifies Isometric OffAxis1 Right.
  /// </summary>
  [InteropEnumValue("msoCameraIsometricOffAxis1Right")]
  IsometricOffAxis1Right = 29,
  /// <summary>
  /// Specifies Isometric OffAxis1 Top.
  /// </summary>
  [InteropEnumValue("msoCameraIsometricOffAxis1Top")]
  IsometricOffAxis1Top = 30,
  /// <summary>
  /// Specifies Isometric OffAxis2 Left.
  /// </summary>
  [InteropEnumValue("msoCameraIsometricOffAxis2Left")]
  IsometricOffAxis2Left = 31,
  /// <summary>
  /// Specifies Isometric OffAxis2 Right.
  /// </summary>
  [InteropEnumValue("msoCameraIsometricOffAxis2Right")]
  IsometricOffAxis2Right = 32,
  /// <summary>
  /// Specifies Isometric OffAxis2 Top.
  /// </summary>
  [InteropEnumValue("msoCameraIsometricOffAxis2Top")]
  IsometricOffAxis2Top = 33,
  /// <summary>
  /// Specifies Isometric OffAxis3 Left.
  /// </summary>
  [InteropEnumValue("msoCameraIsometricOffAxis3Left")]
  IsometricOffAxis3Left = 34,
  /// <summary>
  /// Specifies Isometric OffAxis3 Right.
  /// </summary>
  [InteropEnumValue("msoCameraIsometricOffAxis3Right")]
  IsometricOffAxis3Right = 35,
  /// <summary>
  /// Specifies Isometric OffAxis3 Bottom.
  /// </summary>
  [InteropEnumValue("msoCameraIsometricOffAxis3Bottom")]
  IsometricOffAxis3Bottom = 36,
  /// <summary>
  /// Specifies Isometric OffAxis4 Left.
  /// </summary>
  [InteropEnumValue("msoCameraIsometricOffAxis4Left")]
  IsometricOffAxis4Left = 37,
  /// <summary>
  /// Specifies Isometric OffAxis4 Right.
  /// </summary>
  [InteropEnumValue("msoCameraIsometricOffAxis4Right")]
  IsometricOffAxis4Right = 38,
  /// <summary>
  /// Specifies Isometric OffAxis4 Bottom.
  /// </summary>
  [InteropEnumValue("msoCameraIsometricOffAxis4Bottom")]
  IsometricOffAxis4Bottom = 39,
  /// <summary>
  /// Specifies Oblique Upper Left.
  /// </summary>
  [InteropEnumValue("msoCameraObliqueTopLeft")]
  ObliqueTopLeft = 40,
  /// <summary>
  /// Specifies Oblique Top.
  /// </summary>
  [InteropEnumValue("msoCameraObliqueTop")]
  ObliqueTop = 41,
  /// <summary>
  /// Specifies Oblique Upper Right.
  /// </summary>
  [InteropEnumValue("msoCameraObliqueTopRight")]
  ObliqueTopRight = 42,
  /// <summary>
  /// Specifies Oblique Left.
  /// </summary>
  [InteropEnumValue("msoCameraObliqueLeft")]
  ObliqueLeft = 43,
  /// <summary>
  /// Specifies Oblique Right.
  /// </summary>
  [InteropEnumValue("msoCameraObliqueRight")]
  ObliqueRight = 44,
  /// <summary>
  /// Specifies Oblique Lower Left.
  /// </summary>
  [InteropEnumValue("msoCameraObliqueBottomLeft")]
  ObliqueBottomLeft = 45,
  /// <summary>
  /// Specifies Oblique Bottom.
  /// </summary>
  [InteropEnumValue("msoCameraObliqueBottom")]
  ObliqueBottom = 46,
  /// <summary>
  /// Specifies Oblique Lower Right.
  /// </summary>
  [InteropEnumValue("msoCameraObliqueBottomRight")]
  ObliqueBottomRight = 47,
  /// <summary>
  /// Specifies Perspective Front.
  /// </summary>
  [InteropEnumValue("msoCameraPerspectiveFront")]
  PerspectiveFront = 48,
  /// <summary>
  /// Specifies Perspective Left.
  /// </summary>
  [InteropEnumValue("msoCameraPerspectiveLeft")]
  PerspectiveLeft = 49,
  /// <summary>
  /// Specifies Perspective Right.
  /// </summary>
  [InteropEnumValue("msoCameraPerspectiveRight")]
  PerspectiveRight = 50,
  /// <summary>
  /// Specifies Perspective Above.
  /// </summary>
  [InteropEnumValue("msoCameraPerspectiveAbove")]
  PerspectiveAbove = 51,
  /// <summary>
  /// Specifies Perspective Below.
  /// </summary>
  [InteropEnumValue("msoCameraPerspectiveBelow")]
  PerspectiveBelow = 52,
  /// <summary>
  /// Specifies Perspective Above Left Facing.
  /// </summary>
  [InteropEnumValue("msoCameraPerspectiveAboveLeftFacing")]
  PerspectiveAboveLeftFacing = 53,
  /// <summary>
  /// Specifies Perspective Above Right Facing.
  /// </summary>
  [InteropEnumValue("msoCameraPerspectiveAboveRightFacing")]
  PerspectiveAboveRightFacing = 54,
  /// <summary>
  /// Specifies Perspective Contrasting Left Facing.
  /// </summary>
  [InteropEnumValue("msoCameraPerspectiveContrastingLeftFacing")]
  PerspectiveContrastingLeftFacing = 55,
  /// <summary>
  /// Specifies Perspective Contrasting Right Facing.
  /// </summary>
  [InteropEnumValue("msoCameraPerspectiveContrastingRightFacing")]
  PerspectiveContrastingRightFacing = 56,
  /// <summary>
  /// Specifies Perspective Heroic Left Facing.
  /// </summary>
  [InteropEnumValue("msoCameraPerspectiveHeroicLeftFacing")]
  PerspectiveHeroicLeftFacing = 57,
  /// <summary>
  /// Specifies Perspective Heroic Right Facing.
  /// </summary>
  [InteropEnumValue("msoCameraPerspectiveHeroicRightFacing")]
  PerspectiveHeroicRightFacing = 58,
  /// <summary>
  /// Specifies Perspective Heroic Extreme Left Facing.
  /// </summary>
  [InteropEnumValue("msoCameraPerspectiveHeroicExtremeLeftFacing")]
  PerspectiveHeroicExtremeLeftFacing = 59,
  /// <summary>
  /// Specifies Perspective Heroic Extreme Right Facing.
  /// </summary>
  [InteropEnumValue("msoCameraPerspectiveHeroicExtremeRightFacing")]
  PerspectiveHeroicExtremeRightFacing = 60,
  /// <summary>
  /// Specifies Perspective Relaxed.
  /// </summary>
  [InteropEnumValue("msoCameraPerspectiveRelaxed")]
  PerspectiveRelaxed = 61,
  /// <summary>
  /// Specifies Perspective Relaxed Moderately.
  /// </summary>
  [InteropEnumValue("msoCameraPerspectiveRelaxedModerately")]
  PerspectiveRelaxedModerately = 62
}
