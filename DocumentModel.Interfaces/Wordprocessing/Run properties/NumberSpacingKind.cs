namespace DocumentModel.Wordprocessing;

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