namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Non-Visual Shape Drawing Properties.
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
  public IShapeLocks? ShapeLocks { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
