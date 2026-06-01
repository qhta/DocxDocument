namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the NumberFormValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum NumberFormKind
{
  /// <summary>
  ///   default.
  /// </summary>
  Default,

  /// <summary>
  ///   lining.
  /// </summary>
  Lining,

  /// <summary>
  ///   oldStyle.
  /// </summary>
  OldStyle
}
