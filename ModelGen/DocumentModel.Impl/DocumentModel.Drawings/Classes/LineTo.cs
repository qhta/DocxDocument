namespace DocumentModel.Drawings;

/// <summary>
/// Draw Line To.
/// </summary>
public class LineToImpl: ModelElementImpl, LineTo
{
  public DocumentFormat.OpenXml.Drawing.LineTo? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.LineTo?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LineToImpl(): base() {}
  
  public LineToImpl(DocumentFormat.OpenXml.Drawing.LineTo openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Line end point.
  /// </summary>
  public DocumentModel.Drawings.AdjustPoint2DType? Point
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
