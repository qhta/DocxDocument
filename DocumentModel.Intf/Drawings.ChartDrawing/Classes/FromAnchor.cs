namespace DocumentModel.Drawings.ChartDrawing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Starting Anchor Point.
/// </summary>
public class FromAnchor: ModelElement
{
  public string? XPosition { get; set; }

  public string? YPosition { get; set; }
}