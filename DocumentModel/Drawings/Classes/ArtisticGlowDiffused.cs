namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticGlowDiffused Class.
/// </summary>
public partial class ArtisticGlowDiffused
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy { get; set; }
  
  /// <summary>
  /// intensity, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Intensity { get; set; }
  
}
