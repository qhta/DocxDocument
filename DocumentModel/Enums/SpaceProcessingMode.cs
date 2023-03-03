namespace DocumentModel;

/// <summary>
///   Defines the SpaceProcessingModeValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SpaceProcessingMode
{
  /// <summary>
  ///   default.
  /// </summary>
  Default,

  /// <summary>
  ///   preserve.
  /// </summary>
  Preserve
}