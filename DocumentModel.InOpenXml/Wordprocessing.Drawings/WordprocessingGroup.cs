namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents a group of drawing elements within a Wordprocessing document.
/// This class provides access to non-visual properties, group properties, child shapes, graphic frames, pictures, and extension data, enabling hierarchical organization and advanced layout of graphical content.
/// </summary>
public partial class WordprocessingGroup : ModelElement
{
    /// <summary>
    /// Non-visual properties for the group, including identifiers, names, and descriptive information.
    /// </summary>
    public NonVisualDrawingProperties? NonVisualDrawingProperties { get => _NonVisualDrawingProperties; set => UpdateField(ref _NonVisualDrawingProperties, value, nameof(NonVisualDrawingProperties)); }

    private NonVisualDrawingProperties? _NonVisualDrawingProperties;
    /// <summary>
    /// Non-visual properties specific to group drawing shapes, such as locking and extension settings.
    /// </summary>
    public NonVisualGroupDrawingShapeProperties? NonVisualGroupDrawingShapeProperties { get; set; }
    /// <summary>
    /// Properties for the group shape, including layout, transformation, and grouping behavior.
    /// </summary>
    public GroupShapeProperties? GroupShapeProperties { get; set; }
    /// <summary>
    /// A shape element contained within the group, representing an individual graphical object.
    /// </summary>
    public Shape? WordprocessingShape { get; set; }
    /// <summary>
    /// A child group shape element, enabling nested grouping of shapes for hierarchical organization.
    /// </summary>
    public GroupShape? GroupShape { get; set; }
    /// <summary>
    /// A graphic frame element contained within the group, used for advanced graphical content such as images, charts, or diagrams.
    /// </summary>
    public GraphicFrame? GraphicFrame { get; set; }
    /// <summary>
    /// A picture element contained within the group, representing an embedded image.
    /// </summary>
    public DocumentModel.Drawings.Pictures.Picture? Picture { get; set; }
    /// <summary>
    /// List of OfficeArt extensions associated with the group, allowing for additional metadata or custom features.
    /// </summary>
    public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}