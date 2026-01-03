namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
///   Starting Anchor Point.
/// </summary>
public interface FromAnchor: IModelElement
{
  public string? XPosition { get; set; }
  public string? YPosition { get; set; }
}