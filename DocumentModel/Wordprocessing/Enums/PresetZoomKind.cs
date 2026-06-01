namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the PresetZoomValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PresetZoomKind
{
  /// <summary>
  ///   No Preset Magnification.
  /// </summary>
  None,

  /// <summary>
  ///   Display One Full IPage.
  /// </summary>
  FullPage,

  /// <summary>
  ///   Display IPage Width.
  /// </summary>
  BestFit,

  /// <summary>
  ///   Display Text Width.
  /// </summary>
  TextFit
}
