namespace DocumentModel.Spreadsheet.Drawings;

/// <summary>
/// Graphic Frame.
/// </summary>
public interface GraphicFrame // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Reference To Custom Function
  /// </summary>
  public String? Macro { get ; set; }
  
  /// <summary>
  /// Publish to Server Flag
  /// </summary>
  public Boolean? Published { get ; set; }
  
  /// <summary>
  /// Non-Visual Properties for a Graphic Frame.
  /// </summary>
  public NonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties { get ; set; }
  
  /// <summary>
  /// 2D Transform for Graphic Frames.
  /// </summary>
  public Transform? Transform { get ; set; }
  
  /// <summary>
  /// Graphic.
  /// </summary>
  public DocumentModel.Drawings.Graphic? Graphic { get ; set; }
  
}
