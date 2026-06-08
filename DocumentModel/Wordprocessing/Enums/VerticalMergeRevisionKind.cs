namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the VerticalMergeRevisionValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum VerticalMergeRevisionKind
{
  /// <summary>
  ///   Vertically Merged ICell.
  /// </summary>
  Continue,

  /// <summary>
  ///   Vertically Split ICell.
  /// </summary>
  Restart
}
