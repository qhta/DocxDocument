namespace DocumentModel.Presentation;

/// <summary>
/// Non-Visual Properties for a Connection Shape.
/// </summary>
public interface INonVisualConnectionShapeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Non-Visual Drawing Properties.
  /// </summary>
  public INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Connector Shape Drawing Properties.
  /// </summary>
  public INonVisualConnectorShapeDrawingProperties? NonVisualConnectorShapeDrawingProperties { get ; set; }
  
  /// <summary>
  /// Application Non-Visual Drawing Properties.
  /// </summary>
  public IApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties { get ; set; }
  
}
