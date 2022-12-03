namespace DocumentModel.Spreadsheet.Drawings;

/// <summary>
/// Non-Visual Graphic Frame Drawing Properties.
/// </summary>
public interface NonVisualGraphicFrameDrawingProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Graphic Frame Locks.
  /// </summary>
  public DocumentModel.Drawings.GraphicFrameLocks? GraphicFrameLocks { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get ; set; }
  
}
