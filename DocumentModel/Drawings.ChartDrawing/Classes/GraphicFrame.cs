namespace DocumentModel.Drawings.ChartDrawing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Graphic IFrame.
/// </summary>
public class GraphicFrame: ModelElement
{
  /// <summary>
  ///   Reference Ito Custom Function
  /// </summary>
  public string? Macro { get; set; }

  /// <summary>
  ///   Publish To Server
  /// </summary>
  public bool? Published { get; set; }

  /// <summary>
  ///   Non-Visual Graphic IFrame Properties.
  /// </summary>
  public NonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties { get; set; }

  /// <summary>
  ///   Graphic IFrame Transform.
  /// </summary>
  public Transform? Transform { get; set; }

  /// <summary>
  ///   Graphical Object.
  /// </summary>
  public Graphic? Graphic { get; set; }
}
