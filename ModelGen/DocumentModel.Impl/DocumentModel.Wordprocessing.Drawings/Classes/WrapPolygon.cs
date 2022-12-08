namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Tight Wrapping Extents Polygon.
/// </summary>
public class WrapPolygonImpl: ModelElementImpl, WrapPolygon
{
  public DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Wrapping Points Modified
  /// </summary>
  public Boolean? Edited
  {
    get;
    set;
  }
  
  /// <summary>
  /// Wrapping Polygon Start.
  /// </summary>
  public Point2DType? StartPoint
  {
    get;
    set;
  }
  
  public Collection<Point2DType>? LineTos
  {
    get;
    set;
  }
  
}
