namespace DocumentModel.Drawings.Charts;

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
  public DocumentModel.Drawings.Charts.NonVisualGroupShapeProperties? NonVisualGroupShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Group Shape Properties.
  /// </summary>
  public DocumentModel.Drawings.Charts.GroupShapeProperties? GroupShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Charts.Shape? Shape
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Charts.GroupShape? ChildGroupShape
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Charts.GraphicFrame? GraphicFrame
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Charts.ConnectionShape? ConnectionShape
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Charts.Picture? Picture
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
