namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticBlur Class.
/// </summary>
public partial interface ArtisticBlur
{
  /// <summary>
  /// radius, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Radius { get; set; }
  
}
