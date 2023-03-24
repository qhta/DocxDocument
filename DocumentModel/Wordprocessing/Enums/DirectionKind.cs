namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DirectionValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DirectionKind
{
  /// <summary>
  ///   ltr.
  /// </summary>
  Ltr,

  /// <summary>
  ///   rtl.
  /// </summary>
  Rtl
}