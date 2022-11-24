namespace DocumentModel.Office2016.Drawing.Command;

/// <summary>
/// Defines the NonVisualDrawingProps Class.
/// </summary>
public interface INonVisualDrawingProps // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Application defined unique identifier.
  /// </summary>
  public UInt32? Id { get ; set; }
  
  /// <summary>
  /// Name compatible with Object Model (non-unique).
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Description of the drawing element.
  /// </summary>
  public String? Description { get ; set; }
  
  /// <summary>
  /// Flag determining to show or hide this element.
  /// </summary>
  public Boolean? Hidden { get ; set; }
  
  /// <summary>
  /// Title
  /// </summary>
  public String? Title { get ; set; }
  
  /// <summary>
  /// Hyperlink associated with clicking or selecting the element..
  /// </summary>
  public IHyperlinkOnClick? HyperlinkOnClick { get ; set; }
  
  /// <summary>
  /// Hyperlink associated with hovering over the element..
  /// </summary>
  public IHyperlinkOnHover? HyperlinkOnHover { get ; set; }
  
  /// <summary>
  /// Future extension.
  /// </summary>
  public INonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList { get ; set; }
  
}
