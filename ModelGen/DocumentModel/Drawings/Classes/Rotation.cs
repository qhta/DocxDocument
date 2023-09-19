namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a rotation in 3D space.  A rotation in DrawingML is defined through the use of a latitude coordinate, a longitude coordinate, and a revolution about the axis as the latitude and longitude coordinates.
/// </summary>
public partial class Rotation
{
  
  /// <summary>
  ///   Defines the latitude value of the rotation.
  /// </summary>
  [SchemaAttr("lat")]
  public Int32? Latitude { get; set; }
  
  
  /// <summary>
  ///   Defines the longitude value of the rotation.
  /// </summary>
  [SchemaAttr("lon")]
  public Int32? Longitude { get; set; }
  
  
  /// <summary>
  ///   This attributes defines the revolution around the central axis in the rotation.
  /// </summary>
  [SchemaAttr("rev")]
  public Int32? Revolution { get; set; }
  
}
