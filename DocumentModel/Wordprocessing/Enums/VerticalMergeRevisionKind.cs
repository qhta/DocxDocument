namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the VerticalMergeRevisionValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum VerticalMergeRevisionKind
{
  /// <summary>
  ///   Vertically Merged Cell.
  /// </summary>
  Continue,

  /// <summary>
  ///   Vertically Split Cell.
  /// </summary>
  Restart
}