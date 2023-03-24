namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TableOverlapValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TableOverlapKind
{
  /// <summary>
  ///   Floating Table Cannot Overlap.
  /// </summary>
  Never,

  /// <summary>
  ///   Floating Table Can Overlap.
  /// </summary>
  Overlap
}