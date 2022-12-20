namespace DocumentModel.Drawings.Charts;

/// <summary>
/// User Shapes.
/// </summary>
public partial class UserShapesImpl: ModelElementImpl, UserShapes
{
  public DocumentFormat.OpenXml.Drawing.Charts.UserShapes? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.UserShapes?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public UserShapesImpl(): base() {}
  
  public UserShapesImpl(DocumentFormat.OpenXml.Drawing.Charts.UserShapes openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the ChartDrawingPart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.ChartDrawingPart? ChartDrawingPart
  {
    get
    {
      if (OpenXmlElement?.ChartDrawingPart != null)
        return new DocumentModel.Packaging.ChartDrawingPartImpl(OpenXmlElement.ChartDrawingPart);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
        if (value is DocumentModel.Packaging.ChartDrawingPartImpl valueImpl)
          if (valueImpl.OpenXmlElement != null)
              OpenXmlElement.SetPart(valueImpl.OpenXmlElement);
    }
  }
  
  public DocumentModel.Drawings.ChartDrawing.RelativeAnchorSize? RelativeAnchorSize
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawing.RelativeAnchorSizeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawing.RelativeAnchorSizeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.ChartDrawing.AbsoluteAnchorSize? AbsoluteAnchorSize
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.AbsoluteAnchorSize>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawing.AbsoluteAnchorSizeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.AbsoluteAnchorSize>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawing.AbsoluteAnchorSizeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
