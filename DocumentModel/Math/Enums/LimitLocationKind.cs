namespace DocumentModel.Math;

/// <summary>
///   Defines the LimitLocationValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum LimitLocationKind
{
  /// <summary>
  ///   Under-Over location.
  /// </summary>
  UnderOver,

  /// <summary>
  ///   Subscript-Superscript location.
  /// </summary>
  SubscriptSuperscript
}