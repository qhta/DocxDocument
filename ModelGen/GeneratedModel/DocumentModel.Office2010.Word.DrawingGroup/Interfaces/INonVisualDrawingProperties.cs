namespace DocumentModel.Office2010.Word.DrawingGroup;

/// <summary>
/// Defines the NonVisualDrawingProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IHyperlinkOnClick))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IHyperlinkOnHover))]
[ChildElementInfo(typeof(DocumentModel.Drawing.INonVisualDrawingPropertiesExtensionList))]
public interface INonVisualDrawingProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Application defined unique identifier.
  /// </summary>
  public uint? Id { get ; set; }
  
  /// <summary>
  /// Name compatible with Object Model (non-unique).
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// Description of the drawing element.
  /// </summary>
  public string? Description { get ; set; }
  
  /// <summary>
  /// Flag determining to show or hide this element.
  /// </summary>
  public bool? Hidden { get ; set; }
  
  /// <summary>
  /// Title
  /// </summary>
  public string? Title { get ; set; }
  
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
