namespace DocumentModel.Drawings.Wordprocessing;

/// <summary>
/// Defines the Point2DType Class.
/// </summary>
public partial class Point2DTypeImpl: ModelElementImpl, Point2DType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Wordprocessing.Point2DType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Wordprocessing.Point2DType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public Point2DTypeImpl(): base() {}
  
  public Point2DTypeImpl(DocumentFormat.OpenXml.Drawing.Wordprocessing.Point2DType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// X-Axis Coordinate
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
  /// Y-Axis Coordinate
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
  
}
