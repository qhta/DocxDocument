namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Drawing Object Non-Visual Properties.
/// </summary>
public partial class DocProperties
{
  
  /// <summary>
  ///   Application defined unique identifier.
  /// </summary>
  public HexInt? Id { get; set; }
  
  
  /// <summary>
  ///   Name compatible with Object Model (non-unique).
  /// </summary>
  public String? Name { get; set; }
  
  
  /// <summary>
  ///   Description of the drawing element.
  /// </summary>
  public String? Description { get; set; }
  
  
  /// <summary>
  ///   Flag determining to show or hide this element.
  /// </summary>
  public Boolean? Hidden { get; set; }
  
  
  /// <summary>
  ///   Title
  /// </summary>
  public String? Title { get; set; }
  
  
  /// <summary>
  ///   Hyperlink associated with clicking or selecting the element..
  /// </summary>
  public HyperlinkOnClick? HyperlinkOnClick { get; set; }
  
  
  /// <summary>
  ///   Hyperlink associated with hovering over the element..
  /// </summary>
  public HyperlinkOnHover? HyperlinkOnHover { get; set; }
  
  
  /// <summary>
  ///   Future extension.
  /// </summary>
  public NonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList { get; set; }
  
}
