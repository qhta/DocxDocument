namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
///   Defines the MarkerType Class.
/// </summary>
public class MarkerType: ModelElement
{
  /// <summary>
  ///   Relative X Coordinate.
  /// </summary>
  public string? XPosition { get; set; }
  /// <summary>
  ///   Relative Y Coordinate.
  /// </summary>
  public string? YPosition { get; set; }
}