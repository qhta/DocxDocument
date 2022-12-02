namespace DocumentModel.Spreadsheet.Drawing;

/// <summary>
/// Graphic Frame.
/// </summary>
public interface IGraphicFrame // : DocumentModel.ITypedOpenXmlCompositeElement
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
  public INonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties { get ; set; }
  
  /// <summary>
  /// 2D Transform for Graphic Frames.
  /// </summary>
  public ITransform? Transform { get ; set; }
  
  /// <summary>
  /// Graphic.
  /// </summary>
  public DocumentModel.Drawing.IGraphic? Graphic { get ; set; }
  
}
