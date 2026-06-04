namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the effects camera type used by the specified object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresetcamera?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoPresetCamera")]
public enum PresetCamera
{
  /// <summary>
  /// Used only for detection.
  /// </summary>
  [OfficeInteropEnumValue("msoPresetCameraMixed")]
  Mixed = -2,
  /// <summary>
  /// Specifies Legacy Oblique Upper Left.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraLegacyObliqueTopLeft")]
  LegacyObliqueTopLeft = 1,
  /// <summary>
  /// Specifies Legacy Oblique Top.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraLegacyObliqueTop")]
  LegacyObliqueTop = 2,
  /// <summary>
  /// Specifies Legacy Oblique Upper Right.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraLegacyObliqueTopRight")]
  LegacyObliqueTopRight = 3,
  /// <summary>
  /// Specifies Legacy Oblique Left.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraLegacyObliqueLeft")]
  LegacyObliqueLeft = 4,
  /// <summary>
  /// Specifies Legacy Oblique Front.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraLegacyObliqueFront")]
  LegacyObliqueFront = 5,
  /// <summary>
  /// Specifies Legacy Oblique Right.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraLegacyObliqueRight")]
  LegacyObliqueRight = 6,
  /// <summary>
  /// Specifies Legacy Oblique Lower Left.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraLegacyObliqueBottomLeft")]
  LegacyObliqueBottomLeft = 7,
  /// <summary>
  /// Specifies Legacy Oblique Bottom.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraLegacyObliqueBottom")]
  LegacyObliqueBottom = 8,
  /// <summary>
  /// Specifies Legacy Oblique Lower Right.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraLegacyObliqueBottomRight")]
  LegacyObliqueBottomRight = 9,
  /// <summary>
  /// Specifies Legacy Perspective Upper Left.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraLegacyPerspectiveTopLeft")]
  LegacyPerspectiveTopLeft = 10,
  /// <summary>
  /// Specifies Legacy Perspective Top.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraLegacyPerspectiveTop")]
  LegacyPerspectiveTop = 11,
  /// <summary>
  /// Specifies Legacy Perspective Upper Right.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraLegacyPerspectiveTopRight")]
  LegacyPerspectiveTopRight = 12,
  /// <summary>
  /// Specifies Legacy Perspective Left.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraLegacyPerspectiveLeft")]
  LegacyPerspectiveLeft = 13,
  /// <summary>
  /// Specifies Legacy Perspective Front.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraLegacyPerspectiveFront")]
  LegacyPerspectiveFront = 14,
  /// <summary>
  /// Specifies Legacy Perspective Right.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraLegacyPerspectiveRight")]
  LegacyPerspectiveRight = 15,
  /// <summary>
  /// Specifies Legacy Perspective Lower Left.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraLegacyPerspectiveBottomLeft")]
  LegacyPerspectiveBottomLeft = 16,
  /// <summary>
  /// Specifies Legacy Perspective Bottom.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraLegacyPerspectiveBottom")]
  LegacyPerspectiveBottom = 17,
  /// <summary>
  /// Specifies Legacy Perspective Lower Right.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraLegacyPerspectiveBottomRight")]
  LegacyPerspectiveBottomRight = 18,
  /// <summary>
  /// Specifies Orthographic Front.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraOrthographicFront")]
  OrthographicFront = 19,
  /// <summary>
  /// Specifies Isometric Top Up.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraIsometricTopUp")]
  IsometricTopUp = 20,
  /// <summary>
  /// Specifies Isometric Top Down.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraIsometricTopDown")]
  IsometricTopDown = 21,
  /// <summary>
  /// Specifies Isometric Bottom Up.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraIsometricBottomUp")]
  IsometricBottomUp = 22,
  /// <summary>
  /// Specifies Isometric Bottom Down.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraIsometricBottomDown")]
  IsometricBottomDown = 23,
  /// <summary>
  /// Specifies Isometric Left Up.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraIsometricLeftUp")]
  IsometricLeftUp = 24,
  /// <summary>
  /// Specifies Isometric Left Down.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraIsometricLeftDown")]
  IsometricLeftDown = 25,
  /// <summary>
  /// Specifies Isometric Right Up.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraIsometricRightUp")]
  IsometricRightUp = 26,
  /// <summary>
  /// Specifies Isometric Right Down.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraIsometricRightDown")]
  IsometricRightDown = 27,
  /// <summary>
  /// Specifies Isometric OffAxis1 Left.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraIsometricOffAxis1Left")]
  IsometricOffAxis1Left = 28,
  /// <summary>
  /// Specifies Isometric OffAxis1 Right.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraIsometricOffAxis1Right")]
  IsometricOffAxis1Right = 29,
  /// <summary>
  /// Specifies Isometric OffAxis1 Top.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraIsometricOffAxis1Top")]
  IsometricOffAxis1Top = 30,
  /// <summary>
  /// Specifies Isometric OffAxis2 Left.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraIsometricOffAxis2Left")]
  IsometricOffAxis2Left = 31,
  /// <summary>
  /// Specifies Isometric OffAxis2 Right.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraIsometricOffAxis2Right")]
  IsometricOffAxis2Right = 32,
  /// <summary>
  /// Specifies Isometric OffAxis2 Top.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraIsometricOffAxis2Top")]
  IsometricOffAxis2Top = 33,
  /// <summary>
  /// Specifies Isometric OffAxis3 Left.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraIsometricOffAxis3Left")]
  IsometricOffAxis3Left = 34,
  /// <summary>
  /// Specifies Isometric OffAxis3 Right.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraIsometricOffAxis3Right")]
  IsometricOffAxis3Right = 35,
  /// <summary>
  /// Specifies Isometric OffAxis3 Bottom.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraIsometricOffAxis3Bottom")]
  IsometricOffAxis3Bottom = 36,
  /// <summary>
  /// Specifies Isometric OffAxis4 Left.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraIsometricOffAxis4Left")]
  IsometricOffAxis4Left = 37,
  /// <summary>
  /// Specifies Isometric OffAxis4 Right.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraIsometricOffAxis4Right")]
  IsometricOffAxis4Right = 38,
  /// <summary>
  /// Specifies Isometric OffAxis4 Bottom.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraIsometricOffAxis4Bottom")]
  IsometricOffAxis4Bottom = 39,
  /// <summary>
  /// Specifies Oblique Upper Left.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraObliqueTopLeft")]
  ObliqueTopLeft = 40,
  /// <summary>
  /// Specifies Oblique Top.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraObliqueTop")]
  ObliqueTop = 41,
  /// <summary>
  /// Specifies Oblique Upper Right.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraObliqueTopRight")]
  ObliqueTopRight = 42,
  /// <summary>
  /// Specifies Oblique Left.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraObliqueLeft")]
  ObliqueLeft = 43,
  /// <summary>
  /// Specifies Oblique Right.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraObliqueRight")]
  ObliqueRight = 44,
  /// <summary>
  /// Specifies Oblique Lower Left.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraObliqueBottomLeft")]
  ObliqueBottomLeft = 45,
  /// <summary>
  /// Specifies Oblique Bottom.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraObliqueBottom")]
  ObliqueBottom = 46,
  /// <summary>
  /// Specifies Oblique Lower Right.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraObliqueBottomRight")]
  ObliqueBottomRight = 47,
  /// <summary>
  /// Specifies Perspective Front.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraPerspectiveFront")]
  PerspectiveFront = 48,
  /// <summary>
  /// Specifies Perspective Left.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraPerspectiveLeft")]
  PerspectiveLeft = 49,
  /// <summary>
  /// Specifies Perspective Right.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraPerspectiveRight")]
  PerspectiveRight = 50,
  /// <summary>
  /// Specifies Perspective Above.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraPerspectiveAbove")]
  PerspectiveAbove = 51,
  /// <summary>
  /// Specifies Perspective Below.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraPerspectiveBelow")]
  PerspectiveBelow = 52,
  /// <summary>
  /// Specifies Perspective Above Left Facing.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraPerspectiveAboveLeftFacing")]
  PerspectiveAboveLeftFacing = 53,
  /// <summary>
  /// Specifies Perspective Above Right Facing.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraPerspectiveAboveRightFacing")]
  PerspectiveAboveRightFacing = 54,
  /// <summary>
  /// Specifies Perspective Contrasting Left Facing.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraPerspectiveContrastingLeftFacing")]
  PerspectiveContrastingLeftFacing = 55,
  /// <summary>
  /// Specifies Perspective Contrasting Right Facing.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraPerspectiveContrastingRightFacing")]
  PerspectiveContrastingRightFacing = 56,
  /// <summary>
  /// Specifies Perspective Heroic Left Facing.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraPerspectiveHeroicLeftFacing")]
  PerspectiveHeroicLeftFacing = 57,
  /// <summary>
  /// Specifies Perspective Heroic Right Facing.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraPerspectiveHeroicRightFacing")]
  PerspectiveHeroicRightFacing = 58,
  /// <summary>
  /// Specifies Perspective Heroic Extreme Left Facing.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraPerspectiveHeroicExtremeLeftFacing")]
  PerspectiveHeroicExtremeLeftFacing = 59,
  /// <summary>
  /// Specifies Perspective Heroic Extreme Right Facing.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraPerspectiveHeroicExtremeRightFacing")]
  PerspectiveHeroicExtremeRightFacing = 60,
  /// <summary>
  /// Specifies Perspective Relaxed.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraPerspectiveRelaxed")]
  PerspectiveRelaxed = 61,
  /// <summary>
  /// Specifies Perspective Relaxed Moderately.
  /// </summary>
  [OfficeInteropEnumValue("msoCameraPerspectiveRelaxedModerately")]
  PerspectiveRelaxedModerately = 62
}
