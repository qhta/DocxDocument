namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Connector Non Visual Properties.
/// </summary>
public interface NonVisualConnectorShapeDrawingProperties
{
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  public DocumentModel.Drawings.Charts.NonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Connection Shape Drawing Properties.
  /// </summary>
  public DocumentModel.Drawings.Charts.NonVisualConnectionShapeProperties? NonVisualConnectionShapeProperties { get ; set; }
  
}
