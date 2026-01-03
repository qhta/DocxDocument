namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticGlass interface.
/// </summary>
public interface ArtisticGlass: IModelElement
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