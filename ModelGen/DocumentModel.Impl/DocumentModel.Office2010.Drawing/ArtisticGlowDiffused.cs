namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ArtisticGlowDiffused Class.
/// </summary>
public class ArtisticGlowDiffused: IArtisticGlowDiffused
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
  /// intensity, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Intensity
  {
    get;
    set;
  }
  
}
