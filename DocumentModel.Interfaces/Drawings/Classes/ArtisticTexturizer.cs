namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticTexturizer interface.
/// </summary>
public interface ArtisticTexturizer: IModelElement
{
  /// <summary>
  ///   trans
  /// </summary>
  public Int32? Transparancy { get; set; }
  /// <summary>
  ///   scaling
  /// </summary>
  public Int32? Scaling { get; set; }
}