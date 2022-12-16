namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Graphic Frame.
/// </summary>
public class GraphicFrameImpl: ModelElementImpl, GraphicFrame
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GraphicFrameImpl(): base() {}
  
  public GraphicFrameImpl(DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public String? Macro
  {
    get => (System.String?)OpenXmlElement?.Macro?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Macro = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Publish To Server
  /// </summary>
  public Boolean? Published
  {
    get => (System.Boolean?)OpenXmlElement?.Published?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Published = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Non-Visual Graphic Frame Properties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.NonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameProperties>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawing.NonVisualGraphicFramePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawing.NonVisualGraphicFramePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Graphic Frame Transform.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.Transform? Transform
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Transform>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawing.TransformImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Transform>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawing.TransformImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Graphical Object.
  /// </summary>
  public DocumentModel.Drawings.Graphic? Graphic
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Graphic>();
        if (item != null)
          return new DocumentModel.Drawings.GraphicImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Graphic>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.GraphicImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
