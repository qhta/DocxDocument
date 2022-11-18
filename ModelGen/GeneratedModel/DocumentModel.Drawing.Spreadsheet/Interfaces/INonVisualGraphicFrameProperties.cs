namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Non-Visual Properties for a Graphic Frame.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.INonVisualGraphicFrameDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.INonVisualDrawingProperties))]
public interface INonVisualGraphicFrameProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Connection Non-Visual Properties.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Graphic Frame Drawing Properties.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.INonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties { get ; set; }
  
}
