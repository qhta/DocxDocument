using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents non-visual properties for a drawing shape in a Wordprocessing document.
/// This class provides configuration for text box behavior, shape locking, and extension data, enabling control over shape interaction and extensibility.
/// </summary>
public partial class NonVisualDrawingShapeProperties : ModelElement<DXOD.NonVisualDrawingShapeProperties>, IExtendableElement
{
    /// <summary>
    /// Indicates whether the shape functions as a text box, allowing text to be contained within the shape.
    /// </summary>
    [OpenXmlProperty(nameof(DXOD.NonVisualDrawingShapeProperties.TextBox))]
    /// <summary>
    /// Indicates whether the shape functions as a text box, allowing text to be contained within the shape.
    /// </summary>
    [OpenXmlElement(typeof(DXOD.NonVisualDrawingShapeProperties))]
    public bool? TextBox { get => _TextBox; set => UpdateField(ref _TextBox, value, nameof(TextBox)); }

    private bool? _TextBox;
    /// <summary>
    /// The set of locks applied to the shape, restricting modifications or interactions as defined by the document.
    /// </summary>
    [OpenXmlProperty(nameof(DXOD.NonVisualDrawingShapeProperties.ShapeLocks))]
    /// <summary>
    /// The set of locks applied to the shape, restricting modifications or interactions as defined by the document.
    /// </summary>
    [OpenXmlElement(typeof(DXOD.NonVisualDrawingShapeProperties))]
    public ShapeLocks? ShapeLocks { get => _ShapeLocks; set => UpdateField(ref _ShapeLocks, value, nameof(ShapeLocks)); }

    private ShapeLocks? _ShapeLocks;
    /// <summary>
    /// List of extensions for the shape, allowing for additional properties and behaviors to be defined.
    /// </summary>
    [OpenXmlProperty(nameof(DXOD.NonVisualDrawingShapeProperties.ExtensionList))]
    /// <summary>
    /// List of extensions for the shape, allowing for additional properties and behaviors to be defined.
    /// </summary>
    [OpenXmlElement(typeof(DXOD.NonVisualDrawingShapeProperties))]
    public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

    private ExtensionList? _ExtensionList;
}