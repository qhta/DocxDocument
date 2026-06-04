namespace DocumentModel.Wordprocessing;
/// <summary>
/// Defines the SchemeColor enumeration.
/// Used in types such as ColorType, SchemeColor, SolidColorFillProperties.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.SchemeColorValues))]
public enum SchemeColor
{
  /// <summary>
  ///   bg1.
  /// </summary>
  [OpenXmlEnumValue("BackgroundColor")]
  BackgroundColor,
  /// <summary>
  ///   tx1.
  /// </summary>
  [OpenXmlEnumValue("TextColor")]
  TextColor,
  /// <summary>
  ///   bg2.
  /// </summary>
  [OpenXmlEnumValue("AdditionalBackgroundColor")]
  AdditionalBackgroundColor,
  /// <summary>
  ///   tx2.
  /// </summary>
  [OpenXmlEnumValue("AdditionalTextColor")]
  AdditionalTextColor,
  /// <summary>
  ///   accent1.
  /// </summary>
  [OpenXmlEnumValue("ExtraSchemeColor1")]
  ExtraSchemeColor1,
  /// <summary>
  ///   accent2.
  /// </summary>
  [OpenXmlEnumValue("ExtraSchemeColor2")]
  ExtraSchemeColor2,
  /// <summary>
  ///   accent3.
  /// </summary>
  [OpenXmlEnumValue("ExtraSchemeColor3")]
  ExtraSchemeColor3,
  /// <summary>
  ///   accent4.
  /// </summary>
  [OpenXmlEnumValue("ExtraSchemeColor4")]
  ExtraSchemeColor4,
  /// <summary>
  ///   accent5.
  /// </summary>
  [OpenXmlEnumValue("ExtraSchemeColor5")]
  ExtraSchemeColor5,
  /// <summary>
  ///   accent6.
  /// </summary>
  [OpenXmlEnumValue("ExtraSchemeColor6")]
  ExtraSchemeColor6,
  /// <summary>
  ///   hlink.
  /// </summary>
  [OpenXmlEnumValue("HyperlinkColor")]
  HyperlinkColor,
  /// <summary>
  ///   folHlink.
  /// </summary>
  [OpenXmlEnumValue("FollowedHyperlinkColor")]
  FollowedHyperlinkColor,
  /// <summary>
  ///   dk1.
  /// </summary>
  [OpenXmlEnumValue("MainDarkColor1")]
  MainDarkColor1,
  /// <summary>
  ///   lt1.
  /// </summary>
  [OpenXmlEnumValue("MainLightColor1")]
  MainLightColor1,
  /// <summary>
  ///   dk2.
  /// </summary>
  [OpenXmlEnumValue("MainDarkColor2")]
  MainDarkColor2,
  /// <summary>
  ///   lt2.
  /// </summary>
  [OpenXmlEnumValue("MainLightColor2")]
  MainLightColor2,
  /// <summary>
  ///   phClr.
  /// </summary>
  [OpenXmlEnumValue("AutoColor")]
  AutoColor
}

