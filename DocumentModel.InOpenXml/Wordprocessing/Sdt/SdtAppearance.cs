namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SdtAppearance enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum AppearanceKind
{
  /// <summary>
  ///   boundingBox.
  /// </summary>
  BoundingBox,
  /// <summary>
  ///   tags.
  /// </summary>
  Tags,
  /// <summary>
  ///   hidden.
  /// </summary>
  Hidden
}