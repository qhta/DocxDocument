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
  
  public AnchorImpl(): base() {}
  
  public AnchorImpl(DocumentFormat.OpenXml.Drawing.Anchor openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// X-Coordinate in 3D
  /// </summary>
  public Int64? X
  {
    get => (Int64?)OpenXmlElement?.X?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.X = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// Y-Coordinate in 3D
  /// </summary>
  public Int64? Y
  {
    get => (Int64?)OpenXmlElement?.Y?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Y = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// Z-Coordinate in 3D
  /// </summary>
  public Int64? Z
  {
    get => (Int64?)OpenXmlElement?.Z?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Z = (System.Int64?)value;
    }
  }
  
}
