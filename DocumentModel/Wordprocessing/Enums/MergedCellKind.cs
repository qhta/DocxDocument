namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the MergedCellValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum MergedCellKind
{
  /// <summary>
  ///   Continue Merged Region.
  /// </summary>
  Continue,

  /// <summary>
  ///   Start/Restart Merged Region.
  /// </summary>
  Restart
}