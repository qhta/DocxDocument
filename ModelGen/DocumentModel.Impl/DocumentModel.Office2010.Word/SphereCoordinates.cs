namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the SphereCoordinates Class.
/// </summary>
public class SphereCoordinates: ISphereCoordinates
{
  /// <summary>
  /// lat, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Lattitude
  {
    get;
    set;
  }
  
  /// <summary>
  /// lon, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Longitude
  {
    get;
    set;
  }
  
  /// <summary>
  /// rev, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Revolution
  {
    get;
    set;
  }
  
}
