namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Defines the NonVisualDrawingProperties Class.
/// </summary>
public partial class NonVisualDrawingProperties
{
  
  /// <summary>
  ///   Application defined unique identifier.
  /// </summary>
  public UInt32? Id { get; set; }
  
  
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
  public DMD.HyperlinkOnClick? HyperlinkOnClick { get; set; }
  
  
  /// <summary>
  ///   Hyperlink associated with hovering over the element..
  /// </summary>
  public DMD.HyperlinkOnHover? HyperlinkOnHover { get; set; }
  
  
  /// <summary>
  ///   Future extension.
  /// </summary>
  public DMD.NonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList { get; set; }
  
}
