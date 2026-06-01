namespace DocumentModel.Drawings.ChartDrawing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   IChart Non Visual Properties.
/// </summary>
public class NonVisualDrawingProperties: ModelElement
{
  /// <summary>
  ///   IApplication defined unique identifier.
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
  ///   Flag determining Ito show or hide this element.
  /// </summary>
  public bool? Hidden { get; set; }

  /// <summary>
  ///   Title
  /// </summary>
  public string? Title { get; set; }

  /// <summary>
  ///   IHyperlink associated with clicking or selecting the element..
  /// </summary>
  public HyperlinkOnClick? HyperlinkOnClick { get; set; }

  /// <summary>
  ///   IHyperlink associated with hovering over the element..
  /// </summary>
  public HyperlinkOnHover? HyperlinkOnHover { get; set; }

  /// <summary>
  ///   Future extension.
  /// </summary>
  public NonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList { get; set; }
}
