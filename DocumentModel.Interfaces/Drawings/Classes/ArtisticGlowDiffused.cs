namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticGlowDiffused interface.
/// </summary>
public interface ArtisticGlowDiffused: IModelElement
{
  /// <summary>
  ///   trans
  /// </summary>
  public Int32? Transparancy { get; set; }
  /// <summary>
  ///   intensity
  /// </summary>
  public Int32? Intensity { get; set; }
}