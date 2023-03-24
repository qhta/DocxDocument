namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Rotation.
/// </summary>
public class Rotation: ModelElement
{
  /// <summary>
  ///   Latitude
  /// </summary>
  public Int32? Latitude { get; set; }

  /// <summary>
  ///   Longitude
  /// </summary>
  public Int32? Longitude { get; set; }

  /// <summary>
  ///   Revolution
  /// </summary>
  public Int32? Revolution { get; set; }
}