namespace DocumentModel.Drawings;

/// <summary>
/// Rotation.
/// </summary>
public interface Rotation // : System.Boolean
{
  /// <summary>
  /// Latitude
  /// </summary>
  public Int32? Latitude { get ; set; }
  
  /// <summary>
  /// Longitude
  /// </summary>
  public Int32? Longitude { get ; set; }
  
  /// <summary>
  /// Revolution
  /// </summary>
  public Int32? Revolution { get ; set; }
  
}
