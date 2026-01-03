namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticMarker interface.
/// </summary>
public interface ArtisticMarker: IModelElement
{
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy { get; set; }
  /// <summary>
  ///   size, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Size { get; set; }
}