namespace DocumentModel.Spreadsheet.Drawings;

/// <summary>
/// Non-Visual Properties for a Group Shape.
/// </summary>
public interface NonVisualGroupShapeProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Connection Non-Visual Properties.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Group Shape Drawing Properties.
  /// </summary>
  public NonVisualGroupShapeDrawingProperties? NonVisualGroupShapeDrawingProperties { get ; set; }
  
}
