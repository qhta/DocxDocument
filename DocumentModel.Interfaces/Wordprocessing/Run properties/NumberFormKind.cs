namespace DocumentModel.Wordprocessing;

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