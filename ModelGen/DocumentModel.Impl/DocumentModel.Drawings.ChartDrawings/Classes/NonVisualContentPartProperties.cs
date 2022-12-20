namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the NonVisualContentPartProperties Class.
/// </summary>
public partial class NonVisualContentPartPropertiesImpl: ModelElementImpl, NonVisualContentPartProperties
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualContentPartProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualContentPartProperties?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public NonVisualContentPartPropertiesImpl(): base() {}
  
  public NonVisualContentPartPropertiesImpl(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualContentPartProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualDrawingProperties>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.NonVisualDrawingPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualDrawingProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.NonVisualDrawingPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// NonVisualInkContentPartProperties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.NonVisualInkContentPartProperties? NonVisualInkContentPartProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualInkContentPartProperties>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.NonVisualInkContentPartPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualInkContentPartProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.NonVisualInkContentPartPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
