namespace DocumentModel.Drawings.ChartDrawing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the MarkerType Class.
/// </summary>
public class MarkerType: ModelElement
{
  /// <summary>
  ///   Relative X Coordinate.
  /// </summary>
  public String? XPosition { get; set; }

  /// <summary>
  ///   Relative Y Coordinate.
  /// </summary>
  public String? YPosition { get; set; }
}