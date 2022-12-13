namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GroupShapeType Class.
/// </summary>
public class GroupShapeTypeImpl: ModelElementImpl, GroupShapeType
{
  public DocumentFormat.OpenXml.Office.Drawing.GroupShapeType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Drawing.GroupShapeType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GroupShapeTypeImpl(): base() {}
  
  public GroupShapeTypeImpl(DocumentFormat.OpenXml.Office.Drawing.GroupShapeType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// GroupShapeNonVisualProperties.
  /// </summary>
  public virtual DocumentModel.Drawings.GroupShapeNonVisualProperties? GroupShapeNonVisualProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// GroupShapeProperties.
  /// </summary>
  public virtual DocumentModel.Drawings.GroupShapeProperties? GroupShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
