namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticLightScreen interface.
/// </summary>
public interface ArtisticLightScreen: IModelElement
{
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy { get; set; }
  /// <summary>
  ///   gridSize, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? GridSize { get; set; }
}