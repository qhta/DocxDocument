namespace DocumentModel.Drawings;

/// <summary>
///   Scheme Color
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SchemeColorKind
{
  /// <summary>
  ///   Background Color 1.
  /// </summary>
  Background1,
  /// <summary>
  ///   Text Color 1.
  /// </summary>
  Text1,
  /// <summary>
  ///   Background Color 2.
  /// </summary>
  Background2,
  /// <summary>
  ///   Text Color 2.
  /// </summary>
  Text2,
  /// <summary>
  ///   Accent Color 1.
  /// </summary>
  Accent1,
  /// <summary>
  ///   Accent Color 2.
  /// </summary>
  Accent2,
  /// <summary>
  ///   Accent Color 3.
  /// </summary>
  Accent3,
  /// <summary>
  ///   Accent Color 4.
  /// </summary>
  Accent4,
  /// <summary>
  ///   Accent Color 5.
  /// </summary>
  Accent5,
  /// <summary>
  ///   Accent Color 6.
  /// </summary>
  Accent6,
  /// <summary>
  ///   Hyperlink Color.
  /// </summary>
  Hyperlink,
  /// <summary>
  ///   Followed Hyperlink Color.
  /// </summary>
  FollowedHyperlink,
  /// <summary>
  ///   Style Color.
  /// </summary>
  PhColor,
  /// <summary>
  ///   Dark Color 1.
  /// </summary>
  Dark1,
  /// <summary>
  ///   Light Color 1.
  /// </summary>
  Light1,
  /// <summary>
  ///   Dark Color 2.
  /// </summary>
  Dark2,
  /// <summary>
  ///   Light Color 2.
  /// </summary>
  Light2
}