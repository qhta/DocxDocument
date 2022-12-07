namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GroupShapeType Class.
/// </summary>
public class GroupShapeTypeImpl: ModelElement<DocumentFormat.OpenXml.Office.Drawing.GroupShapeType>, GroupShapeType
{
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
  public virtual GroupShapeProperties1? GroupShapeProperties
  {
    get;
    set;
  }
  
}
