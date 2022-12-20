namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Connection Shape.
/// </summary>
public partial class ConnectionShapeImpl: ModelElementImpl, ConnectionShape
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ConnectionShapeImpl(): base() {}
  
  public ConnectionShapeImpl(DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape openXmlElement): base(openXmlElement)
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
  /// Publish to Server
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
  /// Connector Non Visual Properties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.NonVisualConnectorShapeDrawingProperties? NonVisualConnectorShapeDrawingProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectorShapeDrawingProperties>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawing.NonVisualConnectorShapeDrawingPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectorShapeDrawingProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawing.NonVisualConnectorShapeDrawingPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.ShapeProperties? ShapeProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawing.ShapePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawing.ShapePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Connection Shape Style.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.Style? Style
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Style>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawing.StyleImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Style>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawing.StyleImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
