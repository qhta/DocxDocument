namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ArtisticGlowEdges Class.
/// </summary>
public class ArtisticGlowEdges: IArtisticGlowEdges
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Transparancy
  {
    get;
    set;
  }
  
  /// <summary>
  /// smoothness, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Smoothness
  {
    get;
    set;
  }
  
}
