namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the VerticalAlignmentValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum VerticalAlignmentKind
{
  /// <summary>
  ///   In line With Text.
  /// </summary>
  Inline,

  /// <summary>
  ///   Top.
  /// </summary>
  Top,

  /// <summary>
  ///   Centered Vertically.
  /// </summary>
  Center,

  /// <summary>
  ///   Bottom.
  /// </summary>
  Bottom,

  /// <summary>
  ///   Inside Anchor Extents.
  /// </summary>
  Inside,

  /// <summary>
  ///   Outside Anchor Extents.
  /// </summary>
  Outside
}