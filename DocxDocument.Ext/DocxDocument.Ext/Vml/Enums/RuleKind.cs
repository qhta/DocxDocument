namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Rule Type
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
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