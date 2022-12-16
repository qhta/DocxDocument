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
