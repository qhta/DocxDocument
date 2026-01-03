namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ImageProperties interface.
/// </summary>
public interface ImageProperties: IModelElement
{
  /// <summary>
  ///   ImageLayer.
  /// </summary>
  public ImageLayer? ImageLayer { get; set; }
}