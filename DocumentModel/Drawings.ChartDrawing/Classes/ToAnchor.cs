namespace DocumentModel.Drawings.ChartDrawing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Ending Anchor Point.
/// </summary>
public class ToAnchor: ModelElement
{
  public string? XPosition { get; set; }

  public string? YPosition { get; set; }
}