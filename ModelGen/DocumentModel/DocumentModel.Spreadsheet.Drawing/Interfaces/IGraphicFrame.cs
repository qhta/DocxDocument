namespace DocumentModel.Spreadsheet.Drawing;

/// <summary>
/// Graphic Frame.
/// </summary>
public interface IGraphicFrame // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Reference To Custom Function
  /// </summary>
  public System.String? Macro { get ; set; }
  
  /// <summary>
  /// Publish to Server Flag
  /// </summary>
  public System.Boolean? Published { get ; set; }
  
  /// <summary>
  /// Non-Visual Properties for a Graphic Frame.
  /// </summary>
  public DocumentModel.Spreadsheet.Drawing.INonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties { get ; set; }
  
  /// <summary>
  /// 2D Transform for Graphic Frames.
  /// </summary>
  public DocumentModel.Spreadsheet.Drawing.ITransform? Transform { get ; set; }
  
  /// <summary>
  /// Graphic.
  /// </summary>
  public DocumentModel.Drawing.IGraphic? Graphic { get ; set; }
  
}
