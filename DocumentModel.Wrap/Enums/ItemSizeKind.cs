namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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