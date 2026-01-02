namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
///   Shape Definition.
/// </summary>
public class Shape: ModelElement
{
  /// <summary>
  ///   Reference to Custom Function
  /// </summary>
  public string? Macro { get; set; }
  /// <summary>
  ///   Text Link
  /// </summary>
  public string? TextLink { get; set; }
  /// <summary>
  ///   Lock Text
  /// </summary>
  public bool? LockText { get; set; }
  /// <summary>
  ///   Publish to Server
  /// </summary>
  public bool? Published { get; set; }
  /// <summary>
  ///   Non-Visual Shape Properties.
  /// </summary>
  public NonVisualShapeProperties? NonVisualShapeProperties { get; set; }
  /// <summary>
  ///   Shape Properties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }
  /// <summary>
  ///   Shape Style.
  /// </summary>
  public Style? Style { get; set; }
  /// <summary>
  ///   Shape Text Body.
  /// </summary>
  public TextBody? TextBody { get; set; }
}