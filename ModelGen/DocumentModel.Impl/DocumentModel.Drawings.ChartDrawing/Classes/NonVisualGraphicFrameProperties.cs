namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Graphic Frame Properties.
/// </summary>
public partial class NonVisualGraphicFramePropertiesImpl: ModelElementImpl, NonVisualGraphicFrameProperties
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameProperties?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public NonVisualGraphicFramePropertiesImpl(): base() {}
  
  public NonVisualGraphicFramePropertiesImpl(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Non-Visual Drawing Properties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawing.NonVisualDrawingPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawing.NonVisualDrawingPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Non-Visual Graphic Frame Drawing Properties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.NonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameDrawingProperties>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawing.NonVisualGraphicFrameDrawingPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameDrawingProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawing.NonVisualGraphicFrameDrawingPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
