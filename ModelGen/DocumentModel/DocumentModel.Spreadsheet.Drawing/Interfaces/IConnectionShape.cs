namespace DocumentModel.Spreadsheet.Drawing;

/// <summary>
/// Connection Shape.
/// </summary>
public interface IConnectionShape // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public System.String? Macro { get ; set; }
  
  /// <summary>
  /// Publish to Server Flag
  /// </summary>
  public System.Boolean? Published { get ; set; }
  
  /// <summary>
  /// Non-Visual Properties for a Connection Shape.
  /// </summary>
  public DocumentModel.Spreadsheet.Drawing.INonVisualConnectionShapeProperties? NonVisualConnectionShapeProperties { get ; set; }
  
  /// <summary>
  /// Connector Shape Properties.
  /// </summary>
  public DocumentModel.Spreadsheet.Drawing.IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  public DocumentModel.Spreadsheet.Drawing.IShapeStyle? ShapeStyle { get ; set; }
  
}
