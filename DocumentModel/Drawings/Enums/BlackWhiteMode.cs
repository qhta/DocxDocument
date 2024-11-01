namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Black and White Mode
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum BlackWhiteMode
{
  /// <summary>
  ///   Color.
  /// </summary>
  Color,

  /// <summary>
  ///   Automatic.
  /// </summary>
  Auto,

  /// <summary>
  ///   Gray.
  /// </summary>
  Gray,

  /// <summary>
  ///   Light Gray.
  /// </summary>
  LightGray,

  /// <summary>
  ///   Inverse Gray.
  /// </summary>
  InvGray,

  /// <summary>
  ///   Gray and White.
  /// </summary>
  GrayWhite,

  /// <summary>
  ///   Black and Gray.
  /// </summary>
  BlackGray,

  /// <summary>
  ///   Black and White.
  /// </summary>
  BlackWhite,

  /// <summary>
  ///   Black.
  /// </summary>
  Black,

  /// <summary>
  ///   White.
  /// </summary>
  White,

  /// <summary>
  ///   Hidden.
  /// </summary>
  Hidden
}