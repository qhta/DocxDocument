namespace DocumentModel.Vml;

/// <summary>
///   VML Diagram.
/// </summary>
public record Diagram
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
  public Boolean? AutoFormat { get; set; }

  /// <summary>
  ///   Diagram Reverse Direction
  /// </summary>
  public Boolean? Reverse { get; set; }

  /// <summary>
  ///   Diagram Automatic Layout
  /// </summary>
  public Boolean? AutoLayout { get; set; }

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
  public String? ConstrainBounds { get; set; }

  /// <summary>
  ///   Diagram Base Font Size
  /// </summary>
  public Int64? BaseTextScale { get; set; }

  /// <summary>
  ///   Diagram Relationship Table.
  /// </summary>
  public RelationTable? RelationTable { get; set; }
}