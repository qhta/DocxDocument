namespace DocumentModel.Spreadsheet.Drawings;

/// <summary>
/// Non-Visual Properties for a Connection Shape.
/// </summary>
public interface NonVisualConnectionShapeProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Connection Non-Visual Properties.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Connector Shape Drawing Properties.
  /// </summary>
  public NonVisualConnectorShapeDrawingProperties? NonVisualConnectorShapeDrawingProperties { get ; set; }
  
}
