namespace DocumentModel.Presentation;

/// <summary>
/// Non-Visual Properties for a Connection Shape.
/// </summary>
public interface NonVisualConnectionShapeProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Non-Visual Drawing Properties.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Connector Shape Drawing Properties.
  /// </summary>
  public NonVisualConnectorShapeDrawingProperties? NonVisualConnectorShapeDrawingProperties { get ; set; }
  
  /// <summary>
  /// Application Non-Visual Drawing Properties.
  /// </summary>
  public ApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties { get ; set; }
  
}
