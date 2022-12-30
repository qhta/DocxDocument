namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticCutout Class.
/// </summary>
public partial class ArtisticCutout
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy { get; set; }
  
  /// <summary>
  /// numberOfShades, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? NumberOfShades { get; set; }
  
}
