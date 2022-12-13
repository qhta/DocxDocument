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
  
  public WrapPolygonImpl(): base() {}
  
  public WrapPolygonImpl(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Wrapping Points Modified
  /// </summary>
  public Boolean? Edited
  {
    get => (System.Boolean?)OpenXmlElement?.Edited?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Edited = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Wrapping Polygon Start.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.Point2DType? StartPoint
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.Drawings.Point2DType? LineTo
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
