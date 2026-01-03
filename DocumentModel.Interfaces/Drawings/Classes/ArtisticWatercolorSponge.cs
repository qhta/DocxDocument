namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticWatercolorSponge interface.
/// </summary>
public interface ArtisticWatercolorSponge: IModelElement
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