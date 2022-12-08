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
    get;
    set;
  }
  
  /// <summary>
  /// GroupShapeProperties.
  /// </summary>
  public virtual GroupShapeProperties2? GroupShapeProperties
  {
    get;
    set;
  }
  
}
