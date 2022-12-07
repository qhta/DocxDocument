namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualDrawingProperties Class.
/// </summary>
public interface NonVisualDrawingProperties1
{
  /// <summary>
  /// Hyperlink associated with clicking or selecting the element..
  /// </summary>
  public HyperlinkOnClick? HyperlinkOnClick { get ; set; }
  
  /// <summary>
  /// Hyperlink associated with hovering over the element..
  /// </summary>
  public HyperlinkOnHover? HyperlinkOnHover { get ; set; }
  
  /// <summary>
  /// Future extension.
  /// </summary>
  public NonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList { get ; set; }
  
}
