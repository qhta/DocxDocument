namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticBlur Class.
/// </summary>
public interface ArtisticBlur // : System.Boolean
{
  /// <summary>
  /// radius, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Radius { get ; set; }
  
}
