namespace DocumentModel.Drawing;

/// <summary>
/// Defines the LinePropertiesExtension Class.
/// </summary>
public interface ILinePropertiesExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2021.Drawing.SketchyShapes.ILineSketchStyleProperties? LineSketchStyleProperties { get ; set; }
  
}
