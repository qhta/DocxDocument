namespace DocumentModel.Vml.Office;

/// <summary>
/// VML Diagram.
/// </summary>
public interface IDiagram // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorValues? Extension { get ; set; }
  
  /// <summary>
  /// Diagram Style Options
  /// </summary>
  public Int32? Style { get ; set; }
  
  /// <summary>
  /// Diagram Automatic Format
  /// </summary>
  public ITrueFalseValue? AutoFormat { get ; set; }
  
  /// <summary>
  /// Diagram Reverse Direction
  /// </summary>
  public ITrueFalseValue? Reverse { get ; set; }
  
  /// <summary>
  /// Diagram Automatic Layout
  /// </summary>
  public ITrueFalseValue? AutoLayout { get ; set; }
  
  /// <summary>
  /// Diagram Layout X Scale
  /// </summary>
  public Int32? ScaleX { get ; set; }
  
  /// <summary>
  /// Diagram Layout Y Scale
  /// </summary>
  public Int32? ScaleY { get ; set; }
  
  /// <summary>
  /// Diagram Font Size
  /// </summary>
  public Int32? FontSize { get ; set; }
  
  /// <summary>
  /// Diagram Layout Extents
  /// </summary>
  public String? ConstrainBounds { get ; set; }
  
  /// <summary>
  /// Diagram Base Font Size
  /// </summary>
  public Int32? BaseTextScale { get ; set; }
  
  /// <summary>
  /// Diagram Relationship Table.
  /// </summary>
  public IRelationTable? RelationTable { get ; set; }
  
}
