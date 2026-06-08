namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Printed IPage Orientation
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PageSetupOrientationKind
{
  /// <summary>
  ///   Default IPage Orientation.
  /// </summary>
  Default,

  /// <summary>
  ///   Portrait IPage.
  /// </summary>
  Portrait,

  /// <summary>
  ///   Landscape IPage.
  /// </summary>
  Landscape
}
