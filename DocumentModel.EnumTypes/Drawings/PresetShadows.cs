namespace DocumentModel.Drawings;
/// <summary>
///   Preset Shadow Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.PresetShadowValues))]
public enum PresetShadows
{
  /// <summary>
  ///   Top Left Drop Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetShadowValues.TopLeftDropShadow))]
  TopLeftDropShadow,
  /// <summary>
  ///   Top Right Drop Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetShadowValues.TopRightDropShadow))]
  TopRightDropShadow,
  /// <summary>
  ///   Back Left Perspective Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetShadowValues.BackLeftPerspectiveShadow))]
  BackLeftPerspectiveShadow,
  /// <summary>
  ///   Back Right Perspective Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetShadowValues.BackRightPerspectiveShadow))]
  BackRightPerspectiveShadow,
  /// <summary>
  ///   Bottom Left Drop Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetShadowValues.BottomLeftDropShadow))]
  BottomLeftDropShadow,
  /// <summary>
  ///   Bottom Right Drop Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetShadowValues.BottomRightDropShadow))]
  BottomRightDropShadow,
  /// <summary>
  ///   Front Left Perspective Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetShadowValues.FrontLeftPerspectiveShadow))]
  FrontLeftPerspectiveShadow,
  /// <summary>
  ///   Front Right Perspective Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetShadowValues.FrontRightPerspectiveShadow))]
  FrontRightPerspectiveShadow,
  /// <summary>
  ///   Top Left Small Drop Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetShadowValues.TopLeftSmallDropShadow))]
  TopLeftSmallDropShadow,
  /// <summary>
  ///   Top Left Large Drop Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetShadowValues.TopLeftLargeDropShadow))]
  TopLeftLargeDropShadow,
  /// <summary>
  ///   Back Left Long Perspective Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetShadowValues.BackLeftLongPerspectiveShadow))]
  BackLeftLongPerspectiveShadow,
  /// <summary>
  ///   Back Right Long Perspective Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetShadowValues.BackRightLongPerspectiveShadow))]
  BackRightLongPerspectiveShadow,
  /// <summary>
  ///   Top Left Double Drop Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetShadowValues.TopLeftDoubleDropShadow))]
  TopLeftDoubleDropShadow,
  /// <summary>
  ///   Bottom Right Small Drop Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetShadowValues.BottomRightSmallDropShadow))]
  BottomRightSmallDropShadow,
  /// <summary>
  ///   Front Left Long Perspective Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetShadowValues.FrontLeftLongPerspectiveShadow))]
  FrontLeftLongPerspectiveShadow,
  /// <summary>
  ///   Front Right LongPerspective Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetShadowValues.FrontRightLongPerspectiveShadow))]
  FrontRightLongPerspectiveShadow,
  /// <summary>
  ///   3D Outer Box Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetShadowValues.ThreeDimensionalOuterBoxShadow))]
  ThreeDimensionalOuterBoxShadow,
  /// <summary>
  ///   3D Inner Box Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetShadowValues.ThreeDimensionalInnerBoxShadow))]
  ThreeDimensionalInnerBoxShadow,
  /// <summary>
  ///   Back Center Perspective Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetShadowValues.BackCenterPerspectiveShadow))]
  BackCenterPerspectiveShadow,
  /// <summary>
  ///   Front Bottom Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetShadowValues.FrontBottomShadow))]
  FrontBottomShadow
}