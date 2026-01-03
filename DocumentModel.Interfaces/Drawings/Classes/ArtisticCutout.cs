namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticCutout interface.
/// </summary>
public interface ArtisticCutout: IModelElement
{
  /// <summary>
  ///   trans
  /// </summary>
  public Int32? Transparancy { get; set; }
  /// <summary>
  ///   numberOfShades
  /// </summary>
  public Int32? NumberOfShades { get; set; }
}