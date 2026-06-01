namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

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
