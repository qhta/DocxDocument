namespace DocumentModel.Spreadsheet.Drawing;

/// <summary>
/// Connection Non-Visual Shape Properties.
/// </summary>
public interface INonVisualShapeDrawingProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Text Box
  /// </summary>
  public Boolean? TextBox { get ; set; }
  
  /// <summary>
  /// Shape Locks.
  /// </summary>
  public DocumentModel.Drawing.IShapeLocks? ShapeLocks { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
