namespace DocumentModel.Wordprocessing;

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