namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Shape.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IShapeStyle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.ITextBody))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.INonVisualShapeProperties))]
public interface IShape // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public string? Macro { get ; set; }
  
  /// <summary>
  /// Text Link
  /// </summary>
  public string? TextLink { get ; set; }
  
  /// <summary>
  /// Lock Text Flag
  /// </summary>
  public bool? LockText { get ; set; }
  
  /// <summary>
  /// Publish to Server Flag
  /// </summary>
  public bool? Published { get ; set; }
  
  /// <summary>
  /// Non-Visual Properties for a Shape.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.INonVisualShapeProperties? NonVisualShapeProperties { get ; set; }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.IShapeStyle? ShapeStyle { get ; set; }
  
  /// <summary>
  /// Shape Text Body.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.ITextBody? TextBody { get ; set; }
  
}
