namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the PageOrientation enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PageOrientation
{
  /// <summary>
  ///   default.
  /// </summary>
  Default,

  /// <summary>
  ///   portrait.
  /// </summary>
  Portrait,

  /// <summary>
  ///   landscape.
  /// </summary>
  Landscape
}
