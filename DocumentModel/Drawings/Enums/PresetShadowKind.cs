namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Preset Shadow Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PresetShadowKind
{
  /// <summary>
  ///   Top Left Drop Shadow.
  /// </summary>
  TopLeftDropShadow,

  /// <summary>
  ///   Top Right Drop Shadow.
  /// </summary>
  TopRightDropShadow,

  /// <summary>
  ///   Back Left Perspective Shadow.
  /// </summary>
  BackLeftPerspectiveShadow,

  /// <summary>
  ///   Back Right Perspective Shadow.
  /// </summary>
  BackRightPerspectiveShadow,

  /// <summary>
  ///   Bottom Left Drop Shadow.
  /// </summary>
  BottomLeftDropShadow,

  /// <summary>
  ///   Bottom Right Drop Shadow.
  /// </summary>
  BottomRightDropShadow,

  /// <summary>
  ///   Front Left Perspective Shadow.
  /// </summary>
  FrontLeftPerspectiveShadow,

  /// <summary>
  ///   Front Right Perspective Shadow.
  /// </summary>
  FrontRightPerspectiveShadow,

  /// <summary>
  ///   Top Left Small Drop Shadow.
  /// </summary>
  TopLeftSmallDropShadow,

  /// <summary>
  ///   Top Left Large Drop Shadow.
  /// </summary>
  TopLeftLargeDropShadow,

  /// <summary>
  ///   Back Left Long Perspective Shadow.
  /// </summary>
  BackLeftLongPerspectiveShadow,

  /// <summary>
  ///   Back Right Long Perspective Shadow.
  /// </summary>
  BackRightLongPerspectiveShadow,

  /// <summary>
  ///   Top Left Double Drop Shadow.
  /// </summary>
  TopLeftDoubleDropShadow,

  /// <summary>
  ///   Bottom Right Small Drop Shadow.
  /// </summary>
  BottomRightSmallDropShadow,

  /// <summary>
  ///   Front Left Long Perspective Shadow.
  /// </summary>
  FrontLeftLongPerspectiveShadow,

  /// <summary>
  ///   Front Right LongPerspective Shadow.
  /// </summary>
  FrontRightLongPerspectiveShadow,

  /// <summary>
  ///   3D Outer Box Shadow.
  /// </summary>
  ThreeDimensionalOuterBoxShadow,

  /// <summary>
  ///   3D Inner Box Shadow.
  /// </summary>
  ThreeDimensionalInnerBoxShadow,

  /// <summary>
  ///   Back Center Perspective Shadow.
  /// </summary>
  BackCenterPerspectiveShadow,

  /// <summary>
  ///   Front Bottom Shadow.
  /// </summary>
  FrontBottomShadow
}