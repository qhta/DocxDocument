namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the effects camera type used by the specified object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresetcamera?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoPresetCamera))]
public enum PresetCamera
{
  /// <summary>
  /// Used only for detection.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoPresetCameraMixed))]
  Mixed = -2,
  /// <summary>
  /// Specifies Legacy Oblique Upper Left.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraLegacyObliqueTopLeft))]
  LegacyObliqueTopLeft = 1,
  /// <summary>
  /// Specifies Legacy Oblique Top.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraLegacyObliqueTop))]
  LegacyObliqueTop = 2,
  /// <summary>
  /// Specifies Legacy Oblique Upper Right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraLegacyObliqueTopRight))]
  LegacyObliqueTopRight = 3,
  /// <summary>
  /// Specifies Legacy Oblique Left.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraLegacyObliqueLeft))]
  LegacyObliqueLeft = 4,
  /// <summary>
  /// Specifies Legacy Oblique Front.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraLegacyObliqueFront))]
  LegacyObliqueFront = 5,
  /// <summary>
  /// Specifies Legacy Oblique Right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraLegacyObliqueRight))]
  LegacyObliqueRight = 6,
  /// <summary>
  /// Specifies Legacy Oblique Lower Left.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraLegacyObliqueBottomLeft))]
  LegacyObliqueBottomLeft = 7,
  /// <summary>
  /// Specifies Legacy Oblique Bottom.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraLegacyObliqueBottom))]
  LegacyObliqueBottom = 8,
  /// <summary>
  /// Specifies Legacy Oblique Lower Right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraLegacyObliqueBottomRight))]
  LegacyObliqueBottomRight = 9,
  /// <summary>
  /// Specifies Legacy Perspective Upper Left.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraLegacyPerspectiveTopLeft))]
  LegacyPerspectiveTopLeft = 10,
  /// <summary>
  /// Specifies Legacy Perspective Top.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraLegacyPerspectiveTop))]
  LegacyPerspectiveTop = 11,
  /// <summary>
  /// Specifies Legacy Perspective Upper Right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraLegacyPerspectiveTopRight))]
  LegacyPerspectiveTopRight = 12,
  /// <summary>
  /// Specifies Legacy Perspective Left.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraLegacyPerspectiveLeft))]
  LegacyPerspectiveLeft = 13,
  /// <summary>
  /// Specifies Legacy Perspective Front.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraLegacyPerspectiveFront))]
  LegacyPerspectiveFront = 14,
  /// <summary>
  /// Specifies Legacy Perspective Right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraLegacyPerspectiveRight))]
  LegacyPerspectiveRight = 15,
  /// <summary>
  /// Specifies Legacy Perspective Lower Left.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraLegacyPerspectiveBottomLeft))]
  LegacyPerspectiveBottomLeft = 16,
  /// <summary>
  /// Specifies Legacy Perspective Bottom.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraLegacyPerspectiveBottom))]
  LegacyPerspectiveBottom = 17,
  /// <summary>
  /// Specifies Legacy Perspective Lower Right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraLegacyPerspectiveBottomRight))]
  LegacyPerspectiveBottomRight = 18,
  /// <summary>
  /// Specifies Orthographic Front.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraOrthographicFront))]
  OrthographicFront = 19,
  /// <summary>
  /// Specifies Isometric Top Up.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraIsometricTopUp))]
  IsometricTopUp = 20,
  /// <summary>
  /// Specifies Isometric Top Down.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraIsometricTopDown))]
  IsometricTopDown = 21,
  /// <summary>
  /// Specifies Isometric Bottom Up.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraIsometricBottomUp))]
  IsometricBottomUp = 22,
  /// <summary>
  /// Specifies Isometric Bottom Down.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraIsometricBottomDown))]
  IsometricBottomDown = 23,
  /// <summary>
  /// Specifies Isometric Left Up.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraIsometricLeftUp))]
  IsometricLeftUp = 24,
  /// <summary>
  /// Specifies Isometric Left Down.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraIsometricLeftDown))]
  IsometricLeftDown = 25,
  /// <summary>
  /// Specifies Isometric Right Up.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraIsometricRightUp))]
  IsometricRightUp = 26,
  /// <summary>
  /// Specifies Isometric Right Down.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraIsometricRightDown))]
  IsometricRightDown = 27,
  /// <summary>
  /// Specifies Isometric OffAxis1 Left.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraIsometricOffAxis1Left))]
  IsometricOffAxis1Left = 28,
  /// <summary>
  /// Specifies Isometric OffAxis1 Right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraIsometricOffAxis1Right))]
  IsometricOffAxis1Right = 29,
  /// <summary>
  /// Specifies Isometric OffAxis1 Top.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraIsometricOffAxis1Top))]
  IsometricOffAxis1Top = 30,
  /// <summary>
  /// Specifies Isometric OffAxis2 Left.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraIsometricOffAxis2Left))]
  IsometricOffAxis2Left = 31,
  /// <summary>
  /// Specifies Isometric OffAxis2 Right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraIsometricOffAxis2Right))]
  IsometricOffAxis2Right = 32,
  /// <summary>
  /// Specifies Isometric OffAxis2 Top.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraIsometricOffAxis2Top))]
  IsometricOffAxis2Top = 33,
  /// <summary>
  /// Specifies Isometric OffAxis3 Left.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraIsometricOffAxis3Left))]
  IsometricOffAxis3Left = 34,
  /// <summary>
  /// Specifies Isometric OffAxis3 Right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraIsometricOffAxis3Right))]
  IsometricOffAxis3Right = 35,
  /// <summary>
  /// Specifies Isometric OffAxis3 Bottom.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraIsometricOffAxis3Bottom))]
  IsometricOffAxis3Bottom = 36,
  /// <summary>
  /// Specifies Isometric OffAxis4 Left.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraIsometricOffAxis4Left))]
  IsometricOffAxis4Left = 37,
  /// <summary>
  /// Specifies Isometric OffAxis4 Right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraIsometricOffAxis4Right))]
  IsometricOffAxis4Right = 38,
  /// <summary>
  /// Specifies Isometric OffAxis4 Bottom.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraIsometricOffAxis4Bottom))]
  IsometricOffAxis4Bottom = 39,
  /// <summary>
  /// Specifies Oblique Upper Left.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraObliqueTopLeft))]
  ObliqueTopLeft = 40,
  /// <summary>
  /// Specifies Oblique Top.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraObliqueTop))]
  ObliqueTop = 41,
  /// <summary>
  /// Specifies Oblique Upper Right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraObliqueTopRight))]
  ObliqueTopRight = 42,
  /// <summary>
  /// Specifies Oblique Left.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraObliqueLeft))]
  ObliqueLeft = 43,
  /// <summary>
  /// Specifies Oblique Right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraObliqueRight))]
  ObliqueRight = 44,
  /// <summary>
  /// Specifies Oblique Lower Left.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraObliqueBottomLeft))]
  ObliqueBottomLeft = 45,
  /// <summary>
  /// Specifies Oblique Bottom.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraObliqueBottom))]
  ObliqueBottom = 46,
  /// <summary>
  /// Specifies Oblique Lower Right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraObliqueBottomRight))]
  ObliqueBottomRight = 47,
  /// <summary>
  /// Specifies Perspective Front.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraPerspectiveFront))]
  PerspectiveFront = 48,
  /// <summary>
  /// Specifies Perspective Left.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraPerspectiveLeft))]
  PerspectiveLeft = 49,
  /// <summary>
  /// Specifies Perspective Right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraPerspectiveRight))]
  PerspectiveRight = 50,
  /// <summary>
  /// Specifies Perspective Above.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraPerspectiveAbove))]
  PerspectiveAbove = 51,
  /// <summary>
  /// Specifies Perspective Below.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraPerspectiveBelow))]
  PerspectiveBelow = 52,
  /// <summary>
  /// Specifies Perspective Above Left Facing.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraPerspectiveAboveLeftFacing))]
  PerspectiveAboveLeftFacing = 53,
  /// <summary>
  /// Specifies Perspective Above Right Facing.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraPerspectiveAboveRightFacing))]
  PerspectiveAboveRightFacing = 54,
  /// <summary>
  /// Specifies Perspective Contrasting Left Facing.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraPerspectiveContrastingLeftFacing))]
  PerspectiveContrastingLeftFacing = 55,
  /// <summary>
  /// Specifies Perspective Contrasting Right Facing.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraPerspectiveContrastingRightFacing))]
  PerspectiveContrastingRightFacing = 56,
  /// <summary>
  /// Specifies Perspective Heroic Left Facing.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraPerspectiveHeroicLeftFacing))]
  PerspectiveHeroicLeftFacing = 57,
  /// <summary>
  /// Specifies Perspective Heroic Right Facing.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraPerspectiveHeroicRightFacing))]
  PerspectiveHeroicRightFacing = 58,
  /// <summary>
  /// Specifies Perspective Heroic Extreme Left Facing.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraPerspectiveHeroicExtremeLeftFacing))]
  PerspectiveHeroicExtremeLeftFacing = 59,
  /// <summary>
  /// Specifies Perspective Heroic Extreme Right Facing.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraPerspectiveHeroicExtremeRightFacing))]
  PerspectiveHeroicExtremeRightFacing = 60,
  /// <summary>
  /// Specifies Perspective Relaxed.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraPerspectiveRelaxed))]
  PerspectiveRelaxed = 61,
  /// <summary>
  /// Specifies Perspective Relaxed Moderately.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetCamera.msoCameraPerspectiveRelaxedModerately))]
  PerspectiveRelaxedModerately = 62
}
