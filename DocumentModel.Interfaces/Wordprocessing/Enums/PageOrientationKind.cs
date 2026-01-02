namespace DocumentModel.Wordprocessing;

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