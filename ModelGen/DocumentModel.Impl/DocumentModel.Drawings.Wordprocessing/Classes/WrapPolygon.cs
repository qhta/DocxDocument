namespace DocumentModel.Drawings.Wordprocessing;

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
  public DocumentModel.Drawings.Wordprocessing.Point2DType? StartPoint
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Point2DType>();
        if (item != null)
          return new DocumentModel.Drawings.Wordprocessing.Point2DTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Point2DType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Wordprocessing.Point2DTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Wordprocessing.Point2DType? LineTo
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Point2DType>();
        if (item != null)
          return new DocumentModel.Drawings.Wordprocessing.Point2DTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Point2DType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Wordprocessing.Point2DTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
