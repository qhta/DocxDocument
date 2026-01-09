namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Describes a group shape in chart drawings, including non-visual and visual properties, contained shapes, child groups, graphic frames, connections, and pictures.
/// </summary>
public interface GroupShape
{
  /// <summary>
  /// Non-visual properties for the group shape, such as identifiers, names, and metadata.
  /// </summary>
  public NonVisualGroupShapeProperties? NonVisualGroupShapeProperties { get; set; }

  /// <summary>
  /// Visual properties and formatting for the group shape.
  /// </summary>
  public GroupShapeProperties? GroupShapeProperties { get; set; }

  /// <summary>
  /// Shape element contained within the group.
  /// </summary>
  public Shape? Shape { get; set; }

  /// <summary>
  /// Child group shape element for nested grouping.
  /// </summary>
  public GroupShape? ChildGroupShape { get; set; }

  /// <summary>
  /// Graphic frame element contained within the group.
  /// </summary>
  public GraphicFrame? GraphicFrame { get; set; }

  /// <summary>
  /// Connection shape element contained within the group.
  /// </summary>
  public ConnectionShape? ConnectionShape { get; set; }

  /// <summary>
  /// Picture element contained within the group.
  /// </summary>
  public Picture? Picture { get; set; }
}