namespace DocumentModel.Drawings.ChartDrawing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Group Shape.
/// </summary>
public class GroupShape: ModelElement
{
  /// <summary>
  ///   Non-Visual Group Shape Properties.
  /// </summary>
  public NonVisualGroupShapeProperties? NonVisualGroupShapeProperties { get; set; }

  /// <summary>
  ///   Group Shape Properties.
  /// </summary>
  public GroupShapeProperties? GroupShapeProperties { get; set; }

  public Shape? Shape { get; set; }

  public GroupShape? ChildGroupShape { get; set; }

  public GraphicFrame? GraphicFrame { get; set; }

  public ConnectionShape? ConnectionShape { get; set; }

  public Picture? Picture { get; set; }
}