namespace DocumentModel.Drawings.ChartDrawing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Graphic Frame.
/// </summary>
public class GraphicFrame: ModelElement
{
  /// <summary>
  ///   Reference to Custom Function
  /// </summary>
  public string? Macro { get; set; }

  /// <summary>
  ///   Publish To Server
  /// </summary>
  public bool? Published { get; set; }

  /// <summary>
  ///   Non-Visual Graphic Frame Properties.
  /// </summary>
  public NonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties { get; set; }

  /// <summary>
  ///   Graphic Frame Transform.
  /// </summary>
  public Transform? Transform { get; set; }

  /// <summary>
  ///   Graphical Object.
  /// </summary>
  public Graphic? Graphic { get; set; }
}