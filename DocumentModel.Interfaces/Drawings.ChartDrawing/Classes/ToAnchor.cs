namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
///   Ending Anchor Point.
/// </summary>
public interface ToAnchor: IModelElement
{
  public string? XPosition { get; set; }
  public string? YPosition { get; set; }
}