namespace DocumentModel.Vml;

/// <summary>
///   Rule Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum RuleKind
{
  /// <summary>
  ///   Arc Rule.
  /// </summary>
  Arc,
  /// <summary>
  ///   Callout Rule.
  /// </summary>
  Callout,
  /// <summary>
  ///   Connector Rule.
  /// </summary>
  Connector
}