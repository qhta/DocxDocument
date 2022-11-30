namespace DocumentModel.Office2010.Drawing.ChartDrawing;

/// <summary>
/// Defines the NonVisualDrawingProperties Class.
/// </summary>
public interface INonVisualDrawingProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Application defined unique identifier.
  /// </summary>
  public System.UInt32? Id { get ; set; }
  
  /// <summary>
  /// Name compatible with Object Model (non-unique).
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Description of the drawing element.
  /// </summary>
  public System.String? Description { get ; set; }
  
  /// <summary>
  /// Flag determining to show or hide this element.
  /// </summary>
  public System.Boolean? Hidden { get ; set; }
  
  /// <summary>
  /// Title
  /// </summary>
  public System.String? Title { get ; set; }
  
  /// <summary>
  /// Hyperlink associated with clicking or selecting the element..
  /// </summary>
  public DocumentModel.Drawing.IHyperlinkOnClick? HyperlinkOnClick { get ; set; }
  
  /// <summary>
  /// Hyperlink associated with hovering over the element..
  /// </summary>
  public DocumentModel.Drawing.IHyperlinkOnHover? HyperlinkOnHover { get ; set; }
  
  /// <summary>
  /// Future extension.
  /// </summary>
  public DocumentModel.Drawing.INonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList { get ; set; }
  
}
