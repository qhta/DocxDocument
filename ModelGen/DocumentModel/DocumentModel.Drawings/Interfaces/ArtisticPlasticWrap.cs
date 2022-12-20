namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticPlasticWrap Class.
/// </summary>
public partial interface ArtisticPlasticWrap
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy { get; set; }
  
  /// <summary>
  /// smoothness, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Smoothness { get; set; }
  
}
