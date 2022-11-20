namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Graphic Frame.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IGraphic))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.ITransform))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.INonVisualGraphicFrameProperties))]
public interface IGraphicFrame // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Reference To Custom Function
  /// </summary>
  public string? Macro { get ; set; }
  
  /// <summary>
  /// Publish to Server Flag
  /// </summary>
  public bool? Published { get ; set; }
  
  /// <summary>
  /// Non-Visual Properties for a Graphic Frame.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.INonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties { get ; set; }
  
  /// <summary>
  /// 2D Transform for Graphic Frames.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.ITransform? Transform { get ; set; }
  
  /// <summary>
  /// Graphic.
  /// </summary>
  public IGraphic? Graphic { get ; set; }
  
}
