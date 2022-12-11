namespace DocumentModel.Drawings;

/// <summary>
/// Group Shape.
/// </summary>
public class GroupShapeImpl: ModelElementImpl, GroupShape
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GroupShapeImpl(): base() {}
  
  public GroupShapeImpl(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Non-Visual Group Shape Properties.
  /// </summary>
  public NonVisualGroupShapeProperties? NonVisualGroupShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Group Shape Properties.
  /// </summary>
  public GroupShapeProperties? GroupShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Shape? Shape
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public GroupShape? ChildGroupShape
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public GraphicFrame? GraphicFrame
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public ConnectionShape? ConnectionShape
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Picture? Picture
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
