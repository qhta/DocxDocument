namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GroupShapeType Class.
/// </summary>
public class GroupShapeType
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
