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
  
  /// <summary>
  /// GroupShapeNonVisualProperties.
  /// </summary>
  public virtual GroupShapeNonVisualProperties? GroupShapeNonVisualProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// GroupShapeProperties.
  /// </summary>
  public virtual GroupShapeProperties1? GroupShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
