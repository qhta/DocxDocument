namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the StyleValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum StyleKind
{
  /// <summary>
  ///   normal.
  /// </summary>
  Normal,

  /// <summary>
  ///   warning.
  /// </summary>
  Warning,

  /// <summary>
  ///   error.
  /// </summary>
  Error
}