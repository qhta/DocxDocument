namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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