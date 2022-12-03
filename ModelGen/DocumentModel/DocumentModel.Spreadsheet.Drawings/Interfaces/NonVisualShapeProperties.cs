namespace DocumentModel.Spreadsheet.Drawings;

/// <summary>
/// Non-Visual Properties for a Shape.
/// </summary>
public interface NonVisualShapeProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Non-Visual Drawing Properties.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Connection Non-Visual Shape Properties.
  /// </summary>
  public NonVisualShapeDrawingProperties? NonVisualShapeDrawingProperties { get ; set; }
  
}
