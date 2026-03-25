namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the effects camera type used by the specified object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresetcamera?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoPresetCamera
{
  /// <summary>
  /// Used only for detection.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// Specifies Legacy Oblique Upper Left.
  /// </summary>
  LegacyObliqueTopLeft = 1,
  /// <summary>
  /// Specifies Legacy Oblique Top.
  /// </summary>
  LegacyObliqueTop = 2,
  /// <summary>
  /// Specifies Legacy Oblique Upper Right.
  /// </summary>
  LegacyObliqueTopRight = 3,
  /// <summary>
  /// Specifies Legacy Oblique Left.
  /// </summary>
  LegacyObliqueLeft = 4,
  /// <summary>
  /// Specifies Legacy Oblique Front.
  /// </summary>
  LegacyObliqueFront = 5,
  /// <summary>
  /// Specifies Legacy Oblique Right.
  /// </summary>
  LegacyObliqueRight = 6,
  /// <summary>
  /// Specifies Legacy Oblique Lower Left.
  /// </summary>
  LegacyObliqueBottomLeft = 7,
  /// <summary>
  /// Specifies Legacy Oblique Bottom.
  /// </summary>
  LegacyObliqueBottom = 8,
  /// <summary>
  /// Specifies Legacy Oblique Lower Right.
  /// </summary>
  LegacyObliqueBottomRight = 9,
  /// <summary>
  /// Specifies Legacy Perspective Upper Left.
  /// </summary>
  LegacyPerspectiveTopLeft = 10,
  /// <summary>
  /// Specifies Legacy Perspective Top.
  /// </summary>
  LegacyPerspectiveTop = 11,
  /// <summary>
  /// Specifies Legacy Perspective Upper Right.
  /// </summary>
  LegacyPerspectiveTopRight = 12,
  /// <summary>
  /// Specifies Legacy Perspective Left.
  /// </summary>
  LegacyPerspectiveLeft = 13,
  /// <summary>
  /// Specifies Legacy Perspective Front.
  /// </summary>
  LegacyPerspectiveFront = 14,
  /// <summary>
  /// Specifies Legacy Perspective Right.
  /// </summary>
  LegacyPerspectiveRight = 15,
  /// <summary>
  /// Specifies Legacy Perspective Lower Left.
  /// </summary>
  LegacyPerspectiveBottomLeft = 16,
  /// <summary>
  /// Specifies Legacy Perspective Bottom.
  /// </summary>
  LegacyPerspectiveBottom = 17,
  /// <summary>
  /// Specifies Legacy Perspective Lower Right.
  /// </summary>
  LegacyPerspectiveBottomRight = 18,
  /// <summary>
  /// Specifies Orthographic Front.
  /// </summary>
  OrthographicFront = 19,
  /// <summary>
  /// Specifies Isometric Top Up.
  /// </summary>
  IsometricTopUp = 20,
  /// <summary>
  /// Specifies Isometric Top Down.
  /// </summary>
  IsometricTopDown = 21,
  /// <summary>
  /// Specifies Isometric Bottom Up.
  /// </summary>
  IsometricBottomUp = 22,
  /// <summary>
  /// Specifies Isometric Bottom Down.
  /// </summary>
  IsometricBottomDown = 23,
  /// <summary>
  /// Specifies Isometric Left Up.
  /// </summary>
  IsometricLeftUp = 24,
  /// <summary>
  /// Specifies Isometric Left Down.
  /// </summary>
  IsometricLeftDown = 25,
  /// <summary>
  /// Specifies Isometric Right Up.
  /// </summary>
  IsometricRightUp = 26,
  /// <summary>
  /// Specifies Isometric Right Down.
  /// </summary>
  IsometricRightDown = 27,
  /// <summary>
  /// Specifies Isometric OffAxis1 Left.
  /// </summary>
  IsometricOffAxis1Left = 28,
  /// <summary>
  /// Specifies Isometric OffAxis1 Right.
  /// </summary>
  IsometricOffAxis1Right = 29,
  /// <summary>
  /// Specifies Isometric OffAxis1 Top.
  /// </summary>
  IsometricOffAxis1Top = 30,
  /// <summary>
  /// Specifies Isometric OffAxis2 Left.
  /// </summary>
  IsometricOffAxis2Left = 31,
  /// <summary>
  /// Specifies Isometric OffAxis2 Right.
  /// </summary>
  IsometricOffAxis2Right = 32,
  /// <summary>
  /// Specifies Isometric OffAxis2 Top.
  /// </summary>
  IsometricOffAxis2Top = 33,
  /// <summary>
  /// Specifies Isometric OffAxis3 Left.
  /// </summary>
  IsometricOffAxis3Left = 34,
  /// <summary>
  /// Specifies Isometric OffAxis3 Right.
  /// </summary>
  IsometricOffAxis3Right = 35,
  /// <summary>
  /// Specifies Isometric OffAxis3 Bottom.
  /// </summary>
  IsometricOffAxis3Bottom = 36,
  /// <summary>
  /// Specifies Isometric OffAxis4 Left.
  /// </summary>
  IsometricOffAxis4Left = 37,
  /// <summary>
  /// Specifies Isometric OffAxis4 Right.
  /// </summary>
  IsometricOffAxis4Right = 38,
  /// <summary>
  /// Specifies Isometric OffAxis4 Bottom.
  /// </summary>
  IsometricOffAxis4Bottom = 39,
  /// <summary>
  /// Specifies Oblique Upper Left.
  /// </summary>
  ObliqueTopLeft = 40,
  /// <summary>
  /// Specifies Oblique Top.
  /// </summary>
  ObliqueTop = 41,
  /// <summary>
  /// Specifies Oblique Upper Right.
  /// </summary>
  ObliqueTopRight = 42,
  /// <summary>
  /// Specifies Oblique Left.
  /// </summary>
  ObliqueLeft = 43,
  /// <summary>
  /// Specifies Oblique Right.
  /// </summary>
  ObliqueRight = 44,
  /// <summary>
  /// Specifies Oblique Lower Left.
  /// </summary>
  ObliqueBottomLeft = 45,
  /// <summary>
  /// Specifies Oblique Bottom.
  /// </summary>
  ObliqueBottom = 46,
  /// <summary>
  /// Specifies Oblique Lower Right.
  /// </summary>
  ObliqueBottomRight = 47,
  /// <summary>
  /// Specifies Perspective Front.
  /// </summary>
  PerspectiveFront = 48,
  /// <summary>
  /// Specifies Perspective Left.
  /// </summary>
  PerspectiveLeft = 49,
  /// <summary>
  /// Specifies Perspective Right.
  /// </summary>
  PerspectiveRight = 50,
  /// <summary>
  /// Specifies Perspective Above.
  /// </summary>
  PerspectiveAbove = 51,
  /// <summary>
  /// Specifies Perspective Below.
  /// </summary>
  PerspectiveBelow = 52,
  /// <summary>
  /// Specifies Perspective Above Left Facing.
  /// </summary>
  PerspectiveAboveLeftFacing = 53,
  /// <summary>
  /// Specifies Perspective Above Right Facing.
  /// </summary>
  PerspectiveAboveRightFacing = 54,
  /// <summary>
  /// Specifies Perspective Contrasting Left Facing.
  /// </summary>
  PerspectiveContrastingLeftFacing = 55,
  /// <summary>
  /// Specifies Perspective Contrasting Right Facing.
  /// </summary>
  PerspectiveContrastingRightFacing = 56,
  /// <summary>
  /// Specifies Perspective Heroic Left Facing.
  /// </summary>
  PerspectiveHeroicLeftFacing = 57,
  /// <summary>
  /// Specifies Perspective Heroic Right Facing.
  /// </summary>
  PerspectiveHeroicRightFacing = 58,
  /// <summary>
  /// Specifies Perspective Heroic Extreme Left Facing.
  /// </summary>
  PerspectiveHeroicExtremeLeftFacing = 59,
  /// <summary>
  /// Specifies Perspective Heroic Extreme Right Facing.
  /// </summary>
  PerspectiveHeroicExtremeRightFacing = 60,
  /// <summary>
  /// Specifies Perspective Relaxed.
  /// </summary>
  PerspectiveRelaxed = 61,
  /// <summary>
  /// Specifies Perspective Relaxed Moderately.
  /// </summary>
  PerspectiveRelaxedModerately = 62
}
