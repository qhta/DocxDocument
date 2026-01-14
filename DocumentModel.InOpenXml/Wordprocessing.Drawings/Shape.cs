namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents a shape element within a Wordprocessing document.
/// This interface provides access to visual and non-visual properties, styling, text box information, and linking for shapes embedded in the document.
/// </summary>
public interface Shape: ICollectionItem, DMD.IOfficeArtExtendableElement
{
  /// <summary>
  /// Style information for the shape, including line, fill, and effect styles.
  /// </summary>
  public ShapeStyle? ShapeStyle { get; set; }

  /// <summary>
  /// Additional text box information, such as advanced text formatting and layout options.
  /// </summary>
  public TextBoxInfo2? TextBoxInfo2 { get; set; }

  /// <summary>
  /// Linked text box information, enabling chaining of text across multiple shapes.
  /// </summary>
  public LinkedTextBox? LinkedTextBox { get; set; }

  /// <summary>
  /// Indicates whether normal East Asian text flow is applied to the shape's content.
  /// </summary>
  public bool? NormalEastAsianFlow { get; set; }

  /// <summary>
  /// Visual properties of the shape, such as geometry, fill, and effects.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  /// Properties for the text body within the shape, including text layout and formatting.
  /// </summary>
  public TextBodyProperties? TextBodyProperties { get; set; }

  /// <summary>
  /// Non-visual properties for the drawing element, including identifiers, names, and descriptive information.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }

  /// <summary>
  /// Non-visual properties specific to drawing shapes, such as text box configuration and shape locks.
  /// </summary>
  public NonVisualDrawingShapeProperties? NonVisualDrawingShapeProperties { get; set; }

  /// <summary>
  /// Non-visual properties for connector shapes, including connection locks and connection points.
  /// </summary>
  public NonVisualConnectorProperties? NonVisualConnectorProperties { get; set; }

}