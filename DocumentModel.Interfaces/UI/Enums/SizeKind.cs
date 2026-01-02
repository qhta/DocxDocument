namespace DocumentModel.UI;

/// <summary>
///   Defines the SizeValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SizeKind
{
  /// <summary>
  ///   normal.
  /// </summary>
  Normal,
  /// <summary>
  ///   large.
  /// </summary>
  Large
}