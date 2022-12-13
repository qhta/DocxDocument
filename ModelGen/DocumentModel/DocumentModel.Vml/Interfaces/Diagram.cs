namespace DocumentModel.Vml;

/// <summary>
/// VML Diagram.
/// </summary>
public interface Diagram
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
  /// <summary>
  /// Diagram Style Options
  /// </summary>
  public Int32? Style { get ; set; }
  
  /// <summary>
  /// Diagram Automatic Format
  /// </summary>
  public Boolean? AutoFormat { get ; set; }
  
  /// <summary>
  /// Diagram Reverse Direction
  /// </summary>
  public Boolean? Reverse { get ; set; }
  
  /// <summary>
  /// Diagram Automatic Layout
  /// </summary>
  public Boolean? AutoLayout { get ; set; }
  
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
  public DocumentModel.Vml.RelationTable? RelationTable { get ; set; }
  
}
