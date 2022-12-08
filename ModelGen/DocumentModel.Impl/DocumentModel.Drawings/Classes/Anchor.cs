namespace DocumentModel.Drawings;

/// <summary>
/// Anchor Point.
/// </summary>
public class AnchorImpl: ModelElementImpl, Anchor
{
  public DocumentFormat.OpenXml.Drawing.Anchor? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Anchor?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// X-Coordinate in 3D
  /// </summary>
  public Int64? X
  {
    get;
    set;
  }
  
  /// <summary>
  /// Y-Coordinate in 3D
  /// </summary>
  public Int64? Y
  {
    get;
    set;
  }
  
  /// <summary>
  /// Z-Coordinate in 3D
  /// </summary>
  public Int64? Z
  {
    get;
    set;
  }
  
}
