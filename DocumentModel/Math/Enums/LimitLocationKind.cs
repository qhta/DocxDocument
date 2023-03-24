namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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