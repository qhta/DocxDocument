namespace DocumentModel.Drawings.ChartDrawing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Connection IShape.
/// </summary>
public class ConnectionShape: ModelElement
{
  /// <summary>
  ///   Reference Ito Custom Function
  /// </summary>
  public string? Macro { get; set; }

  /// <summary>
  ///   Publish Ito Server
  /// </summary>
  public bool? Published { get; set; }

  /// <summary>
  ///   Connector Non Visual Properties.
  /// </summary>
  public NonVisualConnectorShapeDrawingProperties? NonVisualConnectorShapeDrawingProperties { get; set; }

  /// <summary>
  ///   IShape Properties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   Connection IShape IStyle.
  /// </summary>
  public IStyle? IStyle { get; set; }
}
