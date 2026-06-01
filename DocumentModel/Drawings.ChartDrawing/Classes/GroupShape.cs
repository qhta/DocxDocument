namespace DocumentModel.Drawings.ChartDrawing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Group IShape.
/// </summary>
public class GroupShape: ModelElement
{
  /// <summary>
  ///   Non-Visual Group IShape Properties.
  /// </summary>
  public NonVisualGroupShapeProperties? NonVisualGroupShapeProperties { get; set; }

  /// <summary>
  ///   Group IShape Properties.
  /// </summary>
  public GroupShapeProperties? GroupShapeProperties { get; set; }

  public IShape? IShape { get; set; }

  public GroupShape? ChildGroupShape { get; set; }

  public GraphicFrame? GraphicFrame { get; set; }

  public ConnectionShape? ConnectionShape { get; set; }

  public Picture? Picture { get; set; }
}
