namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticBlur interface.
/// </summary>
public interface ArtisticBlur: IModelElement
{
  /// <summary>
  ///   radius
  /// </summary>
  public Int32? Radius { get; set; }
}