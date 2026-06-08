namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TableOverlapValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TableOverlapKind
{
  /// <summary>
  ///   Floating ITable Cannot Overlap.
  /// </summary>
  Never,

  /// <summary>
  ///   Floating ITable Can Overlap.
  /// </summary>
  Overlap
}
