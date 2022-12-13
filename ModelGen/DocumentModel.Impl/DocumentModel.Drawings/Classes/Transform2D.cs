namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Transform2D Class.
/// </summary>
public class Transform2DImpl: ModelElementImpl, Transform2D
{
  public DocumentFormat.OpenXml.Office.Drawing.Transform2D? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Drawing.Transform2D?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Transform2DImpl(): base() {}
  
  public Transform2DImpl(DocumentFormat.OpenXml.Office.Drawing.Transform2D openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Rotation
  /// </summary>
  public Int32? Rotation
  {
    get => (System.Int32?)OpenXmlElement?.Rotation?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Rotation = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Horizontal Flip
  /// </summary>
  public Boolean? HorizontalFlip
  {
    get => (System.Boolean?)OpenXmlElement?.HorizontalFlip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalFlip = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Vertical Flip
  /// </summary>
  public Boolean? VerticalFlip
  {
    get => (System.Boolean?)OpenXmlElement?.VerticalFlip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.VerticalFlip = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Offset.
  /// </summary>
  public DocumentModel.Drawings.Point2DType? Offset
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Extents.
  /// </summary>
  public DocumentModel.Drawings.PositiveSize2DType? Extents
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
