namespace DocumentModel.Vml;

/// <summary>
///   VML Diagram.
/// </summary>
public class Diagram: ModelElement
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }
  /// <summary>
  ///   Diagram Style Options
  /// </summary>
  public Int64? Style { get; set; }
  /// <summary>
  ///   Diagram Automatic Format
  /// </summary>
  public bool? AutoFormat { get; set; }
  /// <summary>
  ///   Diagram Reverse Direction
  /// </summary>
  public bool? Reverse { get; set; }
  /// <summary>
  ///   Diagram Automatic Layout
  /// </summary>
  public bool? AutoLayout { get; set; }
  /// <summary>
  ///   Diagram Layout X Scale
  /// </summary>
  public Int64? ScaleX { get; set; }
  /// <summary>
  ///   Diagram Layout Y Scale
  /// </summary>
  public Int64? ScaleY { get; set; }
  /// <summary>
  ///   Diagram Font Size
  /// </summary>
  public Int64? FontSize { get; set; }
  /// <summary>
  ///   Diagram Layout Extents
  /// </summary>
  public string? ConstrainBounds { get; set; }
  /// <summary>
  ///   Diagram Base Font Size
  /// </summary>
  public Int64? BaseTextScale { get; set; }
  /// <summary>
  ///   Diagram Relationship Table.
  /// </summary>
  public RelationTable? RelationTable { get; set; }
}