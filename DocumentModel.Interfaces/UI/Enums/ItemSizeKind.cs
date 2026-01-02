namespace DocumentModel.UI;

/// <summary>
///   Defines the ItemSizeValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ItemSizeKind
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