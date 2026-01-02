using DocumentModel.Drawings;
namespace DocumentModel.Wordprocessing.DrawingGroup;

/// <summary>
///   Defines the NonVisualDrawingProperties Class.
/// </summary>
public class NonVisualDrawingProperties: ModelElement
{
  /// <summary>
  ///   Application defined unique identifier.
  /// </summary>
  public UInt32? Id { get; set; }
  /// <summary>
  ///   Name compatible with Object Model (non-unique).
  /// </summary>
  public string? Name { get; set; }
  /// <summary>
  ///   Description of the drawing element.
  /// </summary>
  public string? Description { get; set; }
  /// <summary>
  ///   Flag determining to show or hide this element.
  /// </summary>
  public bool? Hidden { get; set; }
  /// <summary>
  ///   Title
  /// </summary>
  public string? Title { get; set; }
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