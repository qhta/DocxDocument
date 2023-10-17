namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies sphere coordinates using a latitude coordinate, a longitude coordinate, and a revolution around the central axis.
/// </summary>
public partial class SphereCoordinates
{
  
  /// <summary>
  ///   lat, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Lattitude { get; set; }
  
  
  /// <summary>
  ///   lon, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Longitude { get; set; }
  
  
  /// <summary>
  ///   rev, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Revolution { get; set; }
  
}
