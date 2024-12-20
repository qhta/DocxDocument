namespace DocumentModel.Drawings;

/// <summary>
/// Defines the AdjustPoint2DType Class.
/// </summary>
public partial class AdjustPoint2DTypeImpl: ModelElementImpl, AdjustPoint2DType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.AdjustPoint2DType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.AdjustPoint2DType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public AdjustPoint2DTypeImpl(): base() {}
  
  public AdjustPoint2DTypeImpl(DocumentFormat.OpenXml.Drawing.AdjustPoint2DType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// X-Coordinate
  /// </summary>
  public String? X
  {
    get => (System.String?)OpenXmlElement?.X?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.X = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Y-Coordinate
  /// </summary>
  public String? Y
  {
    get => (System.String?)OpenXmlElement?.Y?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Y = (System.String?)value;
    }
  }
  
}
