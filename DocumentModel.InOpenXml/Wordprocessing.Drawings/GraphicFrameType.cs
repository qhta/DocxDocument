using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the type definition for a graphic frame in a Wordprocessing document.
/// This class provides access to non-visual properties, transformation settings, the contained graphic, and extension data, enabling advanced layout, rendering, and extensibility for graphical content.
/// </summary>
public partial class GraphicFrameType : ModelElement<DXO10WDC.GraphicFrameType>
{
    /// <summary>
    /// Non-visual properties for the graphic frame, including identifiers, names, and descriptive information.
    /// </summary>
    public NonVisualDrawingProperties? NonVisualDrawingProperties { get => _NonVisualDrawingProperties; set => UpdateField(ref _NonVisualDrawingProperties, value, nameof(NonVisualDrawingProperties)); }

    private NonVisualDrawingProperties? _NonVisualDrawingProperties;
    /// <summary>
    /// Non-visual properties specific to the graphic frame, such as locking and extension settings.
    /// </summary>
    public NonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties { get; set; }
    /// <summary>
    /// The 2D transformation applied to the graphic frame, including translation, scaling, rotation, and skew.
    /// </summary>
    public Transform2D? Transform2D { get; set; }
    /// <summary>
    /// The graphic content contained within the frame, such as images, charts, or diagrams.
    /// </summary>
    public Graphic? Graphic { get; set; }
    /// <summary>
    /// List of OfficeArt extensions associated with the graphic frame, allowing for additional metadata or custom features.
    /// </summary>
    public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}