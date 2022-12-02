namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NonVisualGroupDrawingShapePropsExtension Class.
/// </summary>
public interface INonVisualGroupDrawingShapePropsExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.INonVisualGroupProperties? NonVisualGroupProperties { get ; set; }
  
}
