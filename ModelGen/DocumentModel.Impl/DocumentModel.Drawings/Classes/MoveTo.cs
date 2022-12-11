namespace DocumentModel.Drawings;

/// <summary>
/// Move Path To.
/// </summary>
public class MoveToImpl: ModelElementImpl, MoveTo
{
  public DocumentFormat.OpenXml.Drawing.MoveTo? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.MoveTo?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MoveToImpl(): base() {}
  
  public MoveToImpl(DocumentFormat.OpenXml.Drawing.MoveTo openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Move end point.
  /// </summary>
  public AdjustPoint2DType? Point
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
