namespace DocumentModel.Drawings;
/// <summary>
///   Preset Shadow Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.PresetShadowValues))]
public enum PresetShadowKind
{
  /// <summary>
  ///   Top Left Drop Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetShadowValues.TopLeftDropShadow))]
  TopLeftDropShadow,
  /// <summary>
  ///   Top Right Drop Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetShadowValues.TopRightDropShadow))]
  TopRightDropShadow,
  /// <summary>
  ///   Back Left Perspective Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetShadowValues.BackLeftPerspectiveShadow))]
  BackLeftPerspectiveShadow,
  /// <summary>
  ///   Back Right Perspective Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetShadowValues.BackRightPerspectiveShadow))]
  BackRightPerspectiveShadow,
  /// <summary>
  ///   Bottom Left Drop Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetShadowValues.BottomLeftDropShadow))]
  BottomLeftDropShadow,
  /// <summary>
  ///   Bottom Right Drop Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetShadowValues.BottomRightDropShadow))]
  BottomRightDropShadow,
  /// <summary>
  ///   Front Left Perspective Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetShadowValues.FrontLeftPerspectiveShadow))]
  FrontLeftPerspectiveShadow,
  /// <summary>
  ///   Front Right Perspective Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetShadowValues.FrontRightPerspectiveShadow))]
  FrontRightPerspectiveShadow,
  /// <summary>
  ///   Top Left Small Drop Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetShadowValues.TopLeftSmallDropShadow))]
  TopLeftSmallDropShadow,
  /// <summary>
  ///   Top Left Large Drop Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetShadowValues.TopLeftLargeDropShadow))]
  TopLeftLargeDropShadow,
  /// <summary>
  ///   Back Left Long Perspective Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetShadowValues.BackLeftLongPerspectiveShadow))]
  BackLeftLongPerspectiveShadow,
  /// <summary>
  ///   Back Right Long Perspective Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetShadowValues.BackRightLongPerspectiveShadow))]
  BackRightLongPerspectiveShadow,
  /// <summary>
  ///   Top Left Double Drop Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetShadowValues.TopLeftDoubleDropShadow))]
  TopLeftDoubleDropShadow,
  /// <summary>
  ///   Bottom Right Small Drop Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetShadowValues.BottomRightSmallDropShadow))]
  BottomRightSmallDropShadow,
  /// <summary>
  ///   Front Left Long Perspective Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetShadowValues.FrontLeftLongPerspectiveShadow))]
  FrontLeftLongPerspectiveShadow,
  /// <summary>
  ///   Front Right LongPerspective Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetShadowValues.FrontRightLongPerspectiveShadow))]
  FrontRightLongPerspectiveShadow,
  /// <summary>
  ///   3D Outer Box Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetShadowValues.ThreeDimensionalOuterBoxShadow))]
  ThreeDimensionalOuterBoxShadow,
  /// <summary>
  ///   3D Inner Box Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetShadowValues.ThreeDimensionalInnerBoxShadow))]
  ThreeDimensionalInnerBoxShadow,
  /// <summary>
  ///   Back Center Perspective Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetShadowValues.BackCenterPerspectiveShadow))]
  BackCenterPerspectiveShadow,
  /// <summary>
  ///   Front Bottom Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetShadowValues.FrontBottomShadow))]
  FrontBottomShadow
}