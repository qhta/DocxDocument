namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the MergedCellValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
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