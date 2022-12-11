namespace DocumentModel.Drawings;

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
    get => (String?)OpenXmlElement?.Macro?.Value;
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
    get => (Boolean?)OpenXmlElement?.Published?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Published = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Non-Visual Graphic Frame Properties.
  /// </summary>
  public NonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Graphic Frame Transform.
  /// </summary>
  public Transform? Transform
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Graphical Object.
  /// </summary>
  public Graphic? Graphic
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
