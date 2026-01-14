namespace DocumentModel.Drawings;

/// <summary>
///   Represents rotation parameters, including latitude, longitude, and revolution values.
/// </summary>
public interface Rotation
{
  /// <summary>
  ///   Latitude value for the rotation.
  /// </summary>
  public Int32? Latitude { get; set; }

  /// <summary>
  ///   Longitude value for the rotation.
  /// </summary>
  public Int32? Longitude { get; set; }

  /// <summary>
  ///   Revolution value for the rotation.
  /// </summary>
  public Int32? Revolution { get; set; }
}