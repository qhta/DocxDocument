namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticCement interface.
/// </summary>
public interface ArtisticCement: IModelElement
{
  /// <summary>
  ///   trans
  /// </summary>
  public Int32? Transparancy { get; set; }
  /// <summary>
  ///   crackSpacing
  /// </summary>
  public Int32? CrackSpacing { get; set; }
}