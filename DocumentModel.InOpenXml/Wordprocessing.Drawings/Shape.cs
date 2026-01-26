namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents a shape element within a Wordprocessing document.
/// This class provides access to visual and non-visual properties, styling, text box information, and linking for shapes embedded in the document.
/// </summary>
[OpenXmlType(typeof(DXD.Shape))]
public partial class Shape : ModelElement<DXD.Shape>, DMD.IOfficeArtExtendableElement
{
 /// <summary>
 /// Style information for the shape, including line, fill, and effect styles.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Shape.ShapeStyle))]
 [OpenXmlElement(typeof(DXD.Shape))]
 public ShapeStyle? ShapeStyle { get => _ShapeStyle; set => UpdateField(ref _ShapeStyle, value, nameof(ShapeStyle)); }

 private ShapeStyle? _ShapeStyle;
 /// <summary>
 /// Additional text box information, such as advanced text formatting and layout options.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Shape))]
 public TextBoxInfo2? TextBoxInfo2 { get => _TextBoxInfo2; set => UpdateField(ref _TextBoxInfo2, value, nameof(TextBoxInfo2)); }

 private TextBoxInfo2? _TextBoxInfo2;
 /// <summary>
 /// Linked text box information, enabling chaining of text across multiple shapes.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Shape))]
 public LinkedTextBox? LinkedTextBox { get => _LinkedTextBox; set => UpdateField(ref _LinkedTextBox, value, nameof(LinkedTextBox)); }

 private LinkedTextBox? _LinkedTextBox;
 /// <summary>
 /// Indicates whether normal East Asian text flow is applied to the shape's content.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Shape))]
 public bool? NormalEastAsianFlow { get => _NormalEastAsianFlow; set => UpdateField(ref _NormalEastAsianFlow, value, nameof(NormalEastAsianFlow)); }

 private bool? _NormalEastAsianFlow;
 /// <summary>
 /// Visual properties of the shape, such as geometry, fill, and effects.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Shape.ShapeProperties))]
 [OpenXmlElement(typeof(DXD.Shape))]
 public ShapeProperties? ShapeProperties { get => _ShapeProperties; set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties)); }

 private ShapeProperties? _ShapeProperties;
 /// <summary>
 /// Properties for the text body within the shape, including text layout and formatting.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Shape))]
 public TextBodyProperties? TextBodyProperties { get => _TextBodyProperties; set => UpdateField(ref _TextBodyProperties, value, nameof(TextBodyProperties)); }

 private TextBodyProperties? _TextBodyProperties;
 /// <summary>
 /// Non-visual properties for the drawing element, including identifiers, names, and descriptive information.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Shape))]
 public NonVisualDrawingProperties? NonVisualDrawingProperties { get => _NonVisualDrawingProperties; set => UpdateField(ref _NonVisualDrawingProperties, value, nameof(NonVisualDrawingProperties)); }

 private NonVisualDrawingProperties? _NonVisualDrawingProperties;
 /// <summary>
 /// Non-visual properties specific to drawing shapes, such as text box configuration and shape locks.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Shape))]
 public NonVisualDrawingShapeProperties? NonVisualDrawingShapeProperties { get => _NonVisualDrawingShapeProperties; set => UpdateField(ref _NonVisualDrawingShapeProperties, value, nameof(NonVisualDrawingShapeProperties)); }

 private NonVisualDrawingShapeProperties? _NonVisualDrawingShapeProperties;
 /// <summary>
 /// Non-visual properties for connector shapes, including connection locks and connection points.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Shape))]
 public NonVisualConnectorProperties? NonVisualConnectorProperties { get => _NonVisualConnectorProperties; set => UpdateField(ref _NonVisualConnectorProperties, value, nameof(NonVisualConnectorProperties)); }

 private NonVisualConnectorProperties? _NonVisualConnectorProperties;
 /// <summary>
 /// List of OfficeArt extensions associated with the shape, allowing for additional properties and behaviors to be defined.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Shape))]
 public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }

 private OfficeArtExtensionList? _OfficeArtExtensionList;
}