namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticPlasticWrap interface.
/// </summary>
public interface ArtisticPlasticWrap: IModelElement
{
  /// <summary>
  ///   trans
  /// </summary>
  public Int32? Transparancy { get; set; }
  /// <summary>
  ///   smoothness
  /// </summary>
  public Int32? Smoothness { get; set; }
}