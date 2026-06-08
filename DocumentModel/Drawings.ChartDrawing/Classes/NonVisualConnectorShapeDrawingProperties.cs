namespace DocumentModel.Drawings.ChartDrawing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Connector Non Visual Properties.
/// </summary>
public class NonVisualConnectorShapeDrawingProperties: ModelElement
{
  /// <summary>
  ///   IChart Non Visual Properties.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }

  /// <summary>
  ///   Non-Visual Connection IShape Drawing Properties.
  /// </summary>
  public NonVisualConnectionShapeProperties? NonVisualConnectionShapeProperties { get; set; }
}
