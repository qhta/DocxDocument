namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the VerticalAlignmentValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum VerticalAlignmentKind
{
  /// <summary>
  ///   Top.
  /// </summary>
  Top,

  /// <summary>
  ///   Center (Function).
  /// </summary>
  Center,

  /// <summary>
  ///   bottom.
  /// </summary>
  Bottom,

  /// <summary>
  ///   Bottom Alignment.
  /// </summary>
  Bot
}