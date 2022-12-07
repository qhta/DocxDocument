namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualDrawingProperties Class.
/// </summary>
public class NonVisualDrawingProperties3Impl: ModelElement<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualDrawingProperties>, NonVisualDrawingProperties3
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
