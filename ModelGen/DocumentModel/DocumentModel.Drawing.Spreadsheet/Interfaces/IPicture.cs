namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Defines the Picture Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IBlipFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IShapeStyle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.INonVisualPictureProperties))]
public interface IPicture // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
  /// Non-Visual Properties for a Picture.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.INonVisualPictureProperties? NonVisualPictureProperties { get ; set; }
  
  /// <summary>
  /// Picture Fill.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.IBlipFill? BlipFill { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.IShapeStyle? ShapeStyle { get ; set; }
  
}
