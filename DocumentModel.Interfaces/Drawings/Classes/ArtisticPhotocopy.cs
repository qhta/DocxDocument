namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticPhotocopy interface.
/// </summary>
public interface ArtisticPhotocopy: IModelElement
{
  /// <summary>
  ///   trans
  /// </summary>
  public Int32? Transparancy { get; set; }
  /// <summary>
  ///   detail
  /// </summary>
  public Int32? Detail { get; set; }
}