namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SdtAppearance enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SdtAppearance
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