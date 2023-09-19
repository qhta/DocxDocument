namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Drawing Object Non-Visual Properties.
/// </summary>
public partial class DocProperties
{
  
  /// <summary>
  ///   Application defined unique identifier.
  /// </summary>
  [SchemaAttr("id")]
  public UInt32? Id { get; set; }
  
  
  /// <summary>
  ///   Name compatible with Object Model (non-unique).
  /// </summary>
  [SchemaAttr("name")]
  public String? Name { get; set; }
  
  
  /// <summary>
  ///   Description of the drawing element.
  /// </summary>
  [SchemaAttr("descr")]
  public String? Description { get; set; }
  
  
  /// <summary>
  ///   Flag determining to show or hide this element.
  /// </summary>
  [SchemaAttr("hidden")]
  public Boolean? Hidden { get; set; }
  
  
  /// <summary>
  ///   Title
  /// </summary>
  [SchemaAttr("title")]
  public String? Title { get; set; }
  
  
  /// <summary>
  ///   Hyperlink associated with clicking or selecting the element..
  /// </summary>
  public DocumentModel.Drawings.HyperlinkOnClick? HyperlinkOnClick { get; set; }
  
  
  /// <summary>
  ///   Hyperlink associated with hovering over the element..
  /// </summary>
  public DocumentModel.Drawings.HyperlinkOnHover? HyperlinkOnHover { get; set; }
  
  
  /// <summary>
  ///   Future extension.
  /// </summary>
  public DocumentModel.Drawings.NonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList { get; set; }
  
}
