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
  
  /// <summary>
  /// Line end point.
  /// </summary>
  public AdjustPoint2DType? Point
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
