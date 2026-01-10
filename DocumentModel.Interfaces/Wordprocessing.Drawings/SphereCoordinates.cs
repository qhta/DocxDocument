namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents spherical coordinates for positioning or orienting elements in a 3D space within a Wordprocessing document.
/// This interface provides properties for latitude, longitude, and revolution, enabling precise control over 3D placement and rotation.
/// </summary>
public interface SphereCoordinates
{

  /// <summary>
  /// The latitude value, specifying the north-south position in the spherical coordinate system.
  /// </summary>
  public Int32? Latitude { get; set; }

  /// <summary>
  /// The longitude value, specifying the east-west position in the spherical coordinate system.
  /// </summary>
  public Int32? Longitude { get; set; }

  /// <summary>
  /// The revolution value, specifying the rotation around the sphere's axis.
  /// </summary>
  public Int32? Revolution { get; set; }
}