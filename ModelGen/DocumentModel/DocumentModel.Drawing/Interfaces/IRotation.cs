namespace DocumentModel.Drawing;

/// <summary>
/// Rotation.
/// </summary>
public interface IRotation // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Latitude
  /// </summary>
  public System.Int32? Latitude { get ; set; }
  
  /// <summary>
  /// Longitude
  /// </summary>
  public System.Int32? Longitude { get ; set; }
  
  /// <summary>
  /// Revolution
  /// </summary>
  public System.Int32? Revolution { get ; set; }
  
}
