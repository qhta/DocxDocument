namespace DocumentModel.Drawings;

/// <summary>
/// Rotation.
/// </summary>
public class RotationImpl: ModelElementImpl, Rotation
{
  public DocumentFormat.OpenXml.Drawing.Rotation? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Rotation?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Latitude
  /// </summary>
  public Int32? Latitude
  {
    get;
    set;
  }
  
  /// <summary>
  /// Longitude
  /// </summary>
  public Int32? Longitude
  {
    get;
    set;
  }
  
  /// <summary>
  /// Revolution
  /// </summary>
  public Int32? Revolution
  {
    get;
    set;
  }
  
}
