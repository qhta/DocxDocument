namespace DocumentModel.Drawings.Charts;

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