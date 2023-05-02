namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Layout Mode
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum LayoutMode
{
  /// <summary>
  ///   Edge.
  /// </summary>
  Edge,

  /// <summary>
  ///   Factor.
  /// </summary>
  Factor
}