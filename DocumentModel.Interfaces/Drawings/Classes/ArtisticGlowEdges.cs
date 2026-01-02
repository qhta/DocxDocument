namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticGlowEdges Class.
/// </summary>
public class ArtisticGlowEdges: ModelElement
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