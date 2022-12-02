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
  
  public DocumentModel.Drawing.ILineSketchStyleProperties? LineSketchStyleProperties { get ; set; }
  
}
