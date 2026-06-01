namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the PageOrientationValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PageOrientationKind
{
  /// <summary>
  ///   Portrait Mode.
  /// </summary>
  Portrait,

  /// <summary>
  ///   Landscape Mode.
  /// </summary>
  Landscape
}
