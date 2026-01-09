namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Describes non-visual properties for a drawing element in chart drawings, including identifiers, names, descriptions, visibility, hyperlinks, and extension data.
/// </summary>
public interface NonVisualDrawingProperties
{
  /// <summary>
  /// Unique identifier assigned by the application to the drawing element.
  /// </summary>
  public UInt32? Id { get; set; }

  /// <summary>
  /// Name of the drawing element, compatible with the Office object model.
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  /// Textual description of the drawing element for accessibility or documentation.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// Indicates whether the drawing element is hidden from view.
  /// </summary>
  public bool? Hidden { get; set; }

  /// <summary>
  /// Title of the drawing element, used for display or accessibility.
  /// </summary>
  public string? Title { get; set; }

  /// <summary>
  /// Hyperlink information for click or selection actions on the drawing element.
  /// </summary>
  public HyperlinkOnClick? HyperlinkOnClick { get; set; }

  /// <summary>
  /// Hyperlink information for mouse hover actions on the drawing element.
  /// </summary>
  public HyperlinkOnHover? HyperlinkOnHover { get; set; }

  /// <summary>
  /// Extension list for future or custom non-visual drawing properties.
  /// </summary>
  public NonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList { get; set; }
}