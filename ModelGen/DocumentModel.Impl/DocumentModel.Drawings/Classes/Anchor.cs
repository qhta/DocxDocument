namespace DocumentModel.Drawings;

/// <summary>
/// Anchor Point.
/// </summary>
public partial class AnchorImpl: ModelElementImpl, Anchor
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Anchor? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Anchor?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
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
    get => (System.Int64?)OpenXmlElement?.X?.Value;
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
    get => (System.Int64?)OpenXmlElement?.Y?.Value;
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
    get => (System.Int64?)OpenXmlElement?.Z?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Z = (System.Int64?)value;
    }
  }
  
}
