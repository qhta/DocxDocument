using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents a graphic frame element in a Wordprocessing document.
/// This class provides access to non-visual properties, transformation settings, and the contained graphic, enabling advanced layout and rendering of graphical content such as images, charts, or diagrams within the document.
/// </summary>
public partial class GraphicFrame : ModelElement<DXD.GraphicFrame>, IOfficeArtExtendableElement
{
    /// <summary>
    /// Non-visual properties for the graphic frame, including identifiers, names, and descriptive information for the frame element.
    /// </summary>
    public NonVisualDrawingProperties? NonVisualDrawingProperties { get => _NonVisualDrawingProperties; set => UpdateField(ref _NonVisualDrawingProperties, value, nameof(NonVisualDrawingProperties)); }

    private NonVisualDrawingProperties? _NonVisualDrawingProperties;
    /// <summary>
    /// Non-visual properties specific to the graphic frame, such as locking and extension settings for advanced configuration.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.GraphicFrame.NonVisualGraphicFrameProperties))]
    public NonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties { get => _NonVisualGraphicFrameProperties; set => UpdateField(ref _NonVisualGraphicFrameProperties, value, nameof(NonVisualGraphicFrameProperties)); }

    private NonVisualGraphicFrameProperties? _NonVisualGraphicFrameProperties;
    /// <summary>
    /// The 2D transformation applied to the graphic frame, including translation, scaling, rotation, and skew, which determines the frame's position and orientation.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.GraphicFrame.Transform2D))]
    public Transform2D? Transform2D { get => _Transform2D; set => UpdateField(ref _Transform2D, value, nameof(Transform2D)); }

    private Transform2D? _Transform2D;
    /// <summary>
    /// The graphic content contained within the frame, which may include images, charts, diagrams, or other graphical objects.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.GraphicFrame.Graphic))]
    public Graphic? Graphic { get => _Graphic; set => UpdateField(ref _Graphic, value, nameof(Graphic)); }

    private Graphic? _Graphic;
    /// <summary>
    /// List of OfficeArt extensions associated with the graphic frame, allowing for additional properties and behaviors to be defined.
    /// </summary>
    public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }

    private OfficeArtExtensionList? _OfficeArtExtensionList;
}