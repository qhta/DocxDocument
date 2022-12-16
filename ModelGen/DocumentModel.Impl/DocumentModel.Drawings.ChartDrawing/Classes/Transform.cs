namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Graphic Frame Transform.
/// </summary>
public class TransformImpl: ModelElementImpl, Transform
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.Transform? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.Transform?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TransformImpl(): base() {}
  
  public TransformImpl(DocumentFormat.OpenXml.Drawing.ChartDrawing.Transform openXmlElement): base(openXmlElement)
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
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Point2DType>();
        if (item != null)
          return new DocumentModel.Drawings.Point2DTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Point2DType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Point2DTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Extents.
  /// </summary>
  public DocumentModel.Drawings.PositiveSize2DType? Extents
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PositiveSize2DType>();
        if (item != null)
          return new DocumentModel.Drawings.PositiveSize2DTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PositiveSize2DType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.PositiveSize2DTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
