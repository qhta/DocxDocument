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
    get => (Boolean?)OpenXmlElement?.Edited?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Edited = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Wrapping Polygon Start.
  /// </summary>
  public Point2DType? StartPoint
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Point2DType>? LineTos
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
