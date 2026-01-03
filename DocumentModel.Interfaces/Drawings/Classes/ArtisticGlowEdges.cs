namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticGlowEdges interface.
/// </summary>
public interface ArtisticGlowEdges: IModelElement
{
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy { get; set; }
  /// <summary>
  ///   smoothness, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Smoothness { get; set; }
}