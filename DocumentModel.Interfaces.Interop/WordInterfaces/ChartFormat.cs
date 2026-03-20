namespace DocumentModel.Interop;

/// <summary>
/// Provides access to the Office Art formatting for chart elements.
/// </summary>
public interface ChartFormat : InteropObject
{
  /// <summary>
  /// The fill.
  /// </summary>
  public FillFormat Fill { get; }
  /// <summary>
  /// The glow.
  /// </summary>
  public GlowFormat Glow { get; }
  /// <summary>
  /// The line.
  /// </summary>
  public LineFormat Line { get; }
  /// <summary>
  /// The picture format.
  /// </summary>
  public PictureFormat PictureFormat { get; }
  /// <summary>
  /// The shadow.
  /// </summary>
  public ShadowFormat Shadow { get; }
  /// <summary>
  /// The soft edge.
  /// </summary>
  public SoftEdgeFormat SoftEdge { get; }
  /// <summary>
  /// The text frame2.
  /// </summary>
  //public Core.TextFrame2 TextFrame2 { get; }
  /// <summary>
  /// The three d.
  /// </summary>
  public ThreeDFormat ThreeD { get; }
  /// <summary>
  /// The adjustments.
  /// </summary>
  public Adjustments Adjustments { get; }
  /// <summary>
  /// The auto shape type.
  /// </summary>
  //public Core.MsoAutoShapeType AutoShapeType { get; set; }

}
