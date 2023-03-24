namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the SchemeColorValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SchemeColorKind
{
  /// <summary>
  ///   bg1.
  /// </summary>
  BackgroundColor,

  /// <summary>
  ///   tx1.
  /// </summary>
  TextColor,

  /// <summary>
  ///   bg2.
  /// </summary>
  AdditionalBackgroundColor,

  /// <summary>
  ///   tx2.
  /// </summary>
  AdditionalTextColor,

  /// <summary>
  ///   accent1.
  /// </summary>
  ExtraSchemeColor1,

  /// <summary>
  ///   accent2.
  /// </summary>
  ExtraSchemeColor2,

  /// <summary>
  ///   accent3.
  /// </summary>
  ExtraSchemeColor3,

  /// <summary>
  ///   accent4.
  /// </summary>
  ExtraSchemeColor4,

  /// <summary>
  ///   accent5.
  /// </summary>
  ExtraSchemeColor5,

  /// <summary>
  ///   accent6.
  /// </summary>
  ExtraSchemeColor6,

  /// <summary>
  ///   hlink.
  /// </summary>
  HyperlinkColor,

  /// <summary>
  ///   folHlink.
  /// </summary>
  FollowedHyperlinkColor,

  /// <summary>
  ///   dk1.
  /// </summary>
  MainDarkColor1,

  /// <summary>
  ///   lt1.
  /// </summary>
  MainLightColor1,

  /// <summary>
  ///   dk2.
  /// </summary>
  MainDarkColor2,

  /// <summary>
  ///   lt2.
  /// </summary>
  MainLightColor2,

  /// <summary>
  ///   phClr.
  /// </summary>
  AutoColor
}