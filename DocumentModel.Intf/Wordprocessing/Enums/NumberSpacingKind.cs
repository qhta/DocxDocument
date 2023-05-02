namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the NumberSpacingValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum NumberSpacingKind
{
  /// <summary>
  ///   default.
  /// </summary>
  Default,

  /// <summary>
  ///   proportional.
  /// </summary>
  Proportional,

  /// <summary>
  ///   tabular.
  /// </summary>
  Tabular
}