namespace DocumentModel.Wordprocessing.DrawingCanvas;

/// <summary>
/// Defines the GraphicFrameType Class.
/// </summary>
public partial class GraphicFrameTypeImpl: ModelElementImpl, GraphicFrameType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Word.DrawingCanvas.GraphicFrameType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.DrawingCanvas.GraphicFrameType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public GraphicFrameTypeImpl(): base() {}
  
  public GraphicFrameTypeImpl(DocumentFormat.OpenXml.Office2010.Word.DrawingCanvas.GraphicFrameType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.DrawingGroup.NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualDrawingProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.DrawingGroup.NonVisualDrawingPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualDrawingProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.DrawingGroup.NonVisualDrawingPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// NonVisualGraphicFrameProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.DrawingGroup.NonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualGraphicFrameProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.DrawingGroup.NonVisualGraphicFramePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualGraphicFrameProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.DrawingGroup.NonVisualGraphicFramePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public DocumentModel.Wordprocessing.DrawingGroup.Transform2D? Transform2D
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.Transform2D>();
        if (item != null)
          return new DocumentModel.Wordprocessing.DrawingGroup.Transform2DImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.Transform2D>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.DrawingGroup.Transform2DImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Graphic.
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
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Wordprocessing.DrawingGroup.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.OfficeArtExtensionList>();
        if (item != null)
          return new DocumentModel.Wordprocessing.DrawingGroup.OfficeArtExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.OfficeArtExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.DrawingGroup.OfficeArtExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
