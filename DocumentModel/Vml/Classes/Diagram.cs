namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   VML IDiagram.
/// </summary>
public class IDiagram: ModelElement
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }

  /// <summary>
  ///   IDiagram IStyle IOptions
  /// </summary>
  public Int64? IStyle { get; set; }

  /// <summary>
  ///   IDiagram Automatic Format
  /// </summary>
  public bool? AutoFormat { get; set; }

  /// <summary>
  ///   IDiagram Reverse Direction
  /// </summary>
  public bool? Reverse { get; set; }

  /// <summary>
  ///   IDiagram Automatic Layout
  /// </summary>
  public bool? AutoLayout { get; set; }

  /// <summary>
  ///   IDiagram Layout X Scale
  /// </summary>
  public Int64? ScaleX { get; set; }

  /// <summary>
  ///   IDiagram Layout Y Scale
  /// </summary>
  public Int64? ScaleY { get; set; }

  /// <summary>
  ///   IDiagram IFont Size
  /// </summary>
  public Int64? FontSize { get; set; }

  /// <summary>
  ///   IDiagram Layout Extents
  /// </summary>
  public string? ConstrainBounds { get; set; }

  /// <summary>
  ///   IDiagram Base IFont Size
  /// </summary>
  public Int64? BaseTextScale { get; set; }

  /// <summary>
  ///   IDiagram Relationship ITable.
  /// </summary>
  public RelationTable? RelationTable { get; set; }
}
