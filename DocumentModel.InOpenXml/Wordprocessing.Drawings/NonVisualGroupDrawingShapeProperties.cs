using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents non-visual properties for a group drawing shape in a Wordprocessing document.
/// This class provides configuration for group shape locks and extension data, enabling control over editing restrictions and extensibility for grouped shapes.
/// </summary>
public partial class NonVisualGroupDrawingShapeProperties : ModelElement
{
    /// <summary>
    /// The set of locks applied to the group shape, restricting modifications or interactions as defined by the document.
    /// </summary>
    public GroupShapeLocks? GroupShapeLocks { get => _GroupShapeLocks; set => UpdateField(ref _GroupShapeLocks, value, nameof(GroupShapeLocks)); }

    private GroupShapeLocks? _GroupShapeLocks;
    /// <summary>
    /// List of extensions for non-visual group drawing shape properties, allowing for additional metadata or custom features.
    /// </summary>
    public NonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList { get => _NonVisualGroupDrawingShapePropsExtensionList; set => UpdateField(ref _NonVisualGroupDrawingShapePropsExtensionList, value, nameof(NonVisualGroupDrawingShapePropsExtensionList)); }

    private NonVisualGroupDrawingShapePropsExtensionList? _NonVisualGroupDrawingShapePropsExtensionList;
}