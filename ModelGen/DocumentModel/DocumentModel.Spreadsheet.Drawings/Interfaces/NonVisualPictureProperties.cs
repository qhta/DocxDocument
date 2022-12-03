namespace DocumentModel.Spreadsheet.Drawings;

/// <summary>
/// Non-Visual Properties for a Picture.
/// </summary>
public interface NonVisualPictureProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Picture Drawing Properties.
  /// </summary>
  public NonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties { get ; set; }
  
}
