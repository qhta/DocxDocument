namespace DocumentModel.Drawings;

/// <summary>
/// Draw Line To.
/// </summary>
public partial class LineToImpl: ModelElementImpl, LineTo
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
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustPoint2DType>();
        if (item != null)
          return new DocumentModel.Drawings.AdjustPoint2DTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustPoint2DType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.AdjustPoint2DTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
