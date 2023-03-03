namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Printed Page Orientation
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PageSetupOrientationKind
{
  /// <summary>
  ///   Default Page Orientation.
  /// </summary>
  Default,

  /// <summary>
  ///   Portrait Page.
  /// </summary>
  Portrait,

  /// <summary>
  ///   Landscape Page.
  /// </summary>
  Landscape
}