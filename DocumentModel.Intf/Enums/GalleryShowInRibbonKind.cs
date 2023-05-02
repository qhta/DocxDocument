namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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