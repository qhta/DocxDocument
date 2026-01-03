namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticPaintBrush interface.
/// </summary>
public interface ArtisticPaintBrush: IModelElement
{
  /// <summary>
  ///   trans
  /// </summary>
  public Int32? Transparancy { get; set; }
  /// <summary>
  ///   brushSize
  /// </summary>
  public Int32? BrushSize { get; set; }
}