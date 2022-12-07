namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualDrawingProperties Class.
/// </summary>
public class NonVisualDrawingProperties4Impl: ModelElement<DocumentFormat.OpenXml.Office2010.Drawing.Diagram.NonVisualDrawingProperties>, NonVisualDrawingProperties4
{
  /// <summary>
  /// Hyperlink associated with clicking or selecting the element..
  /// </summary>
  public HyperlinkOnClick? HyperlinkOnClick
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hyperlink associated with hovering over the element..
  /// </summary>
  public HyperlinkOnHover? HyperlinkOnHover
  {
    get;
    set;
  }
  
  /// <summary>
  /// Future extension.
  /// </summary>
  public NonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList
  {
    get;
    set;
  }
  
}
