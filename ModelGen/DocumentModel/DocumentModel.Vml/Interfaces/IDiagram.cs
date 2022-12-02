namespace DocumentModel.Vml;

/// <summary>
/// VML Diagram.
/// </summary>
public interface IDiagram // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
  /// <summary>
  /// Diagram Style Options
  /// </summary>
  public System.Int32? Style { get ; set; }
  
  /// <summary>
  /// Diagram Automatic Format
  /// </summary>
  public System.Boolean? AutoFormat { get ; set; }
  
  /// <summary>
  /// Diagram Reverse Direction
  /// </summary>
  public System.Boolean? Reverse { get ; set; }
  
  /// <summary>
  /// Diagram Automatic Layout
  /// </summary>
  public System.Boolean? AutoLayout { get ; set; }
  
  /// <summary>
  /// Diagram Layout X Scale
  /// </summary>
  public System.Int32? ScaleX { get ; set; }
  
  /// <summary>
  /// Diagram Layout Y Scale
  /// </summary>
  public System.Int32? ScaleY { get ; set; }
  
  /// <summary>
  /// Diagram Font Size
  /// </summary>
  public System.Int32? FontSize { get ; set; }
  
  /// <summary>
  /// Diagram Layout Extents
  /// </summary>
  public System.String? ConstrainBounds { get ; set; }
  
  /// <summary>
  /// Diagram Base Font Size
  /// </summary>
  public System.Int32? BaseTextScale { get ; set; }
  
  /// <summary>
  /// Diagram Relationship Table.
  /// </summary>
  public DocumentModel.Vml.IRelationTable? RelationTable { get ; set; }
  
}
