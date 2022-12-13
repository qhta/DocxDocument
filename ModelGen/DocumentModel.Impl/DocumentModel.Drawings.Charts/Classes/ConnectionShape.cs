namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Connection Shape.
/// </summary>
public class ConnectionShapeImpl: ModelElementImpl, ConnectionShape
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
  public DocumentModel.Drawings.Charts.NonVisualConnectorShapeDrawingProperties? NonVisualConnectorShapeDrawingProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Connection Shape Style.
  /// </summary>
  public DocumentModel.Drawings.Charts.Style? Style
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
