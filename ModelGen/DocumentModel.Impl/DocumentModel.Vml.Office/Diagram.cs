namespace DocumentModel.Vml.Office;

/// <summary>
/// VML Diagram.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Vml.Office.IRelationTable))]
public class Diagram: IDiagram
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorValues? Extension
  {
    get;
    set;
  }
  
  /// <summary>
  /// Diagram Style Options
  /// </summary>
  public int? Style
  {
    get;
    set;
  }
  
  /// <summary>
  /// Diagram Automatic Format
  /// </summary>
  public ITrueFalseValue? AutoFormat
  {
    get;
    set;
  }
  
  /// <summary>
  /// Diagram Reverse Direction
  /// </summary>
  public ITrueFalseValue? Reverse
  {
    get;
    set;
  }
  
  /// <summary>
  /// Diagram Automatic Layout
  /// </summary>
  public ITrueFalseValue? AutoLayout
  {
    get;
    set;
  }
  
  /// <summary>
  /// Diagram Layout X Scale
  /// </summary>
  public int? ScaleX
  {
    get;
    set;
  }
  
  /// <summary>
  /// Diagram Layout Y Scale
  /// </summary>
  public int? ScaleY
  {
    get;
    set;
  }
  
  /// <summary>
  /// Diagram Font Size
  /// </summary>
  public int? FontSize
  {
    get;
    set;
  }
  
  /// <summary>
  /// Diagram Layout Extents
  /// </summary>
  public string? ConstrainBounds
  {
    get;
    set;
  }
  
  /// <summary>
  /// Diagram Base Font Size
  /// </summary>
  public int? BaseTextScale
  {
    get;
    set;
  }
  
  /// <summary>
  /// Diagram Relationship Table.
  /// </summary>
  public IRelationTable? RelationTable
  {
    get;
    set;
  }
  
}
