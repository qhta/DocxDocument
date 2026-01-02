namespace DocumentModel;

/// <summary>
///   Defines the GalleryShowInRibbonValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum GalleryShowInRibbonKind
{
  /// <summary>
  ///   false.
  /// </summary>
  False,
  /// <summary>
  ///   0.
  /// </summary>
  Zero
}