namespace DocumentModel.Drawings;

/// <summary>
/// Connector Non Visual Properties.
/// </summary>
public interface NonVisualConnectorShapeDrawingProperties
{
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  public NonVisualDrawingProperties3? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Connection Shape Drawing Properties.
  /// </summary>
  public NonVisualConnectionShapeProperties? NonVisualConnectionShapeProperties { get ; set; }
  
}
