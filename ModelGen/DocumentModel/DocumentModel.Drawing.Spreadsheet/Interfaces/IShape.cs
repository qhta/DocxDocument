namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Shape.
/// </summary>
public interface IShape // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public System.String? Macro { get ; set; }
  
  /// <summary>
  /// Text Link
  /// </summary>
  public System.String? TextLink { get ; set; }
  
  /// <summary>
  /// Lock Text Flag
  /// </summary>
  public System.Boolean? LockText { get ; set; }
  
  /// <summary>
  /// Publish to Server Flag
  /// </summary>
  public System.Boolean? Published { get ; set; }
  
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
