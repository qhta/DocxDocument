namespace DocumentModel.Spreadsheet.Drawings;

/// <summary>
/// Non-Visual Properties for a Graphic Frame.
/// </summary>
public interface NonVisualGraphicFrameProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Connection Non-Visual Properties.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Graphic Frame Drawing Properties.
  /// </summary>
  public NonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties { get ; set; }
  
}
