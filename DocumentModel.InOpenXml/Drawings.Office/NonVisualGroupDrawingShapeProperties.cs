namespace DocumentModel.Drawings.Office;
/// <summary>
///   Defines the NonVisualGroupDrawingShapeProperties Class.
/// </summary>
public partial class NonVisualGroupDrawingShapeProperties : ModelElement<DXOD.NonVisualGroupDrawingShapeProperties>
{
    /// <summary>
    ///   GroupShapeLocks.
    /// </summary>
    public GroupShapeLocks? GroupShapeLocks { get => _GroupShapeLocks; set => UpdateField(ref _GroupShapeLocks, value, nameof(GroupShapeLocks)); }

    private GroupShapeLocks? _GroupShapeLocks;
    /// <summary>
    ///   NonVisualGroupDrawingShapePropsExtensionList.
    /// </summary>
    public NonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList { get; set; }
}