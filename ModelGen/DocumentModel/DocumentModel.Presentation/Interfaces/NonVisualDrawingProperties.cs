namespace DocumentModel.Presentation;

/// <summary>
/// Defines the NonVisualDrawingProperties Class.
/// </summary>
public interface NonVisualDrawingProperties // : DocumentModel.BaseTypes.ModelElement
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
  public DocumentModel.Drawings.HyperlinkOnClick? HyperlinkOnClick { get ; set; }
  
  /// <summary>
  /// Hyperlink associated with hovering over the element..
  /// </summary>
  public DocumentModel.Drawings.HyperlinkOnHover? HyperlinkOnHover { get ; set; }
  
  /// <summary>
  /// Future extension.
  /// </summary>
  public DocumentModel.Drawings.NonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList { get ; set; }
  
}
