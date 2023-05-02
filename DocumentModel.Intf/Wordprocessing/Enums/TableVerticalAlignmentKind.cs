namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TableVerticalAlignmentValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TableVerticalAlignmentKind
{
  /// <summary>
  ///   top.
  /// </summary>
  Top,

  /// <summary>
  ///   center.
  /// </summary>
  Center,

  /// <summary>
  ///   bottom.
  /// </summary>
  Bottom
}