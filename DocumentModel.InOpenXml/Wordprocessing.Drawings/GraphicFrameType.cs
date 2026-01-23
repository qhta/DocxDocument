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
    public NonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties { get => _NonVisualGraphicFrameProperties; set => UpdateField(ref _NonVisualGraphicFrameProperties, value, nameof(NonVisualGraphicFrameProperties)); }

    private NonVisualGraphicFrameProperties? _NonVisualGraphicFrameProperties;
    /// <summary>
    /// The 2D transformation applied to the graphic frame, including translation, scaling, rotation, and skew.
    /// </summary>
    public Transform2D? Transform2D { get => _Transform2D; set => UpdateField(ref _Transform2D, value, nameof(Transform2D)); }

    private Transform2D? _Transform2D;
    /// <summary>
    /// The graphic content contained within the frame, such as images, charts, or diagrams.
    /// </summary>
    public Graphic? Graphic { get => _Graphic; set => UpdateField(ref _Graphic, value, nameof(Graphic)); }

    private Graphic? _Graphic;
    /// <summary>
    /// List of OfficeArt extensions associated with the graphic frame, allowing for additional metadata or custom features.
    /// </summary>
    public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }

    private OfficeArtExtensionList? _OfficeArtExtensionList;
}