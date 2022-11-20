namespace DocumentModel.Drawing;

/// <summary>
/// Rotation.
/// </summary>
public interface IRotation // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Latitude
  /// </summary>
  public int? Latitude { get ; set; }
  
  /// <summary>
  /// Longitude
  /// </summary>
  public int? Longitude { get ; set; }
  
  /// <summary>
  /// Revolution
  /// </summary>
  public int? Revolution { get ; set; }
  
}
