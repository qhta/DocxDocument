namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SphereCoordinates Class.
/// </summary>
public interface SphereCoordinates: IModelElement
{
  /// <summary>
  ///   lat
  /// </summary>
  public Int32? Lattitude { get; set; }
  /// <summary>
  ///   lon
  /// </summary>
  public Int32? Longitude { get; set; }
  /// <summary>
  ///   rev
  /// </summary>
  public Int32? Revolution { get; set; }
}