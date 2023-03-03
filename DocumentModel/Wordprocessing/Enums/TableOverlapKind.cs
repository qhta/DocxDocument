namespace DocumentModel.Wordprocessing;

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