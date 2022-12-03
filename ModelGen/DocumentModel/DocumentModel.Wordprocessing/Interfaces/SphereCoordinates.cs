namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SphereCoordinates Class.
/// </summary>
public interface SphereCoordinates // : System.Boolean
{
  /// <summary>
  /// lat, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Lattitude { get ; set; }
  
  /// <summary>
  /// lon, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Longitude { get ; set; }
  
  /// <summary>
  /// rev, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Revolution { get ; set; }
  
}
